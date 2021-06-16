using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CikkLekérdezés
{
    public partial class Loading : Form
     {
        public int alpha = 0;
        public Loading()
        {
            
            InitializeComponent();
         //   int szelesseg = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
         //   int magassag = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
         //   pictureBox1.Location = new System.Drawing.Point(szelesseg / 2 - pictureBox1.Width / 2, ((magassag * 3)/4) - pictureBox1.Height / 2);
        }
            

     }
}
