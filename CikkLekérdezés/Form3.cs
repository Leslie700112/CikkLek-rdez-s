using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CikkLekérdezés
{
    public partial class Form3 : Form
    {
        public string v_cikk,v_mertegys,v_megn1,v_megn2,v_megn3;
        public Form3()
        {
            InitializeComponent();
            dataGridView1.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
         }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.VF_SC030300_StockWarehouse' table. You can move, or remove it, as needed.
            this.vF_SC030300_StockWarehouseTableAdapter.Fill(this.dataSet2.VF_SC030300_StockWarehouse,v_cikk);
            this.vF_SC030300_StockWarehouseTableAdapter1.Fill(this.dataSet3.VF_SC030300_StockWarehouse, v_cikk);
            this.vF_SC330300_StockBatchTableAdapter.Fill(this.dataSet4.VF_SC330300_StockBatch, v_cikk,"%%");
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string v_raktar = dataGridView1.CurrentRow.Cells[0].Value.ToString() + "%";
            this.vF_SC330300_StockBatchTableAdapter.Fill(this.dataSet4.VF_SC330300_StockBatch, v_cikk,v_raktar);
        }
       
        private void dataGridView1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
         switch ((int)e.KeyChar)
            {
                case (int)Keys.Space:
                    string v_raktar = dataGridView1.CurrentRow.Cells[0].Value.ToString() + "%";
                    this.vF_SC330300_StockBatchTableAdapter.Fill(this.dataSet4.VF_SC330300_StockBatch, v_cikk, v_raktar);
                    break;
             case (int)Keys.Escape :
                    this.Close();
                    break;
         }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView3.SelectedCells.Count];
            this.toolStripStatusLabel2.Text = dataGridView3.SelectedCells.Count.ToString();
            int sorindex = 0, a;
            int szam;
            double orm = 0, rm;
            
            foreach (DataGridViewCell cell in dataGridView3.SelectedCells)
            {
                a = sorindex - 1;
                while (a > -1 && cell.RowIndex != sor[a]) a--;
                if (a == -1)
                {
                    if (Int32.TryParse(dataGridView3.Rows[cell.RowIndex].Cells[1].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView3.Rows[cell.RowIndex].Cells["balanceQtyDataGridViewTextBoxColumn"].Value.ToString(), out rm);
                                            
                        orm += rm;
                       
                        this.toolStripStatusLabel3.Text = orm.ToString("N4");
                      

                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
            }
        }

        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView3.Rows[e.RowIndex].Cells["ExpireDate"].Value.ToString().Substring(0,10) != "9999.12.31")
                this.dataGridView3.Rows[e.RowIndex].Cells["ExpireDate"].Style.BackColor = Color.Crimson;
           
        }
   
    }
}
