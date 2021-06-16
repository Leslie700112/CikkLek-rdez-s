using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;

namespace CikkLekérdezés
{
    public partial class Form20 : Form
    {
        public string v_cikk;
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            this.ellenorzesekTableAdapter.Fill(this.dataSet20.Ellenorzesek, v_cikk);
            this.cikkAdatokTableAdapter.Fill(this.dataSet201.CikkAdatok, v_cikk);

            DgvFilterManager fm = new DgvFilterManager();
            fm.DataGridView = dataGridView1; // this raises ColumnFilterAdding events
        }
              
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["hidegellenalasDataGridViewTextBoxColumn"].Value.ToString()))
             {
                if (Convert.ToDouble(dataGridView2.Rows[0].Cells["ellenallasMinDataGridViewTextBoxColumn"].Value.ToString()) >
                  Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["hidegellenalasDataGridViewTextBoxColumn"].Value) ||
                  Convert.ToDouble(dataGridView2.Rows[0].Cells["ellenallasMaxDataGridViewTextBoxColumn"].Value.ToString()) <
                   Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["hidegellenalasDataGridViewTextBoxColumn"].Value))
                    this.dataGridView1.Rows[e.RowIndex].Cells["hidegellenalasDataGridViewTextBoxColumn"].Style.BackColor = Color.Coral;
            }
            if (!String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Value.ToString()))
            {
                if (Convert.ToDouble(dataGridView2.Rows[0].Cells["nyomatekMinDataGridViewTextBoxColumn"].Value.ToString()) >
                  Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Value) ||
                  Convert.ToDouble(dataGridView2.Rows[0].Cells["nyomatekMaxDataGridViewTextBoxColumn"].Value.ToString()) <
                   Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Value))
                    this.dataGridView1.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Style.BackColor = Color.Coral;
            }
            if (!String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Value.ToString()))
            {
                if (Convert.ToDouble(dataGridView2.Rows[0].Cells["homokSurusegDataGridViewTextBoxColumn1"].Value.ToString()) >
                  Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Value) ||
                  Convert.ToDouble(dataGridView2.Rows[0].Cells["homokSurusegMaxDataGridViewTextBoxColumn"].Value.ToString()) <
                   Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Value))
                    this.dataGridView1.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Style.BackColor = Color.Coral;
            }
            if (!String.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn"].Value.ToString()))
            {
                if (Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn"].Value) != 1)
                    {
                    if (Convert.ToDouble(dataGridView2.Rows[0].Cells["sulyMinDataGridViewTextBoxColumn"].Value.ToString()) >
                      Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn"].Value) ||
                      Convert.ToDouble(dataGridView2.Rows[0].Cells["sulyMaxDataGridViewTextBoxColumn"].Value.ToString()) <
                       Convert.ToDouble(this.dataGridView1.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn"].Value))
                        this.dataGridView1.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn"].Style.BackColor = Color.Coral;
                }
            }
        }
    }
}
