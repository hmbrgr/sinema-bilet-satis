using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace SinemaBiletSatis
{

    public partial class Filmsecim : Form
    {
        public Filmsecim()
        {
            InitializeComponent();
        }
        class Film
        {
            public string Yenifilm
            {
                get; set;
            }

            public string yer
            {
                get; set;
            }

        }
        Film f = new Film();
        OpenFileDialog yer = new OpenFileDialog();
        biletsecim b = new biletsecim();

        void ekle()
        {

            b.label7.Text = "Salon" + salon;
        }
        byte salon;
        void film()
        {

            yer.ShowDialog();
            f.yer = (yer.FileName);

        }
        string film1;
        string film2;
        string film3;
        string film4;
        string film5;
        string film6;
        string film7;
        string film8;
        string film9;
        string film10;
        string film11;
        string film12;
        string film13;
        string film14;

        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult a = MessageBox.Show("Bir Film Kapağı Seçiniz...", "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(a == DialogResult.Cancel) { Application.Exit(); }
                film();
                film1 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox1.ImageLocation = f.yer;
                label1.Text = ("Film Adı:" + film1);
                pictureBox1.Visible = true;
                label1.Visible = true;
                button1.Visible = true;
                

            }
            catch (Exception hatabaslanıc)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hatabaslanıc);
            }
        }
        public void Form1_Closing(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film7 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                label7.Text = ("Film Adı:" + film7);
                pictureBox7.ImageLocation = f.yer;
                pictureBox7.Visible = true;
                label7.Visible = true;
                button7.Visible = true;
            }
            catch (Exception hatabaslanıc)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hatabaslanıc);
            }
        }


        public void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film1 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                label1.Text = ("Film Adı:" + film1);
                pictureBox1.ImageLocation = f.yer;
                pictureBox1.Visible = true;
                label1.Visible = true;
                button1.Visible = true;
            }
            catch (Exception hatabaslanıc)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hatabaslanıc);
            }

        }
        public void filmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film2 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox2.ImageLocation = f.yer;
                label2.Text = ("Film Adı:" + film2);
                pictureBox2.Visible = true;
                label2.Visible = true;
                button2.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);

            }

        }

        public void filmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film3 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox3.ImageLocation = f.yer;
                label3.Text = ("Film Adı:" + film3);
                pictureBox3.Visible = true;
                label3.Visible = true;
                button3.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);

            }

        }

        public void filmToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film4 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox4.ImageLocation = f.yer;
                label4.Text = ("Film Adı:" + film4);
                pictureBox4.Visible = true;
                label4.Visible = true;
                button4.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);

            }

        }

        public void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film5 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox5.ImageLocation = f.yer;
                label5.Text = ("Film Adı:" + film5);
                pictureBox5.Visible = true;
                label5.Visible = true;
                button5.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);

            }

        }

        public void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film6 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox6.ImageLocation = f.yer;
                label6.Text = ("Film Adı:" + film6);
                pictureBox6.Visible = true;
                label6.Visible = true;
                button6.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);

            }
        }

        public void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film8 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox8.ImageLocation = f.yer;
                label8.Text = ("Film Adı:" + film8);
                pictureBox8.Visible = true;
                label8.Visible = true;
                button8.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }

        }

        public void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film9 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox9.ImageLocation = f.yer;
                label9.Text = ("Film Adı:" + film9);
                pictureBox9.Visible = true;
                label9.Visible = true;
                button9.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        public void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film10 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox10.ImageLocation = f.yer;
                label10.Text = ("Film Adı:" + film10);
                pictureBox10.Visible = true;
                label10.Visible = true;
                button10.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        public void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film11 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox11.ImageLocation = f.yer;
                label11.Text = ("Film Adı:" + film11);
                pictureBox11.Visible = true;
                label11.Visible = true;
                button11.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        public void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film12 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox12.ImageLocation = f.yer;
                label12.Text = ("Film Adı:" + film12);
                pictureBox12.Visible = true;
                label12.Visible = true;
                button12.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }


        }

        public void filmToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film13 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox13.ImageLocation = f.yer;
                label13.Text = ("Film Adı:" + film13);
                pictureBox13.Visible = true;
                label13.Visible = true;
                button13.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        public void filmToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                film();
                film14 = Interaction.InputBox("Film Adı:", "Film Adı Giriş");
                pictureBox14.ImageLocation = f.yer;
                label14.Text = ("Film Adı:" + film14);
                pictureBox14.Visible = true;
                label14.Visible = true;
                button14.Visible = true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            try
            {

                label1.Visible = false;

                label1.Text = ("");
                pictureBox1.Image = null;
                button1.Visible = false;
                pictureBox1.Visible = false;
                film1 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Visible = false;

                label2.Text = ("");
                pictureBox2.Image = null;
                pictureBox2.Visible = false;
                button2.Visible = false;
                film2 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Visible = false;

                label3.Text = ("");
                pictureBox3.Image = null;
                pictureBox3.Visible = false;
                button3.Visible = false;
                film3 = null;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Visible = false;

                label4.Text = ("");
                pictureBox4.Image = null;
                pictureBox4.Visible = false;
                button4.Visible = false;
                film4 = null;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Visible = false;

                label5.Text = ("");
                pictureBox5.Image = null;
                pictureBox5.Visible = false;
                button5.Visible = false;
                film5 = null;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            try
            {
                label6.Visible = false;

                label6.Text = ("");
                pictureBox6.Image = null;
                pictureBox6.Visible = false;
                button6.Visible = false;
                film6 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            try
            {
                label7.Visible = false;

                label7.Text = ("");
                pictureBox7.Image = null;
                pictureBox7.Visible = false;
                button7.Visible = false;
                film7 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Visible = false;

                label8.Text = ("");
                pictureBox8.Image = null;
                pictureBox8.Visible = false;
                button8.Visible = false;
                film8 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            try
            {
                label9.Visible = false;

                label9.Text = ("");
                pictureBox9.Image = null;
                pictureBox9.Visible = false;
                button9.Visible = false;
                film9 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            try
            {
                label10.Visible = false;

                label10.Text = ("");
                pictureBox10.Image = null;
                pictureBox10.Visible = false;
                button10.Visible = false;
                film10 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Visible = false;

                label11.Text = ("");
                pictureBox11.Image = null;
                pictureBox11.Visible = false;
                button11.Visible = false;
                film11 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            try
            {
                label12.Visible = false;

                label12.Text = ("");
                pictureBox12.Image = null;
                pictureBox12.Visible = false;
                button12.Visible = false;
                film12 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            try
            {
                label13.Visible = false;

                label13.Text = ("");
                pictureBox13.Image = null;
                pictureBox13.Visible = false;
                button13.Visible = false;
                film13 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            try
            {
                label14.Visible = false;

                label14.Text = ("");
                pictureBox14.Image = null;
                pictureBox14.Visible = false;
                button14.Visible = false;
                film14 = null;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu , Daha Sonra Tekrar Deneyiniz..." + hata);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                salon = 1;
                b.label6.Text = film1;
                ekle();
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 2;
                ekle();
                b.label6.Text = film2;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;
            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 3;
                ekle();
                b.label6.Text = film3;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 4;
                ekle();
                b.label6.Text = film4;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;
            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 5;
                ekle();
                b.label6.Text = film5;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 6;
                ekle();
                b.label6.Text = film6;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 7;
                ekle();
                b.label6.Text = film7;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 8;
                b.label6.Text = film8;
                ekle();
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 9;
                ekle();
                b.label6.Text = film9;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 10;
                ekle();
                b.label6.Text = film10;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 11;
                ekle();
                b.label6.Text = film11;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 12;
                ekle();
                b.label6.Text = film12;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 13;
                ekle();
                b.label6.Text = film13;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                salon = 14;
                ekle();
                b.label6.Text = film14;
                this.Visible = false;
                b.ShowDialog();
                this.Visible = true;

            }
            catch { MessageBox.Show("Hata Oluştu Tekrar Deneyiniz..."); }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Çıkmak İstiyor Musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes) Application.Exit();

        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }

}
