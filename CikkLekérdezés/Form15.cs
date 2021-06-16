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
    public partial class Form15 : Form
    {
        public string v_cikk;
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
           this.vF_MP64_OR0103_2021_Workorder_SalesTableAdapter.FillBy(this.dataSet14.VF_MP64_OR0103_2021_Workorder_Sales, v_cikk);
        }

       private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form14 Form14 = new Form14();
            Form14.mrendeles = dataGridView1.CurrentRow.Cells["workorderNoDataGridViewTextBoxColumn"].Value.ToString();
            Form14.ShowDialog();
        }
    }
}
