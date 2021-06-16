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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet21.KeszletModKerelmek' table. You can move, or remove it, as needed.
            this.keszletModKerelmekTableAdapter.Fill(this.dataSet21.KeszletModKerelmek);
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            fm.DataGridView = dataGridView1;

        }

        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "raktarDataGridViewTextBoxColumn":
                case "modositasOkaDataGridViewTextBoxColumn":
                case "polcDataGridViewTextBoxColumn":
                case "kerelmezoDataGridViewTextBoxColumn":
                case "MP57024":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["statuszDataGridViewTextBoxColumn"].Value.ToString() != "9")
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
            else
                this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            int sorindex = 0, a;
            int szam;
            double orm = 0, rm;

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                a = sorindex - 1;
                while (a > -1 && cell.RowIndex != sor[a]) a--;
                if (a == -1)
                {
                    if (Int32.TryParse(dataGridView1.Rows[cell.RowIndex].Cells["iDDataGridViewTextBoxColumn"].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells["menyyisegDataGridViewTextBoxColumn"].Value.ToString(), out rm);
                        orm += rm;
                        this.toolStripStatusLabel4.Text = orm.ToString("N2");
                        this.toolStripStatusLabel2.Text = dataGridView1.SelectedCells.Count.ToString();
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
            }
        }
    }
}
