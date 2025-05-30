namespace PROJE0101  //Sinem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int filmNo;

        private void button1_Click(object sender, EventArgs e)
        {
            filmNo = 1;
            Form2 frm = new Form2(); 
            frm.ShowDialog(); 
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            filmNo = 2;
            Form2 frm = new Form2(); 
            frm.ShowDialog(); 
           Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filmNo = 3;
            Form2 frm = new Form2(); 
            frm.ShowDialog(); 
            Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            filmNo = 4;
            Form2 frm = new Form2(); 
            frm.ShowDialog(); 
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filmNo = 5;
            Form2 frm = new Form2(); 
            frm.ShowDialog(); 
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            filmNo = 6;
            Form2 frm = new Form2(); 
            frm.ShowDialog(); 
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
