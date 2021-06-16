using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;
using System.Threading;
namespace CikkLekérdezés
{
    public partial class Form16 : Form
    {
        public string v_cikk;
        public Form16()
        {
           InitializeComponent();
        }
     
        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet15.Raklap_MRendelesek_Jelent' table. You can move, or remove it, as needed.
            //   this.raklap_MRendelesek_JelentTableAdapter.Fill(this.dataSet15.Raklap_MRendelesek_Jelent);

            this.raklap_MRendelesek_JelentTableAdapter.Fill(this.dataSet15.Raklap_MRendelesek_Jelent, v_cikk);

            this.dataGridView1.Columns[1].Frozen = true;

            DgvFilterManager Rfm = new DgvFilterManager();
            Rfm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAddingR);
            Rfm.DataGridView = dataGridView1;
            // this raises ColumnFilterAdding events
            //  fm["Gyujto"] = new DgvNumRangeColumnFilter();
        }
    
        void fm_ColumnFilterAddingR(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "Status":
                case "RaklapFajta":
                case "Munkahely":
                case "CustCodeInv":
                case "csomFajtaDataGridViewTextBoxColumn":
                e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }   
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           this.raklap_MRendelesek_JelentTableAdapter.Fill(this.dataSet15.Raklap_MRendelesek_Jelent, v_cikk);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form16"].Close();
        }

       
    }
}
