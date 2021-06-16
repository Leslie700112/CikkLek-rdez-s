using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace CikkLekérdezés
{
    public partial class Form14 : Form
    {
        public string mrendeles="";
        private int MrendFound;
        public delegate void PictureVisibilityDelegate(bool visibility);
        PictureVisibilityDelegate ChangePictureVisibility;

        public Form14()
        {
            InitializeComponent();
           textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
          
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            ChangePictureVisibility = ChangeVisibility;
            label2.Text = "";
            label4.Text = "";
            label11.Text = "";
            label13.Text = "";
            label17.Text = "";
            label6.Text = "";
            label15.Text = "";
            label9.Text = "";
            label55.Text = "";
            label19.Text = "";
            label23.Text = "";
            label29.Text = "";
            label35.Text = "";
            label42.Text = "";
            label24.Text = "";
            label30.Text = "";
            label36.Text = "";
            label44.Text = "";
            label46.Text = "";
            label31.Text = "";
            label32.Text = "";
            label38.Text = "";
            label40.Text = "";
            label49.Text = "";
            label53.Text = "";
            label57.Text = "";
            label59.Text = "";
            label61.Text = "";
            label63.Text = "";
            label65.Text = "";
            label51.Text = "";
            label74.Text = "";
            label72.Text = "";
            label70.Text = "";
            label68.Text = "";
            label66.Text = "";
            pictureBox1.Visible = false;
            if (mrendeles != "")
            {
               textBox1.Text = mrendeles;
               SendKeys.Send("{ENTER}");
            }
            else
            {
                textBox1.Select();
            }
         }    

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form14"].Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.vF_MP64_OR0103_2021_Workorder_SalesTableAdapter.Fill(this.dataSet14.VF_MP64_OR0103_2021_Workorder_Sales,textBox1.Text.Trim());
                this.mrendiJelentettTableAdapter.Fill(this.dataSet14.MrendiJelentett, textBox1.Text.Trim());
                this.jelentettCimkekTableAdapter.Fill(this.dataSet14.JelentettCimkek, textBox1.Text.Trim());
                int RaklapFound =raklapBindingSource.Find("MRendeles", textBox1.Text.Trim());
                this.raklapTableAdapter.Fill(this.dataSet14.Raklap, textBox1.Text.Trim());
                this.selejtTableAdapter.Fill(this.dataSet14.Selejt, textBox1.Text.Trim());
                this.ellenorzesekTableAdapter.Fill(this.dataSet14.Ellenorzesek, textBox1.Text.Trim());
                MrendFound = WorkorderBindingSource1.Find("WorkorderNo", textBox1.Text.Trim());
                dataGridView8.DataSource = null;
                dataGridView8.Refresh();
                if (MrendFound < 0)
                {
                    MessageBox.Show("NINCS ILYEN MUNKARENDELÉS !!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox1.Select();
                }
                else
                {
                    label2.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["WorkorderNo"].ToString().Trim();
                    textBox2.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["StockCode"].ToString().Trim();
                    label4.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Desc1"].ToString().Trim() + " ¤ " +
                        dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Desc2"].ToString().Trim() + " ¤ " +
                        dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Intrem1"].ToString().Trim()+" ¤ "+
                         dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Intrem2"].ToString().Trim();
                    label11.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["CustomerNo"].ToString().Trim();
                    label6.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SalesOrderNo"].ToString().Trim() + " ¤ " +
                        dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SalesOrdLine"].ToString().Trim();
                    label9.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["CustPONo"].ToString().Trim();
                    label55.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["InvoiceNo"].ToString().Trim();
                    if (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["VisszIgHet"].ToString().Trim() != "")
                    {
                        label13.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["VisszIgHet"].ToString().Trim() + " / " +
                             Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["IntrPlanning"]).ToString("yyy.MM.dd").Trim();
                    }
                    if (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Kerthet"].ToString().Trim()!="")
                    { 
                    label15.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Kerthet"].ToString().Trim()+ " / " +
                       Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["DelivDateReq"]).ToString("yyy.MM.dd").Trim();
                    }
                    label17.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Remark1"].ToString().Trim() + " ¤ " +
                    dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ShipmentMark"].ToString().Trim();
                    label19.Text =Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["QtyAlloc"]).ToString("N0").Trim();
                    label23.Text = Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["PlannedQty"]).ToString("N0").Trim();
                    label24.Text = Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ManufactQty"]).ToString("N0").Trim();
                    label29.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Szallhetet"].ToString().Trim() + " / " +
                   Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["PlanDueDate"]).ToString("yyy.MM.dd").Trim();
                    label30.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ElkHet"].ToString().Trim() + " / " +
                        Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Elkeszult"]).ToString("yyy.MM.dd").Trim(); 
                    label31.Text = Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["PickListDate"]).ToString("yyy.MM.dd").Trim();
                    label32.Text = Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["StopDate"]).ToString("yyy.MM.dd").Trim();
                    label35.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Planner"].ToString().Trim()+" / "+
                           dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ResponsChng"].ToString().Trim();
                    label36.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["WorkorderType"].ToString().Trim()+" / "+
                        dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Status1"].ToString().Trim()+" / "+
                        dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ChngVersion"].ToString().Trim();
                    label38.Text = Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["LastChngDate"]).ToString("yyy.MM.dd").Trim();
                    label40.Text = Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["WOCloseDate"]).ToString("yyy.MM.dd").Trim();
                    label42.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Text"].ToString().Trim() + " ¤ " +
                        dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Megjegyz1"].ToString().Trim() + " ¤ " +
                        dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Megjegyz2"].ToString().Trim();
                    if (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ElsoWeek"].ToString().Trim() != "")
                    {
                        label44.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ElsoWeek"].ToString().Trim() + " / " +
                           Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ElsoVisszaIg"]).ToString("yyy.MM.dd").Trim();
                    }
                          dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Megjegyz2"].ToString().Trim();
                          label46.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["REQvsWO"].ToString().Trim();
                          label49.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ZarStatus"].ToString().Trim() + " / " +
                             (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["ZarMegjegyz"]).ToString().Trim();
                          label51.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Munkahely"].ToString().Trim() + " / " +
                                  (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Munkahely2"]).ToString().Trim();
                          if (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Utemezo"].ToString().Trim() != "")
                          {
                              label53.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["Utemezo"].ToString().Trim() + " / " +
                                      Convert.ToDateTime(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["UtemIdo"]).ToString().Trim();
                              label57.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["MeroMuszer"].ToString().Trim();
                              label59.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["EllenallasMin"].ToString().Trim() + " / " +
                                     (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["EllenallasMax"]).ToString().Trim();
                              label61.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["NyomatekMin"].ToString().Trim() + " / " +
                                    (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["NyomatekMax"]).ToString().Trim();
                              label63.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["HomokSuruseg"].ToString().Trim() + " / " +
                                    (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["HomokSurusegMax"]).ToString().Trim();
                              label65.Text = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SulyMin"].ToString().Trim() + " / " +
                                  (dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SulyMax"]).ToString().Trim();
                              label74.Text = label57.Text;
                              label72.Text = label59.Text;
                              label70.Text = label61.Text;
                              label68.Text = label63.Text;
                              label66.Text = label65.Text;
                              tabControl1.Select();
                             
                          }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView1.SelectedCells.Count];
            this.toolStripStatusLabel4.Text = dataGridView1.SelectedCells.Count.ToString();
            int sorindex = 0, a;
            int szam;
            double orm = 0, rm;

            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                a = sorindex - 1;
                while (a > -1 && cell.RowIndex != sor[a]) a--;
                if (a == -1)
                {
                    if (Int32.TryParse(dataGridView1.Rows[cell.RowIndex].Cells[0].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView1.Rows[cell.RowIndex].Cells["mennyisegDataGridViewTextBoxColumn"].Value.ToString(), out rm);
                        orm += rm;
                        this.toolStripStatusLabel2.Text = orm.ToString("N0");
                 }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
            }
        }

        private void dataGridView9_SelectionChanged(object sender, EventArgs e)
        {
            int[] sor = new int[dataGridView9.SelectedCells.Count];
            this.toolStripStatusLabel6.Text = dataGridView9.SelectedCells.Count.ToString();
            int sorindex = 0, a;
            int szam;
            double orm = 0, rm;

            foreach (DataGridViewCell cell in dataGridView9.SelectedCells)
            {
                a = sorindex - 1;
                while (a > -1 && cell.RowIndex != sor[a]) a--;
                if (a == -1)
                {
                    if (Int32.TryParse(dataGridView9.Rows[cell.RowIndex].Cells[0].Value.ToString(), out szam))
                    {
                        double.TryParse(dataGridView9.Rows[cell.RowIndex].Cells["dataGridViewTextBoxColumn51"].Value.ToString(), out rm);
                        orm += rm;
                      this.toolStripStatusLabel8.Text = orm.ToString("N0");
                    }
                    sor[sorindex] = cell.RowIndex;
                    sorindex++;
                }
            }
        }
   
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
     
        private void dataGridView4_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void splitContainer7_Panel1_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void Form14_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.K:
                    tabControl1.SelectedIndex = 0;
                    break;
                case Keys.S:
                    tabControl1.SelectedIndex = 3;
                    break;
                case Keys.E:
                    tabControl1.SelectedIndex = 4;
                    break;
                case Keys.Escape:
                    textBox1.Clear();
                    textBox1.Select();
                    break;
                case Keys.N:
                    tabControl1.SelectedIndex = 5;
                  //  Nyomonkovet();
                    break;
                case Keys.L:
                    tabControl1.SelectedIndex = 1;
                    break;
                case Keys.O:
                    tabControl1.SelectedIndex = 2;
                    break;
            }
        }
        
        private void dataGridView5_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView5.Rows[e.RowIndex].Cells["hidegellenallDataGridViewTextBoxColumn"].Value.ToString().Trim() != "" && this.dataGridView5.Rows[e.RowIndex].Cells["hidegellenallDataGridViewTextBoxColumn"].Value.ToString().Trim() != "OK")
            {
                string elal = dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["EllenallasMin"].ToString().Trim();
                if (Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["hidegellenallDataGridViewTextBoxColumn"].Value.ToString()) >= Convert.ToDecimal(elal = string.IsNullOrEmpty(elal) ? "0": elal)  &&
                Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["hidegellenallDataGridViewTextBoxColumn"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["EllenallasMax"].ToString().Trim()))
                    this.dataGridView5.Rows[e.RowIndex].Cells["hidegellenallDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                else
                    this.dataGridView5.Rows[e.RowIndex].Cells["hidegellenallDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
            }

            if (this.dataGridView5.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Value.ToString().Trim() != "" && this.dataGridView5.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Value.ToString().Trim() != "OK")
            {
                if (Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Value.ToString()) >= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["NyomatekMin"].ToString().Trim()) &&
                      Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["NyomatekMax"].ToString().Trim()))
                    this.dataGridView5.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                else
                    this.dataGridView5.Rows[e.RowIndex].Cells["lazitasiNyomDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
            }

            if (this.dataGridView5.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Value.ToString().Trim() != "" && this.dataGridView5.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Value.ToString().Trim() != "OK")
            {
                if (Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Value.ToString()) >= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["HomokSuruseg"].ToString().Trim()) &&
                           Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["HomokSurusegMax"].ToString().Trim()))
                    this.dataGridView5.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                else
                    this.dataGridView5.Rows[e.RowIndex].Cells["homokSurusegDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
            }

            if (this.dataGridView5.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn1"].Value.ToString().Trim() != "" && this.dataGridView5.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn1"].Value.ToString().Trim() != "OK")
            {
                if (Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn1"].Value.ToString()) >= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SulyMin"].ToString().Trim()) &&
                           Convert.ToDecimal(this.dataGridView5.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn1"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SulyMax"].ToString().Trim()))
                    this.dataGridView5.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn1"].Style.BackColor = Color.White;
                else
                    this.dataGridView5.Rows[e.RowIndex].Cells["sulyDataGridViewTextBoxColumn1"].Style.BackColor = Color.Red;
            }
        }

        private void dataGridView7_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn45"].Value.ToString().Trim() != "" && this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn45"].Value.ToString().Trim() != "OK")
            {
                if (Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn45"].Value.ToString()) >= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["EllenallasMin"].ToString().Trim()) &&
                   Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn45"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["EllenallasMax"].ToString().Trim()))
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn45"].Style.BackColor = Color.White;
                else
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn45"].Style.BackColor = Color.Red;
            }

            if (this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn46"].Value.ToString().Trim() != "" && this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn46"].Value.ToString().Trim() != "OK")
            {
                if (Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn46"].Value.ToString()) >= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["NyomatekMin"].ToString().Trim()) &&
                      Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn46"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["NyomatekMax"].ToString().Trim()))
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn46"].Style.BackColor = Color.White;
                else
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn46"].Style.BackColor = Color.Red;
            }

            if (this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn47"].Value.ToString().Trim() != "" && this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn47"].Value.ToString().Trim() != "OK")
            {
                if (Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn47"].Value.ToString()) >= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["HomokSuruseg"].ToString().Trim()) &&
                           Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn47"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["HomokSurusegMax"].ToString().Trim()))
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn47"].Style.BackColor = Color.White;
                else
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn47"].Style.BackColor = Color.Red;
            }

            if (this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn48"].Value.ToString().Trim() != "" && this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn48"].Value.ToString().Trim() != "OK")
            {
                if (Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn48"].Value.ToString()) >= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SulyMin"].ToString().Trim()) &&
                           Convert.ToDecimal(this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn48"].Value.ToString()) <= Convert.ToDecimal(dataSet14.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[MrendFound]["SulyMax"].ToString().Trim()))
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn48"].Style.BackColor = Color.White;
                else
                    this.dataGridView7.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn48"].Style.BackColor = Color.Red;
            }
        }
  
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 5)//your specific tabname
            {
              //  Nyomonkovet();
            }
        }
   
        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;

            try
            {

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Munka1"];
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Nyomonkövetés";

                for (int i = 1; i < dataGridView8.Columns.Count ; i++)
                {
                   worksheet.Cells[1, i] = dataGridView8.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView8.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView8.Columns.Count - 1; j++)
                    {
                        if (j >=0 && j<=6)
                        {
                            worksheet.Cells[i + 2, j+1 ].NumberFormat = "@";
                            worksheet.Cells[i + 2, j + 1] = dataGridView8.Rows[i].Cells[j].Value.ToString();
                        }
                        if (j ==7)
                        {
                         worksheet.Cells[i + 2, j + 1] = Convert.ToDecimal(dataGridView8.Rows[i].Cells[j].Value.ToString());
                       }
                     if (j>7)
                     {
                         worksheet.Cells[i + 2, j + 1].NumberFormat = "@";
                         worksheet.Cells[i + 2, j + 1] = dataGridView8.Rows[i].Cells[j].Value.ToString();
                     }
                    
                    }
                }
                string fileName = String.Empty;
                saveFileExcel.Filter = "Excel files |*.xls|All files (*.*)|*.*";
                saveFileExcel.FilterIndex = 2;
                saveFileExcel.RestoreDirectory = true;

                if (saveFileExcel.ShowDialog() == DialogResult.OK)
                {
                    fileName = saveFileExcel.FileName;
                    workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                else
                    return;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //  app.Quit();
                workbook = null;
                app = null;
            }
        
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(backgroundWorker1.IsBusy == true))
            this.backgroundWorker1.RunWorkerAsync();
           
        }
 
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(ChangePictureVisibility, true);

            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=ScaCompDB;Integrated Security=True;Connect Timeout=0");
            SqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandTimeout = 0;
            mySqlCommand.CommandText = "if object_id('ScaCompDB..Nyomonkovet') is not null " +
 " drop table Nyomonkovet " +
" CREATE TABLE Nyomonkovet(MRParent char(10),MRChild char(10),Tipus char(2),Ido datetime,Cikk char(35),Menny numeric(20,4),OBatch char(20),PBatch char(20),CBatch char(20),Ref char(20),FBatch char(20),ElerUt char(255));" +
" WITH Stuky(SC07007,Expr1,SC07001,SC07002,SC07003,SC07004,SC07029,SC07030,SC07031,SC07006,SC07021,ElerUt) AS " +
" (SELECT SC07007,Expr1,SC07001,SC07002,SC07003,SC07004,SC07029,SC07030,SC07031,SC07006,SC07021,CAST('\'+rtrim(SC07003) as nvarchar(255)) " +
    " FROM  VF_SC070300_StockTransact_Nyomonkovet" +
" where SC07007='"+textBox1.Text.Trim()+"' " +
        " UNION ALL " +
    " SELECT e.SC07007,e.Expr1,e.SC07001,e.SC07002,e.SC07003,e.SC07004,e.SC07029,e.SC07030,e.SC07031,e.SC07006,e.SC07021,CAST(ElerUt+'\'+rtrim(e.SC07003) as nvarchar(255))" +
        " FROM  VF_SC070300_StockTransact_Nyomonkovet AS e " +
        " Inner JOIN Stuky AS d " +
        " ON e.SC07007 = d.Expr1 " +
        " where d.Expr1<>'' and not e.SC07006 like 'INT%' and not d.SC07003 like '00%') " +
" insert Nyomonkovet SELECT SC07007,Expr1,SC07001,SC07002,SC07003,SC07004,SC07029,SC07030,SC07031,SC07006,SC07021,ElerUt " +
" FROM Stuky " +
" GO " +
" ;with masod as (select case when a.MRChild='' and Ny.MRParent<>'' then Ny.MRChild else a.MRParent end as Parent, max(a.MRParent) as AMRParent,max(a.Tipus) as Tipus,max(a.Ido) as Ido,a.Cikk,(a.Menny) as Menny, " +
               " a.OBatch,a.PBatch,a.CBatch,a.MRChild as AMRChild,a.Ref, Ny.MRParent as NYMRParent,Ny.MRChild as NYMRChild,a.FBatch as AFBatch,Ny.FBatch as NYFBatch,max(a.ElerUt) as ElerUt " +
      " from Nyomonkovet as a left outer join Nyomonkovet as Ny on a.MRParent=Ny.MRChild " +
        " where a.Tipus='01' or (a.Tipus='00' and a.OBatch=ISNULL(Ny.OBatch,a.OBatch)) " +
        " group by  case when a.MRChild='' and Ny.MRParent<>'' then Ny.MRChild else a.MRParent end,a.Cikk,a.Menny,a.OBatch,a.PBatch,a.CBatch,a.MRChild,a.Ref, Ny.MRParent,Ny.MRChild,a.FBatch,Ny.FBatch) " +
        " select Parent as Munka_Beszerzési_Rend , max(Tipus)as Típus,max(Ido) as Tranz_Idő,rtrim(Cikk) as Cikkszám,max(SC01.Description1) as Megnevezés,max(SC01.Description2) as Megnevezés_,max(SC01.InternRem1) as Rajzszám,sum(Menny) as Mennyiség," +
        " substring(max(SCU.Description),3,3) as Mért_egys, rtrim(max(Ref)) as Szállítókód, isnull(max(PL01.SupplierName),'') as Szállító,rtrim(OBatch) as Batch_1,rtrim(max(PBatch)) as Batch_2,rtrim(max(CBatch)) as Batch_3,max(ElerUt) as ElerUt " +
        " from masod left outer join " +
        " VF_SC010300_Stockfile as SC01 on Cikk=SC01.StockCode left outer join " +
        " VF_SCUN0300_UnitCode as SCU on SC01.UnitCodeMPC=SCU.UnitCode left outer join " +
        " VF_PL010300_SupplierFile as PL01 on Ref=PL01.SupplierCode " +
        " group by Cikk,Parent,OBatch " +
        " order by ElerUt ";
            DataTable table = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(mySqlCommand.CommandText, connection);
            Da.SelectCommand.CommandTimeout = 0;
            DataSet Ds = new DataSet();
            connection.Open();
            Da.Fill(table);
            connection.Close();
            setDataSource(table);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke(ChangePictureVisibility, false);
        }

        public void ChangeVisibility(bool visibility)
        {
            pictureBox1.Visible = visibility;
        }

        internal delegate void SetDataSourceDelegate(DataTable table);
     
        private void setDataSource(DataTable table)
        {
            // Invoke method if required:
            if (this.InvokeRequired)
            {
                this.Invoke(new SetDataSourceDelegate(setDataSource), table);
            }
            else
            {
                dataGridView8.DataSource = table;
              //     dataGridView8.DataMember = "Nyomon";
                 dataGridView8.Columns[0].HeaderText = "Munka/Beszerzési Rendelés";
                 dataGridView8.Columns[2].HeaderText = "Tran. Idő";
                 dataGridView8.Columns[8].HeaderText = "Mért. Egys.";
                 dataGridView8.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                 dataGridView8.Columns[0].Width = 120;
                 dataGridView8.Columns[1].Width = 60;
                 dataGridView8.Columns[3].Width = 150;
                 dataGridView8.Columns[4].Width = 200;
                 dataGridView8.Columns[5].Width = 200;
                 dataGridView8.Columns[6].Width = 150;
                 dataGridView8.Columns[8].Width = 60;
                 dataGridView8.Columns[9].Width = 80;
                 dataGridView8.Columns[10].Width = 200;
                 dataGridView8.Columns[14].Visible = false;
                 dataGridView8.ReadOnly = true;
           }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.vF_MP64_OR0103_2021_Workorder_SalesTableAdapter.Fill(this.dataSet14.VF_MP64_OR0103_2021_Workorder_Sales, textBox1.Text.Trim());
            this.mrendiJelentettTableAdapter.Fill(this.dataSet14.MrendiJelentett, textBox1.Text.Trim());
            this.jelentettCimkekTableAdapter.Fill(this.dataSet14.JelentettCimkek, textBox1.Text.Trim());
            int RaklapFound = raklapBindingSource.Find("MRendeles", textBox1.Text.Trim());
            this.raklapTableAdapter.Fill(this.dataSet14.Raklap, textBox1.Text.Trim());
            this.selejtTableAdapter.Fill(this.dataSet14.Selejt, textBox1.Text.Trim());
            this.ellenorzesekTableAdapter.Fill(this.dataSet14.Ellenorzesek, textBox1.Text.Trim());
        }

     

    

       
     
        
        }
}
