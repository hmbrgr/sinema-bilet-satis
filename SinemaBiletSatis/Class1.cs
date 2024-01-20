using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletSatis
{
    public class Class1
    {
        public void kapat()
        {
            DialogResult a = MessageBox.Show("Çıkmak İstiyor Musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes) Application.Exit();
        }
    }
}
