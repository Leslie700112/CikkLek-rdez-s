using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CikkLekérdezés
{
    public partial class Form2 : Form
    {
        public string v_cikk;
        public Form2()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form2_KeyDown);
                     
         }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            dataGridView1.Visible = false;
            // TODO: This line of code loads data into the 'scaCompDBDataSet1.VF_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vF_SC010300_StockfileTableAdapter.Fill(scaCompDBDataSet1.VF_SC010300_Stockfile, v_cikk);
            label2.Text = v_cikk;
            if (v_cikk.Substring(0, 2) == "00")
            {
              if (File.Exists(@"\\fs\termeles\TermelesMomitor\Festés\" + v_cikk.Trim() + ".jpg"))
              {
                pictureBox1.Image = Image.FromFile(@"\\fs\termeles\TermelesMomitor\Festés\" + v_cikk.Trim() + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
              }
              else
              {
                pictureBox1.Image = Image.FromFile(@"\\fs\termeles\TermelesMomitor\Festés\nincs_festes.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
              }
             if (File.Exists(@"\\fs\termeles\TermelesMomitor\Cimke\" + v_cikk.Trim() + ".jpg"))
              {
                pictureBox2.Image = Image.FromFile(@"\\fs\termeles\TermelesMomitor\Cimke\" + v_cikk.Trim() + ".jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
              }
             else
              {
                pictureBox2.Image = Image.FromFile(@"\\fs\termeles\TermelesMomitor\Cimke\nincs_cimke.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
              }
            }
            if (v_cikk.Substring(0, 2) == "02")
            {
                if (File.Exists(@"\\fs\Rajzdok\_Sajtolos_MR_rajzok\" + v_cikk.Trim() + ".jpg"))
                {
                    pictureBox1.Image = Image.FromFile(@"\\fs\Rajzdok\_Sajtolos_MR_rajzok\" + v_cikk.Trim() + ".jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"\\fs\termeles\TermelesMomitor\Festés\nincs_festes.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }

            }
    
        private void Form2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.vF_SC030300_StockW_AverCostPRCTableAdapter.Fill(scaCompDBDataSet1.VF_SC030300_StockW_AverCostPRC, v_cikk);
            if (dataGridView1.Visible == false)
                dataGridView1.Visible = true;
            else
                dataGridView1.Visible = false;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(@"\\fs\Rajzdok\_Sajtolos_MR_rajzok\" + v_cikk.Trim() + ".jpg"))
            {
                Form18 Form18 = new Form18();
                Form18.v_cikk = v_cikk;
                Form18.megn = label4.Text.Trim()+" ¤ "+label5.Text.Trim()+" ¤ " + label6.Text.Trim()+" ¤ " + label7.Text.Trim();
                Form18.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible == false)
            {
                listBox1.Visible = true;
                DirectoryInfo dinfo = new DirectoryInfo(@"\\fs\munkakonyvtarak\OP\PRODUCTION\_Termelés\Biztonsági adatlapok\Adatlapok");
                FileInfo[] Files = dinfo.GetFiles(v_cikk + "*.pdf");
                foreach (FileInfo file in Files)
                {
                    listBox1.Items.Add(file.Name);
                }
            }
            else
                listBox1.Visible = false;
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = listBox1.IndexFromPoint(e.X, e.Y);
            if (listBox1.Items.Count != 0 && x >= 0)
            {

                System.Diagnostics.Process.Start(@"\\fs\munkakonyvtarak\OP\PRODUCTION\_Termelés\Biztonsági adatlapok\Adatlapok\" + listBox1.Items[x].ToString().Trim());
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listBox1.Items.Count != 0)
                    System.Diagnostics.Process.Start(@"\\fs\munkakonyvtarak\OP\PRODUCTION\_Termelés\Biztonsági adatlapok\Adatlapok\" + listBox1.SelectedItem.ToString().Trim());
            }
        }
    }
}
