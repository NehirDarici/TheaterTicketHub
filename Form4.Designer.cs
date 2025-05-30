namespace PROJE0101
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonOdeme = new Button();
            textBox7 = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSteelBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(57, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 24);
            textBox1.TabIndex = 0;
            textBox1.Text = "Ad Soyad";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(67, 80);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 32);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightSteelBlue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.Location = new Point(67, 145);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Kart Numarası";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(84, 295);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(64, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightSteelBlue;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox5.Location = new Point(261, 262);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(116, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "SKT(mm/yy)";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Info;
            textBox6.Location = new Point(261, 295);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(102, 27);
            textBox6.TabIndex = 5;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.Info;
            textBox8.Location = new Point(355, 61);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(68, 32);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.LightSteelBlue;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Enabled = false;
            textBox9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox9.Location = new Point(46, 262);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(102, 27);
            textBox9.TabIndex = 8;
            textBox9.Text = "CVV";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.BackColor = SystemColors.Info;
            textBox10.Location = new Point(67, 178);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(260, 27);
            textBox10.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 7.8F, FontStyle.Italic);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(67, 115);
            label1.Name = "label1";
            label1.Size = new Size(280, 16);
            label1.TabIndex = 10;
            label1.Text = "İSİM SOYİSİM HATALI ! TEKRAR DENEYİNİZ";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 7.8F, FontStyle.Italic);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(25, 325);
            label2.Name = "label2";
            label2.Size = new Size(221, 16);
            label2.TabIndex = 11;
            label2.Text = "CVV HATALI ! TEKRAR DENEYİNİZ";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 7.8F, FontStyle.Italic);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(67, 208);
            label3.Name = "label3";
            label3.Size = new Size(301, 16);
            label3.TabIndex = 12;
            label3.Text = "KART NUMARASI HATALI ! TEKRAR DENEYİNİZ";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightSteelBlue;
            label4.Font = new Font("Arial", 7.8F, FontStyle.Italic);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(473, 374);
            label4.Name = "label4";
            label4.Size = new Size(220, 16);
            label4.TabIndex = 13;
            label4.Text = "STK HATALI ! TEKRAR DENEYİNİZ";
            label4.Visible = false;
            // 
            // buttonOdeme
            // 
            buttonOdeme.BackColor = Color.Khaki;
            buttonOdeme.Location = new Point(183, 362);
            buttonOdeme.Name = "buttonOdeme";
            buttonOdeme.Size = new Size(94, 44);
            buttonOdeme.TabIndex = 14;
            buttonOdeme.Text = "Ödeme Yap";
            buttonOdeme.UseVisualStyleBackColor = false;
            buttonOdeme.Click += button1_Click_1;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.LightSteelBlue;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Enabled = false;
            textBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox7.Location = new Point(303, 28);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(190, 27);
            textBox7.TabIndex = 6;
            textBox7.Text = "Ödenecek Tutar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(buttonOdeme);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(212, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 444);
            panel1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(261, 325);
            label8.Name = "label8";
            label8.Size = new Size(192, 20);
            label8.TabIndex = 18;
            label8.Text = "*Lütfen bu alanı doldurunuz";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(34, 325);
            label7.Name = "label7";
            label7.Size = new Size(192, 20);
            label7.TabIndex = 17;
            label7.Text = "*Lütfen bu alanı doldurunuz";
            label7.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(63, 112);
            label5.Name = "label5";
            label5.Size = new Size(192, 20);
            label5.TabIndex = 15;
            label5.Text = "*Lütfen bu alanı doldurunuz";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(63, 205);
            label6.Name = "label6";
            label6.Size = new Size(192, 20);
            label6.TabIndex = 16;
            label6.Text = "*Lütfen bu alanı doldurunuz";
            label6.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(932, 541);
            Controls.Add(panel1);
            Controls.Add(label4);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ÖDEME EKRANI";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOdeme;
        private TextBox textBox7;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
    }
}