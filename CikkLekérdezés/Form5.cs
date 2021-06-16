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
    public partial class Form5 : Form
    {
        public string v_cikk, v_mertegys, v_megn1, v_megn2, v_megn3;
        public double okeszl;
        public Form5()
        {
            InitializeComponent();
           this.dataGridView1.SelectionChanged += new System.EventHandler(dataGridView1_SelectionChanged);
           this.dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
           this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(dataGridview1_KeyDown);
         }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet6.VF_SC030300_StockW_Group_StockCode' table. You can move, or remove it, as needed.
            this.vF_SC030300_StockW_Group_StockCodeTableAdapter.Fill(this.dataSet6.VF_SC030300_StockW_Group_StockCode,v_cikk);
          this.vF_SC110300_StockPlanningTableAdapter.Fill(this.dataSet6.VF_SC110300_StockPlanning, v_cikk);
          this.dataGridView1.Columns[5].Frozen = true;
          this.toolStripStatusLabel1.Text = "0";
          this.toolStripStatusLabel3.Text = "0";
          this.toolStripStatusLabel7.Text = "0";
         int cikkFound =bindingSourceSC03.Find("StockCode", v_cikk);
         if (cikkFound < 0)
         {
             this.toolStripStatusLabel9.Text = "0";
             okeszl = 0;
         }
         else
         {
             this.toolStripStatusLabel9.Text = dataSet6.Tables["VF_SC030300_StockW_Group_StockCode"].Rows[0]["StockBalance"].ToString().Trim();
             okeszl = Convert.ToDouble(dataSet6.Tables["VF_SC030300_StockW_Group_StockCode"].Rows[0]["StockBalance"]);
         }
         this.toolStripStatusLabel11.Text = "0";
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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, i;
            okeszl = Convert.ToDouble(dataSet6.Tables["VF_SC030300_StockW_Group_StockCode"].Rows[0]["StockBalance"]);
            double osszeg = 0, szam;
            double orm=0, rm;
            double ogym=0, gym;
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                i = sorindex - 1;
                while (i > -1 && cell.RowIndex != sor[i]) i--;
                if (i == -1)
                {
                    if (double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[2].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[9].Value.ToString(), out rm);
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[10].Value.ToString(), out gym);
                        osszeg += szam;
                        orm += rm;
                        ogym += gym;

                        okeszl +=szam;
                        this.toolStripStatusLabel1.Text = osszeg.ToString();
                        this.toolStripStatusLabel3.Text = orm.ToString();
                        this.toolStripStatusLabel7.Text = ogym.ToString();
                        this.toolStripStatusLabel11.Text = okeszl.ToString();
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }

            }
        
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           if (this.dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString() == "0")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Coral;
         }
        private void dataGridview1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }  

    }
}
