namespace sayisalLoto_uyg_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int number1, number2, number3, number4;

            // sayýlarýmýz  =>   Next(1, 10) == 1 < rastgele  sayilar < 10 
            number1 = rastgele.Next(0, 10);
            number2 = rastgele.Next(0, 10);
            number3 = rastgele.Next(0, 10);
            number4 = rastgele.Next(0, 10);

            // number'larý labellara yazalým 
            label1.Text = number1.ToString();
            label2.Text = number2.ToString();
            label3.Text = number3.ToString();
            label4.Text = number4.ToString();

            // simdi kontrol zamaný control time 

            // number1 sayimizi tutturma 
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Pink;
            }

            else
            {
                textBox1.BackColor = Color.Red;

            }
            // number2 sayimizi tutturma 
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Pink;

            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            // number3 sayimizi tutturma 
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Pink;
            }
            else
            {
                textBox3.BackColor = Color.Red;

            }

            // number4 sayimizi tutturma 
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Pink;
            }
            else
            {
                textBox4.BackColor = Color.Red;

            }

            if ((textBox1.Text == label1.Text) && (textBox2.Text == label2.Text) && (textBox3.Text == label3.Text) && (textBox4.Text == label4.Text))
            {
                MessageBox.Show("Tebrikler Kazandýnýz.");
            }
            else
            {
                MessageBox.Show("Yarýþmamýz Devam Ediyor Bir Sonraki Deneme Yapýlýyor...");
            }


        }
    }
}