using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CikkLekérdezés
{
    public partial class Form11 : Form
    {
                
        public Form11()
        {
            InitializeComponent();
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(dataGridview1_KeyDown);
            this.dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Form11_KeyDown);
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }
  
        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet12.VF_MP64_OR0103_2021_Workorder_Sales' table. You can move, or remove it, as needed.
          
            this.vF_MP64_OR0103_2021_Workorder_SalesTableAdapter.Fill(this.dataSet12.VF_MP64_OR0103_2021_Workorder_Sales);
            this.dataGridView1.Columns[2].Frozen = true;
            textBox1.Select();
        }
   
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string wkeres = " ";

            string seekValue = this.textBox1.Text;
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                 vFMP64OR01032021WorkorderSalesBindingSource.Filter = "Kereso like '%" + seekValue.Trim() + "%'";
                }
                else
                {
                    try
                    {
                     vFMP64OR01032021WorkorderSalesBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int fogl;
            if (this.dataGridView1.Rows[e.RowIndex].Cells["Status1"].Value.ToString() == "8")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Coral;
            if ((this.dataGridView1.Rows[e.RowIndex].Cells["Status1"].Value.ToString() != "8" && this.dataGridView1.Rows[e.RowIndex].Cells["Type"].Value.ToString() == "2") || this.dataGridView1.Rows[e.RowIndex].Cells["Status1"].Value.ToString() == "2")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.CadetBlue;
            if (this.dataGridView1.Rows[e.RowIndex].Cells["Status1"].Value.ToString() != "8" && this.dataGridView1.Rows[e.RowIndex].Cells["StopDate"].Value.ToString().Substring(0, 4) != "1900") 
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            if (this.dataGridView1.Rows[e.RowIndex].Cells["QtyAlloc"].Value == null || this.dataGridView1.Rows[e.RowIndex].Cells["QtyAlloc"].Value.ToString()=="")
                fogl = 0;
            else
                fogl = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells["QtyAlloc"].Value);
            if (this.dataGridView1.Rows[e.RowIndex].Cells["Status1"].Value.ToString() != "8" && fogl != 0 && this.dataGridView1.Rows[e.RowIndex].Cells["StopDate"].Value.ToString().Substring(0, 4) == "1900")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightSkyBlue;
        }
        
        
        private void dataGridview1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }
        private void Form11_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet12.VF_MP64_OR0103_2021_Workorder_Sales.Clear();
            this.vF_MP64_OR0103_2021_Workorder_SalesTableAdapter.Fill(this.dataSet12.VF_MP64_OR0103_2021_Workorder_Sales);
        }
        
    }
}
