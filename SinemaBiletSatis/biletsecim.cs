using System;
using System.Windows.Forms;
namespace SinemaBiletSatis
{
    public partial class biletsecim : Form
    {
        public biletsecim()
        {
            InitializeComponent();
        }

        private void biletsecim_Load(object sender, EventArgs e)
        {
           
        }
        class degiskenler
        {

            int Toplamfiyat;
            public int tf
            {
                get { return Toplamfiyat; }
                set { Toplamfiyat = value; }
            }
            int koltuksayisi;
            public int ks
            {
                get { return koltuksayisi; }
                set { koltuksayisi = value; }
            }
        }
        degiskenler d = new degiskenler();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text) + 1;
                textBox1.Text = a.ToString();
                d.tf += 80;
                d.ks++;
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text) - 1;
                textBox1.Text = a.ToString();
                if (textBox1.Text == "-1")
                {
                    textBox1.Text = "0";
                    d.tf += 80;
                    d.ks++;
                }
                d.ks--;
                d.tf -= 80;
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox2.Text) + 1;
                textBox2.Text = a.ToString();
                d.tf += 40;
                d.ks++;
            }

            catch
            {
                MessageBox.Show("Hata Oluştu...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox2.Text) - 1;
                textBox2.Text = a.ToString();
                if (textBox2.Text == "-1")
                {
                    textBox2.Text = "0";
                    d.tf += 40;
                    d.ks++;
                }
                d.ks--;
                d.tf -= 40;
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0) { d.tf += 40; }
                if (comboBox1.SelectedIndex == 1) { d.tf += 55; }
                if (comboBox1.SelectedIndex == 2) { d.tf += 70; }

                DialogResult a = MessageBox.Show("Toplam tutar=" + d.tf, "Onay", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    koltuksecimekrani b = new koltuksecimekrani();

                    b.label9.Text = d.ks.ToString();
                    b.label13.Text = (d.tf).ToString();
                    b.label14.Text = d.ks.ToString();
                    b.label15.Text = label6.Text;
                    b.label16.Text = label7.Text;
                    this.Visible = false;
                    b.ShowDialog();
                    this.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Hata Oluştu...");
            }

        }
        Class1 class1 = new Class1();
        private void button6_Click(object sender, EventArgs e)
        {
            class1.kapat();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) { d.tf += 20; }
            if (comboBox2.SelectedIndex == 1) { d.tf += 17; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
