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
    public partial class Form10 : Form
    {
        public string v_cikk;
        private System.Windows.Forms.ToolStripTextBox textb = new System.Windows.Forms.ToolStripTextBox();
        private System.Windows.Forms.ToolStripLabel labtxt = new System.Windows.Forms.ToolStripLabel();
        public Form10()
        {
            InitializeComponent();
            this.textb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textb_KeyPress);
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet12.VF_MP630300_OperationMPC' table. You can move, or remove it, as needed.
            this.vF_MP630300_OperationMPCTableAdapter.Fill(this.dataSet12.VF_MP630300_OperationMPC, v_cikk);
           
            this.statusStrip1.Items.Add(this.textb);
            textb.Size = new System.Drawing.Size(100, 5);
            textb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.Add(this.labtxt);
            textb.Text = "0";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, i;
            double osszeg = 0, szam;
             foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                i = sorindex - 1;
                while (i > -1 && cell.RowIndex != sor[i]) i--;
                if (i == -1)
                {
                    if (double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[6].Value.ToString(), out szam))
                    {
                        osszeg += szam;
                        this.toolStripStatusLabel2.Text = osszeg.ToString();
                       
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }

            }
        }

        private void textb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                double menny;

                if (textb.Text == "")
                    menny = 0;
                else
                {
                    menny = Convert.ToDouble(textb.Text.Trim());
                    this.labtxt.Text = (Convert.ToDouble(this.toolStripStatusLabel2.Text) * menny).ToString();
                }
            }
        }


    }
}
