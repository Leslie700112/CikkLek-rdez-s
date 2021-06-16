using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CikkLekérdezés
{
    
    public partial class Form18 : Form
    {
        public string v_cikk,megn;
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            this.Text = "Rajz :" + v_cikk.Trim()+" ¤ "+ megn;
            //  if (File.Exists(@"\\fs\Rajzdok\_Sajtolos_MR_rajzok\" + v_cikk.Trim() + ".jpg"))
            {
                  pictureBox1.Image = Image.FromFile(@"\\fs\Rajzdok\_Sajtolos_MR_rajzok\" + v_cikk.Trim() + ".jpg");
                  pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
