using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace SinemaBiletSatis
{
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }


        Filmsecim filmsecim = new Filmsecim();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            filmsecim.ShowDialog();
        }

        private async void Baslangic_Load(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                // Tam ekran modundaysa, normal boyuta getirin
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                // Tam ekran modunda değilse, tam ekran yapın
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }//Buradaki kodu yapayzekadan yardım alarak yazdım.

            while (true)
            {
                if(progressBar1.Value == 100) 
                {
                    this.Hide();
                    filmsecim.ShowDialog();
                    break; 
                }
                await Task.Delay(1000);
                progressBar1.Value += 10;
            }
            

        }
    }
}
