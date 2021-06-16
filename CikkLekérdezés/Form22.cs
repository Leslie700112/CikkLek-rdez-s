using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using DgvFilterPopup;

using System.Windows.Forms;

namespace CikkLekérdezés
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
         public void StartForm()
        {
            //try
            //{
            //    Application.Run(new BetoltesFolyamatban());
            //}
            //catch (Exception ex)
            //{
            //  //    MessageBox.Show(ex.Message);
            //    throw;
            //}
        }

        private void Form22_Shown(object sender, EventArgs e)
        {
            //TimeSpan time = DateTime.Now.TimeOfDay;
            //int jo = 0;
            //for (int i = 0; i < 23; i += 2)
            //{
            //    if (time >= new TimeSpan(i, 23, 00) && time <= new TimeSpan(i, 33, 00))
            //    {
            //        jo = 1;
            //    }
            //}
            //if (jo == 1)
            //{
            //    MessageBox.Show("Virtual KanBan futtatási időszakba esik ! Futtasd később !", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //else
            //{
            //    Thread t = new Thread(new ThreadStart(StartForm));
            //    t.Start();
            //    try
            //    {
            //        this.kanBanQtyTableAdapter.Fill(this.dataSet22.KanBanQty);
            //    }
            //    catch (Exception ex)
            //    {
            //        t.Abort();
            //        MessageBox.Show(ex.Message + " sql query error.");
            //        this.Close();
            //    }
            //    t.Abort(); 
                
            //    DgvFilterManager fm = new DgvFilterManager();
            //    fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);
            //    fm.DataGridView = dataGridView1;
            //}
            
        }
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "termelesrakhelyDataGridViewTextBoxColumn":
                //case "modositasOkaDataGridViewTextBoxColumn":
                //case "polcDataGridViewTextBoxColumn":
                //case "kerelmezoDataGridViewTextBoxColumn":
                    e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            toolStripTextBox1.Select();
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolStripTextBox1.Text.Trim() != "")
            {
                this.kanBanQtyTableAdapter.Fill(this.dataSet22.KanBanQty,toolStripTextBox1.Text.Trim());
                int SorFound =kanBanQtyBindingSource.Find("cikkszam", toolStripTextBox1.Text.Trim());
                if (SorFound < 0)
                {
                    toolStripTextBox1.Clear();
                     toolStripTextBox1.Select();
                }
            }
        }
    }
}
