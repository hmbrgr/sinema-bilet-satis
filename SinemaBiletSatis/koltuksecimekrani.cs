using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace SinemaBiletSatis
{
    
    public partial class koltuksecimekrani : Form
    {
        public koltuksecimekrani()
        {
            InitializeComponent();
        }
        string[] koltuklar = new string[150];
        int index = 0;
        private void A1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A1.BackColor = Color.DarkRed;
                A1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A1";
                index++;
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {

            if (label9.Text != "0")
            {
                A2.BackColor = Color.DarkRed;
                A2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A2";
                index++;
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A3.BackColor = Color.DarkRed;
                A3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A3";
                index++;
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A4.BackColor = Color.DarkRed;
                A4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A4";
                index++;
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A5.BackColor = Color.DarkRed;
                A5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A5";
                index++;
            }
        }

        private void A6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A6.BackColor = Color.DarkRed;
                A6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A6";
                index++;
            }
        }
        private void A7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A7.BackColor = Color.DarkRed;
                A7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A7";
                index++;
            }
        }

        private void A8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A8.BackColor = Color.DarkRed;
                A8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A8";
                index++;
            }
        }

        private void A9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A9.BackColor = Color.DarkRed;
                A9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A9";
                index++;
            }
        }

        private void A10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A10.BackColor = Color.DarkRed;
                A10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A10";
                index++;
            }
        }

        private void A11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A11.BackColor = Color.DarkRed;
                A11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A11";
                index++;
            }
        }

        private void A12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A12.BackColor = Color.DarkRed;
                A12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A12";
                index++;
            }
        }

        private void A13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A13.BackColor = Color.DarkRed;
                A13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A13";
                index++;
            }
        }

        private void A15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A15.BackColor = Color.DarkRed;
                A15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A15";
                index++;
            }
        }

        private void A14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                A14.BackColor = Color.DarkRed;
                A14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "A14";
                index++;
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B1.BackColor = Color.DarkRed;
                B1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B1";
                index++;
            }
        }

        private void B12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B12.BackColor = Color.DarkRed;
                B12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B12";
                index++;
            }
        }

        private void B11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B11.BackColor = Color.DarkRed;
                B11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B11";
                index++;
            }
        }

        private void B10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B10.BackColor = Color.DarkRed;
                B10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B10";
                index++;
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B9.BackColor = Color.DarkRed;
                B9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B9";
                index++;
            }
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B8.BackColor = Color.DarkRed;
                B8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B8";
                index++;
            }
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B7.BackColor = Color.DarkRed;
                B7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B7";
                index++;
            }
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B6.BackColor = Color.DarkRed;
                B6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B6";
                index++;
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B5.BackColor = Color.DarkRed;
                B5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B5";
                index++;
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B4.BackColor = Color.DarkRed;
                B4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B4";
                index++;
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B3.BackColor = Color.DarkRed;
                B3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B3";
                index++;
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B2.BackColor = Color.DarkRed;
                B2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B2";
                index++;
            }
        }

        private void B15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B15.BackColor = Color.DarkRed;
                B15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B15";
                index++;
            }
        }

        private void B14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B14.BackColor = Color.DarkRed;
                B14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B14";
                index++;
            }
        }

        private void B13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                B13.BackColor = Color.DarkRed;
                B13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "B13";
                index++;
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C1.BackColor = Color.DarkRed;
                C1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C1";
                index++;
            }
        }

        private void C12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C12.BackColor = Color.DarkRed;
                C12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C12";
                index++;
            }
        }

        private void C11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C11.BackColor = Color.DarkRed;
                C11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C11";
                index++;
            }
        }

        private void C10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C10.BackColor = Color.DarkRed;
                C10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C10";
                index++;
            }
        }

        private void C15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C15.BackColor = Color.DarkRed;
                C15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C15";
                index++;
            }
        }

        private void C14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C14.BackColor = Color.DarkRed;
                C14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C14";
                index++;
            }
        }

        private void C9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C9.BackColor = Color.DarkRed;
                C9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C9";
                index++;
            }
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C8.BackColor = Color.DarkRed;
                C8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C8";
                index++;
            }
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C7.BackColor = Color.DarkRed;
                C7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C7";
                index++;
            }
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C6.BackColor = Color.DarkRed;
                C6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C6";
                index++;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C5.BackColor = Color.DarkRed;
                C5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C5";
                index++;
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C4.BackColor = Color.DarkRed;
                C4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C4";
                index++;
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C3.BackColor = Color.DarkRed;
                C3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C3";
                index++;
            }

        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C2.BackColor = Color.DarkRed;
                C2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C2";
                index++;
            }

        }

        private void C13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                C13.BackColor = Color.DarkRed;
                C13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "C13";
                index++;
            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D1.BackColor = Color.DarkRed;
                D1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D1";
                index++;
            }
        }

        private void D12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D12.BackColor = Color.DarkRed;
                D12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D12";
                index++;
            }
        }

        private void D11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D11.BackColor = Color.DarkRed;
                D11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D11";
                index++;
            }
        }

        private void D10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D10.BackColor = Color.DarkRed;
                D10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D10";
                index++;
            }
        }

        private void D9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D9.BackColor = Color.DarkRed;
                D9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D9";
                index++;
            }
        }

        private void D8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D8.BackColor = Color.DarkRed;
                D8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D8";
                index++;
            }
        }

        private void D7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D7.BackColor = Color.DarkRed;
                D7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D7";
                index++;
            }
        }

        private void D6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D6.BackColor = Color.DarkRed;
                D6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D6";
                index++;
            }
        }

        private void D5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D5.BackColor = Color.DarkRed;
                D5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D5";
                index++;
            }
        }

        private void D4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D4.BackColor = Color.DarkRed;
                D4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D4";
                index++;
            }
        }

        private void D3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D3.BackColor = Color.DarkRed;
                D3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D3";
                index++;
            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D2.BackColor = Color.DarkRed;
                D2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D2";
                index++;
            }
        }

        private void D15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D15.BackColor = Color.DarkRed;
                D15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D15";
                index++;
            }
        }

        private void D14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D14.BackColor = Color.DarkRed;
                D14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D14";
                index++;
            }
        }

        private void D13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                D13.BackColor = Color.DarkRed;
                D13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "D13";
                index++;
            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E1.BackColor = Color.DarkRed;
                E1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E1";
                index++;
            }
        }

        private void E12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E12.BackColor = Color.DarkRed;
                E12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E12";
                index++;
            }
        }

        private void E11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E11.BackColor = Color.DarkRed;
                E11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E11";
                index++;
            }
        }

        private void E10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E10.BackColor = Color.DarkRed;
                E10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E10";
                index++;
            }
        }

        private void E15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E15.BackColor = Color.DarkRed;
                E15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E15";
                index++;
            }
        }

        private void E14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E14.BackColor = Color.DarkRed;
                E14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E14";
                index++;
            }
        }

        private void E9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E9.BackColor = Color.DarkRed;
                E9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E9";
                index++;
            }
        }

        private void E8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E8.BackColor = Color.DarkRed;
                E8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E8";
                index++;
            }

        }

        private void E7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E7.BackColor = Color.DarkRed;
                E7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E7";
                index++;
            }
        }

        private void E6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E6.BackColor = Color.DarkRed;
                E6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E6";
                index++;
            }
        }

        private void E5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E5.BackColor = Color.DarkRed;
                E5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E5";
                index++;
            }

        }

        private void E4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E4.BackColor = Color.DarkRed;
                E4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E4";
                index++;
            }
        }

        private void E3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E3.BackColor = Color.DarkRed;
                E3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E3";
                index++;
            }
        }

        private void E2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E2.BackColor = Color.DarkRed;
                E2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E2";
                index++;
            }
        }

        private void E13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                E13.BackColor = Color.DarkRed;
                E13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "E13";
                index++;
            }
        }

        private void F1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F1.BackColor = Color.DarkRed;
                F1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F1";
                index++;
            }
        }

        private void F12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F12.BackColor = Color.DarkRed;
                F12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F12";
                index++;
            }
        }

        private void F11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F11.BackColor = Color.DarkRed;
                F11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F11";
                index++;
            }
        }

        private void F10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F10.BackColor = Color.DarkRed;
                F10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F10";
                index++;
            }
        }

        private void F9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F9.BackColor = Color.DarkRed;
                F9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F9";
                index++;
            }
        }

        private void F8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F8.BackColor = Color.DarkRed;
                F8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F8";
                index++;
            }
        }

        private void F7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F7.BackColor = Color.DarkRed;
                F7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F7";
                index++;
            }
        }

        private void F6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F6.BackColor = Color.DarkRed;
                F6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F6";
                index++;
            }
        }

        private void F5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F5.BackColor = Color.DarkRed;
                F5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F5";
                index++;
            }
        }

        private void F4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F4.BackColor = Color.DarkRed;
                F4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F4";
                index++;
            }
        }

        private void F3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F3.BackColor = Color.DarkRed;
                F3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F3";
                index++;
            }
        }

        private void F2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F2.BackColor = Color.DarkRed;
                F2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F2";
                index++;
            }
        }

        private void F15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F15.BackColor = Color.DarkRed;
                F15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F15";
                index++;
            }
        }

        private void F14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F14.BackColor = Color.DarkRed;
                F14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F14";
                index++;
            }
        }

        private void F13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                F13.BackColor = Color.DarkRed;
                F13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "F13";
                index++;
            }
        }

        private void G1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G1.BackColor = Color.DarkRed;
                G1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G1";
                index++;
            }
        }

        private void G12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G12.BackColor = Color.DarkRed;
                G12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G12";
                index++;
            }
        }

        private void G11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G11.BackColor = Color.DarkRed;
                G11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G11";
                index++;
            }
        }

        private void G10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G10.BackColor = Color.DarkRed;
                G10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G10";
                index++;
            }
        }

        private void G15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G15.BackColor = Color.DarkRed;
                G15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G15";
                index++;
            }
        }

        private void G14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G14.BackColor = Color.DarkRed;
                G14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G14";
                index++;
            }
        }

        private void G9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G9.BackColor = Color.DarkRed;
                G9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G9";
                index++;
            }
        }

        private void G8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G8.BackColor = Color.DarkRed;
                G8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G8";
                index++;
            }
        }

        private void G7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G7.BackColor = Color.DarkRed;
                G7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G7";
                index++;
            }
        }

        private void G6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G6.BackColor = Color.DarkRed;
                G6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G6";
                index++;
            }
        }

        private void G5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G5.BackColor = Color.DarkRed;
                G5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G5";
                index++;
            }
        }

        private void G4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G4.BackColor = Color.DarkRed;
                G4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G4";
                index++;
            }

        }

        private void G3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G3.BackColor = Color.DarkRed;
                G3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G3";
                index++;
            }
        }

        private void G2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G2.BackColor = Color.DarkRed;
                G2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G2";
                index++;
            }
        }

        private void G13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                G13.BackColor = Color.DarkRed;
                G13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "G13";
                index++;
            }
        }

        private void H1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H1.BackColor = Color.DarkRed;
                H1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H1";
                index++;
            }
        }

        private void H12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H12.BackColor = Color.DarkRed;
                H12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H12";
                index++;
            }
        }

        private void H11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H11.BackColor = Color.DarkRed;
                H11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H11";
                index++;
            }
        }

        private void H10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H10.BackColor = Color.DarkRed;
                H10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H10";
                index++;
            }
        }

        private void H9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H9.BackColor = Color.DarkRed;
                H9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H9";
                index++;
            }
        }

        private void H8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H8.BackColor = Color.DarkRed;
                H8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H8";
                index++;
            }
        }

        private void H7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H7.BackColor = Color.DarkRed;
                H7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H7";
                index++;
            }
        }

        private void H6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H6.BackColor = Color.DarkRed;
                H6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H6";
                index++;
            }
        }

        private void H5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H5.BackColor = Color.DarkRed;
                H5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H5";
                index++;
            }
        }

        private void H4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H4.BackColor = Color.DarkRed;
                H4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H4";
                index++;
            }
        }

        private void H3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H3.BackColor = Color.DarkRed;
                H3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H3";
                index++;
            }
        }

        private void H2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H2.BackColor = Color.DarkRed;
                H2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H2";
                index++;
            }
        }

        private void H15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H15.BackColor = Color.DarkRed;
                H15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H15";
                index++;
            }
        }

        private void H14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H14.BackColor = Color.DarkRed;
                H14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H14";
                index++;
            }
        }

        private void H13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                H13.BackColor = Color.DarkRed;
                H13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "H13";
                index++;
            }
        }

        private void J1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J1.BackColor = Color.DarkRed;
                J1.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J1";
                index++;
            }
        }

        private void J12_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J12.BackColor = Color.DarkRed;
                J12.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J12";
                index++;
            }
        }

        private void J11_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J11.BackColor = Color.DarkRed;
                J11.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J11";
                index++;
            }
        }

        private void J10_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J10.BackColor = Color.DarkRed;
                J10.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J10";
                index++;
            }
        }

        private void J15_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J15.BackColor = Color.DarkRed;
                J15.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J15";
                index++;
            }
        }

        private void J14_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J14.BackColor = Color.DarkRed;
                J14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J14";
                index++;
            }
        }

        private void J9_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J9.BackColor = Color.DarkRed;
                J9.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J9";
                index++;
            }
        }

        private void J8_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J8.BackColor = Color.DarkRed;
                J8.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J8";
                index++;
            }
        }

        private void J7_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J7.BackColor = Color.DarkRed;
                J7.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J7";
                index++;
            }
        }

        private void J6_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J6.BackColor = Color.DarkRed;
                J6.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J6";
                index++;
            }
        }

        private void J5_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J5.BackColor = Color.DarkRed;
                J5.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J5";
                index++;
            }
        }

        private void J4_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J4.BackColor = Color.DarkRed;
                J4.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J4";
                index++;
            }
        }

        private void J3_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J3.BackColor = Color.DarkRed;
                J3.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J3";
                index++;
            }
        }

        private void J2_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J2.BackColor = Color.DarkRed;
                J2.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J2";
                index++;
            }
        }

        private void J13_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J13.BackColor = Color.DarkRed;
                J13.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J13";
                index++;
            }
        }

        private void koltuksecimekrani_Load(object sender, EventArgs e)
        {
            PERDE.ForeColor= Color.White;
        }
        private void J14_Click_1(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J14.BackColor = Color.DarkRed;
                J14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J14";
                index++;
            }

        }

        private void J14_Click_2(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            {
                J14.BackColor = Color.DarkRed;
                J14.Enabled = false;
                int a = int.Parse(label9.Text) - 1;
                label9.Text = a.ToString();
                koltuklar[index] = "J14";
                index++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odemeyontemi odemeyontemi = new odemeyontemi();
            foreach (string i in koltuklar)
            {
                if (i != null) odemeyontemi.label7.Text = odemeyontemi.label7.Text + " " + i;
                else break;
            }
            odemeyontemi.label17.Text = label15.Text;
            odemeyontemi.label18.Text = label16.Text;
            odemeyontemi.label9.Text = label13.Text.ToString();
            this.Visible = false;
            odemeyontemi.ShowDialog();
            this.Visible = true;
        }

        private void koltukKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.kapat();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
