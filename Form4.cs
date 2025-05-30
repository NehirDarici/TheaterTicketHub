using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJE0101
{
    public partial class Form4 : Form
    {  
      
      
        public Form4()
        {
            InitializeComponent();
        }
        string connectionString = @"Server=DESKTOP-JEA5RNF;Database=BMT110;Trusted_Connection=True;TrustServerCertificate=True;";

        //Yağmur
        #region

        public static bool OdemeDurumu = false;
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox8.Text = Form2.Top_Ucret.ToString();
        
        }

        #endregion

        //Nehir
        #region 
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool adDogru;
                bool kartDogru;
                bool ccvDogru;
                bool tarihDogru;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string query = @"
                    SELECT 
                        CASE WHEN [Ad Soyad] = @AdSoyad THEN 1 ELSE 0 END AS AdDogru,
                        CASE WHEN [Kart No] = @KartNo THEN 1 ELSE 0 END AS KartDogru,
                        CASE WHEN CCV = @CCV THEN 1 ELSE 0 END AS CCVDogru,
                        CASE WHEN [Son Kullanma Tarihi] = @SonKullanma THEN 1 ELSE 0 END AS TarihDogru
                    FROM kartbilgileri_liste
                   
                   ";




                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@AdSoyad", textBox2.Text);
                    command.Parameters.AddWithValue("@KartNo", textBox10.Text);
                    command.Parameters.AddWithValue("@CCV", textBox4.Text);
                    command.Parameters.AddWithValue("@SonKullanma", textBox6.Text);

                    SqlDataReader reader = command.ExecuteReader();


                    // tekstBoxların boş olup olmadığına bakıyoruz
                    bool adGirdi = !string.IsNullOrEmpty(textBox2.Text);
                    bool kartGirdi = !string.IsNullOrEmpty(textBox10.Text);
                    bool ccvGirdi = !string.IsNullOrEmpty(textBox4.Text);
                    bool tarihGirdi = !string.IsNullOrEmpty(textBox6.Text);
                    

                    

                    if (reader.Read())
                    {
                        

                        adDogru = reader.GetInt32(0) == 1;
                        kartDogru = reader.GetInt32(1) == 1;
                        ccvDogru = reader.GetInt32(2) == 1;
                        tarihDogru = reader.GetInt32(3) == 1;



                       


                        // Her biri girildiyse ve doğru değilse label'ı göster
                        if ((!adDogru) && adGirdi)
                            label1.Visible = true;

                        if (!adGirdi) label5.Visible = true;//textbox boşsa görünür


                        if ((!kartDogru) && kartGirdi)
                            label3.Visible = true;
                        if (!kartGirdi) label6.Visible = true;

                        if ((!ccvDogru) && ccvGirdi)
                            label2.Visible = true;
                        if (!ccvGirdi) label7.Visible = true;

                        if ((!tarihDogru) && tarihGirdi)
                            label4.Visible = true;
                        if (!tarihGirdi) label8.Visible = true;

                        #region
                        if (adDogru && kartDogru && ccvDogru && tarihDogru)
                        {
                            OdemeDurumu = true;
                           
                            this.Close();
                            return; // form kapatılıyor, çık
                        }
                        else
                        {
                            OdemeDurumu = false;

                        }

                        #endregion



                    }


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            finally { }


        }


#endregion

        
        
    }
}

