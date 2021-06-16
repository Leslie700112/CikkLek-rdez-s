using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DgvFilterPopup;

namespace CikkLekérdezés
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet8.VF_SC070300_DeliveryNotes' table. You can move, or remove it, as needed.
             this.vF_SC070300_DeliveryNotesTableAdapter.Fill(this.dataSet8.VF_SC070300_DeliveryNotes);
         
            DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

             fm.DataGridView = dataGridView1; // this raises ColumnFilterAdding events
             fm["qtyDataGridViewTextBoxColumn"] = new DgvNumRangeColumnFilter();
             fm["transactDate1DataGridViewTextBoxColumn"] = new DgvNumRangeColumnFilter();
             textBox1.Select();
        }
      
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
               case "SupplierName":
               case "referenceDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }   
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.vF_SC070300_DeliveryNotesTableAdapter.Fill(this.dataSet8.VF_SC070300_DeliveryNotes);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string wkeres = " ";

            string seekValue = this.textBox1.Text;
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                vFSC070300DeliveryNotesBindingSource.Filter = "Kereso like '%" + seekValue.Trim() + "%'";
                }
                else
                {
                    try
                    {
                       vFSC070300DeliveryNotesBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form13"].Close();
        }

      
    }
}
