using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace SinemaBiletSatis
{
    public partial class odemeyontemi : Form
    {
        public odemeyontemi()
        {
            InitializeComponent();
        }

        private void odemeyontemi_Load(object sender, EventArgs e)
        {
            
            label4.Text = Interaction.InputBox("Müşrüteri İsim:");
            label5.Text = DateTime.Now.ToShortDateString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int ucret = int.Parse(label9.Text);
                
                if (textBox1.Text == null)
                {
                    MessageBox.Show("Hata Değer Boş Olamaz!");
                }
                if (a < ucret)
                {
                    MessageBox.Show("Hata Yetersiz Ücret!");
                }
                else
                {
                    label14.Text = (a - ucret).ToString();
                }


            }
            catch { MessageBox.Show("Hata Oluştu..."); }

;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 class1  = new Class1();
            class1.kapat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Filmsecim filmsecim = new Filmsecim();
            this.Visible = false;
            filmsecim.ShowDialog();
            this.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
