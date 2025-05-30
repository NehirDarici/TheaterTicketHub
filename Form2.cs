using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace PROJE0101
{
    public partial class Form2 : Form
    {string connectionString = @"Server=DESKTOP-JEA5RNF;Database=BMT110;Trusted_Connection=True;TrustServerCertificate=True;";

        private List<Button> SeciliButonlar = new List<Button>();
        Dictionary<string, bool> durumlar = new Dictionary<string, bool>();//dizi oluşturmuş gibi ama her üyenin 0 ya da 1 değeri var 
        

        public Form2()
        {
            InitializeComponent();
        }

        public static int FilmNo = Form1.filmNo;
        public static int Top_Ucret = 0; //toplam ücreti tutacak değişken
       
        int doluluk = 0;//koltuk doluluğunu tutacak değişken
      
        private void buttonClick(object sender, EventArgs e)//Koltuk Seçimi
        {
            Button btn = sender as Button;
            //BUtona bir kere tıkladığında seçer bir kere daha tıkladığında seçimden çıkarır
            #region
            bool seciliMi = false;

            // BUtonların tag durumunu kontrol et seciliMi ye at
            if (btn.Tag != null)
                seciliMi = Convert.ToBoolean(btn.Tag);


            if (seciliMi)
            {
                // Seçili ise, çıkar
                btn.Tag = false;

                btn.BackColor = SystemColors.ActiveCaption;

                // Listeden çıkar

                if (SeciliButonlar.Contains(btn))
                    SeciliButonlar.Remove(btn);
                Top_Ucret -= 250;//iptal edince ücreti azalt

            }
            else
            {
                // Seçili değil, seç
                btn.Tag = true;
                btn.BackColor = Color.IndianRed;

                // Listeye ekle
                if (!SeciliButonlar.Contains(btn))
                    SeciliButonlar.Add(btn);
                Top_Ucret += 250;//seçince ücreti artır
            }

            // Listeyi güncelle
            Goster();
            Hesapla();
            #endregion
        }

        private void Goster()

        {

            SecilenKoltuklar.Items.Clear();//sadece son bastığımızı eklesin diye

            foreach (Button btn in SeciliButonlar)
            {

                SecilenKoltuklar.Items.Add(btn.Text);

            }
        }
        private void Hesapla()
        {
            ToplamUcret.Text = Top_Ucret + " TL";
        }




        private void Form2_Load(object sender, EventArgs e) //koltuk seçme
        {
            
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    #region //Gülsüm

                    connection.Open();
                    string query = $"SELECT KoltukNo, Secilme_Durumu{FilmNo} FROM dbo.TiyatroKoltuk";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string koltukNo = Convert.ToString(reader["KoltukNo"]);
                            bool isSelected = reader[$"Secilme_Durumu{FilmNo}"] != DBNull.Value && Convert.ToBoolean(reader[$"Secilme_Durumu{FilmNo}"]);
                            durumlar[koltukNo] = isSelected;
                            if (isSelected) doluluk++;
                        }
                        reader.Close();
                        #endregion



                        #region //Yağmur
                        foreach (Control c in this.Controls)
                        {                              

                            if (c is Button btn)
                            {
                                if (durumlar.ContainsKey(btn.Text))
                                {
                                    bool durum = durumlar[btn.Text];
                                  

                                    // Duruma göre butonun aktiflik ve rengini ayarla
                                    if (durum) // 1 ise, seçilmiş ise
                                    {
                                        btn.Enabled = false; // butonun tıklanma durumunu false yaptık
                                        btn.BackColor = Color.DarkGray;
                                    }
                                    else
                                    {
                                        btn.Enabled = true;
                                        btn.BackColor = SystemColors.ActiveCaption;
                                    }
                                }
                               
                            }

                        }

                        #endregion

                        if (doluluk == 20)
                        {
                            label6.Visible = true;
                        }
                        
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veri alınırken sorun oluştu: " + ex.Message);
            }

            
        }
        #region //Yağmur


        public static bool odemeDurumu = Form4.OdemeDurumu;//ödemenin gerçekleşip gerçekleşmediğine göre geri bildirim veriyor
        private void button24_Click(object sender, EventArgs e) //ödeme butonu
        { try
            {
                if (SecilenKoltuklar.Items.Count != 0 && doluluk != 20)//en az 1 koltuk seçiliyse ve tüm koltuklar dolu değilse çalışacak
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                       connection.Open();
                        
                        Form4 frm = new Form4();
                      
                        frm.ShowDialog(); // formu aç
                        string cevap=Form4.OdemeDurumu.ToString();
                     
                        if (Convert.ToBoolean(cevap))
                        {
                            foreach (Button btn in SeciliButonlar)
                            {
                                String btnText = btn.Text;
                                durumlar[btn.Text] = true;//seçilen butonların durumunu değiştirdik
                                bool durum = durumlar[btnText];
                                string sql = $"UPDATE dbo.TiyatroKoltuk SET  Secilme_Durumu{FilmNo}=@Durum WHERE KoltukNo=@btnText; ";
                                SqlCommand command = new SqlCommand(sql, connection);
                                command.Parameters.AddWithValue("@Durum", durum);
                                command.Parameters.AddWithValue("@btnText", btnText);
                                command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Ödemeniz alındı.İyi Günler dileriz.");
                        }
                        else
                        {
                            MessageBox.Show("Ödeme gerçekleşmedi.Lütfen tekrar deneyiniz");
                        }
                    }

                }
                else if (doluluk == 20)
                {
                    MessageBox.Show("Tüm koltuklar dolu.Bilet satın alamazsınız");
                    
                }
                else
                {
                    MessageBox.Show("Lütfen en az 1 koltuk seçiniz.");
                   
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally
            {
                Close();
            }
            
        }
        #endregion
        
    }
} 
