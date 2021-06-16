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
    public partial class Form4 : Form
    {
        public string v_cikk,v_mertegys, v_megn1, v_megn2, v_megn3;
        public Form4()
        {
            InitializeComponent();
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(dataGridview1_KeyDown);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet5.VF_ST080300_PurchaseStat' table. You can move, or remove it, as needed.
            this.vF_ST080300_PurchaseStatTableAdapter.Fill(this.dataSet5.VF_ST080300_PurchaseStat,v_cikk);
            if (v_megn1 != null)
            {
                textBox1.Text = v_cikk;
                textBox2.Text = v_megn1;
                textBox3.Text = v_megn2;
                textBox4.Text = v_megn3;
                textBox5.Text = v_mertegys;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                toolStrip1.Visible = false;
            }
        }
        private void dataGridview1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }  
    }
}
