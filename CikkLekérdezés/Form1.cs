using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DgvFilterPopup;


namespace CikkLekérdezés
{
    public partial class Form1 : Form
    {
        public string v_cikk,a_cikk;
        public string v_report;
        public string v_mertegys,UserName;
        public DateTime LogTime;
        
        public Form1()
        {
            InitializeComponent();
           // this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new KeyEventHandler(dataGridView1_KeyDown);
            this.dataGridView2.KeyDown += new KeyEventHandler(dataGridView2_KeyDown);
            this.KeyDown += new KeyEventHandler(splitContainer1_KeyDown);
            this.KeyPreview = false;
         }

        private void Form1_Load(object sender, EventArgs e)
        {
          dataSet7.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSet7.CrystalNyilv' table. You can move, or remove it, as needed.
            this.crystalNyilvTableAdapter.Fill(this.dataSet7.CrystalNyilv);
           // TODO: This line of code loads data into the 'scaCompDBDataSet.VF_SC010300_Stockfile' table. You can move, or remove it, as needed.
            this.vF_SC010300_StockfileTableAdapter.Fill(this.scaCompDBDataSet.VF_SC010300_Stockfile);

            this.dataGridView1.Columns[1].Frozen = true;
            treeView1.ExpandAll();
              DgvFilterManager fm = new DgvFilterManager();
            fm.ColumnFilterAdding += new ColumnFilterEventHandler(fm_ColumnFilterAdding);

             fm.DataGridView = dataGridView1; // this raises ColumnFilterAdding events
             fm["stockBalanceDataGridViewTextBoxColumn"] = new DgvNumRangeColumnFilter();
                                
            keresmezo();
           }
   
        void fm_ColumnFilterAdding(object sender, ColumnFilterEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "TextDescription":
                case "Purchaser":
                case "AlternSuppl":
                case "StatCodeExte":
                case "ExtProGroup":
                case "Port":
                     e.ColumnFilter = new DgvComboBoxColumnFilter();
                    break;
            }
        }   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        string wkeres = " ";

            string seekValue = this.textBox1.Text.Trim();
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                   vFSC010300StockfileBindingSource.Filter = "Kereso like '%" + seekValue + "%'";
                }
                else
                {
                    try
                    {
                      vFSC010300StockfileBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes["Készletek(L)"];
            alapinformaciok();
        }
  
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            treeView1.SelectedNode = treeView1.Nodes["Készletek(L)"];
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                alapinformaciok();
            }
        }
        private void alapinformaciok()
        {
            if (dataGridView1.RowCount > 0)
            {
                v_cikk = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = v_cikk;
                int SorFound = vFSC010300StockfileBindingSource.Find("StockCode", v_cikk.Trim());
                textBox2.Text = dataGridView1.Rows[SorFound].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[SorFound].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[SorFound].Cells[3].Value.ToString();
                textBox1.ReadOnly = true;
                toolStripButton1.Visible = false;
                this.KeyPreview = true;
                v_mertegys = dataGridView1.Rows[SorFound].Cells[20].Value.ToString();
                textBox5.Text = v_mertegys;
                Form3 Form3 = new Form3();
                Form3.v_cikk = v_cikk;
                ShowForm(Form3);
            }
            else
            {
                textBox1.Clear();
                textBox1.Select();
            }
        }

        public void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
                {
                    case "Cikkek Lekérdezése(ESC)":
                        v_cikk = "";
                        this.KeyPreview = false;
                        this.splitContainer1.Panel1.Controls.Clear();
                        this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
                        keresmezo();
                        break;
                    case "Alap Információk(A)":
                        Form2 Form2 = new Form2();
                        Form2.v_cikk = v_cikk;
                        ShowForm(Form2);
                        break;
                    case "Készletek(L)":
                         Form3 Form3 = new Form3();
                        Form3.v_cikk = v_cikk;
                        ShowForm(Form3);
                        break;
                    case "Beérkezések(B)":
                        Form4 Form4 = new Form4();
                        Form4.v_cikk = v_cikk;
                        ShowForm(Form4);
                        break;
                    case "Várható beérk./ kiszáll.(K)":
                        Form5 Form5 = new Form5();
                        Form5.v_cikk = v_cikk;
                        ShowForm(Form5);
                        break;
                    case "KészletTranzakciók(T)":
                         Form7 Form7 = new Form7();
                        Form7.v_cikk = v_cikk;
                        Form7.v_mertegys = v_mertegys;
                        ShowForm(Form7);
                        break;
                    case "Anyagjegyzék(M)":
                        Form8 Form8 = new Form8();
                        Form8.v_cikk = v_cikk;
                        ShowForm(Form8);
                        break;
                    case "Hol Használják(H)":
                        Form9 Form9 = new Form9();
                        Form9.v_cikk = v_cikk;
                       ShowForm(Form9);
                        break;
                    case "Munkafolyamatok(F)":
                        Form10 Form10 = new Form10();
                        Form10.v_cikk = v_cikk;
                        ShowForm(Form10);
                        break;
                    case "Kalkuláció(C)":
                        Form17 Form17 = new Form17();
                        Form17.v_cikk = v_cikk;
                        ShowForm(Form17);
                        break;
                    case "Cikk Munkarendelései(W)":
                        Form15 Form15 = new Form15();
                        Form15.v_cikk = v_cikk;
                        ShowForm(Form15);
                        break;
                    case "Számlák(I)":
                        Form19 Form19 = new Form19();
                        Form19.v_cikk = v_cikk;
                        ShowForm(Form19);
                        break;
                case "Munkarendelés":
                        Form14 Form14 = new Form14();
                        Form14.ShowDialog();
                        treeView1.SelectedNode = null;
                        break;
                      case "Munkarendelések":
                       Form11 Form11 = new Form11();
                       Form11.ShowDialog();
                       treeView1.SelectedNode = null;
                      // textBox1.Select();
                       break;
                      case "Szállítólevelek":
                       Form13 Form13 = new Form13();
                       Form13.ShowDialog();
                       treeView1.SelectedNode = null;
                       break;
                     case "Ellenőrzések(E)":
                       Form20 Form20 = new Form20();
                       Form20.v_cikk = v_cikk;
                       ShowForm(Form20);
                      break;
                    case "Kimenő Szállítmányok(S)":
                       Form16 Form16 = new Form16();
                       Form16.v_cikk = v_cikk;
                       ShowForm(Form16);
                  //  treeView1.SelectedNode = null;
                    break;
                case "Készlet Módosítási Kérelmek":
                    Form21 Form21 = new Form21();
                    Form21.ShowDialog();
                    treeView1.SelectedNode = null;
                    break;
                case "Készlet Módosítás Kérés(U)":
                       if (v_cikk != "" && v_cikk != null)
                       {
                           Form12 Form12 = new Form12();
                           Form12.v_cikk = v_cikk;
                           Form12.ShowDialog();
                       }
                       else
                       {
                           MessageBox.Show("      NINCS KIVÁLASZTOTT CIKK !!       ");
                           treeView1.SelectedNode = null;
                           textBox1.Select();
                       }
                        break;
                case "Virtual KanBan Felhasználás U.K.":
                    Form22 Form22 = new Form22();
                    Form22.ShowDialog();
                    treeView1.SelectedNode = null;
                    break;
            }
          }

        public void splitContainer1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
             {
                 case Keys.Escape:
                    v_cikk="";
                    this.KeyPreview = false; 
                    this.splitContainer1.Panel1.Controls.Clear();
                    this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
                    keresmezo();
                    break;
                case Keys.L:
                    FormZaras();
                    Form3 Form3 = new Form3();
                    Form3.v_cikk = v_cikk;
                    ShowForm(Form3);
                    break;
                case Keys.K:
                    FormZaras();
                    Form5 Form5 = new Form5();
                    Form5.v_cikk = v_cikk;
                    ShowForm(Form5);
                    break;
                case Keys.A:
                    FormZaras();
                    Form2 Form2 = new Form2();
                    Form2.v_cikk = v_cikk;
                    ShowForm(Form2);
                    break;
                case Keys.B:
                    FormZaras();
                    Form4 Form4 = new Form4();
                    Form4.v_cikk = v_cikk;
                    ShowForm(Form4);
                    break;
                case Keys.T:
                    FormZaras();
                     Form7 Form7 = new Form7();
                     Form7.v_cikk = v_cikk;
                     Form7.v_mertegys = v_mertegys;
                     ShowForm(Form7);
                     break;
                case Keys.M:
                     FormZaras();
                     Form8 Form8 = new Form8();
                     Form8.v_cikk = v_cikk;
                     ShowForm(Form8);
                     break;
                case Keys.H:
                     FormZaras();
                     Form9 Form9 = new Form9();
                     Form9.v_cikk = v_cikk;
                     ShowForm(Form9);
                     break;
                case Keys.W:
                     FormZaras();
                     Form15 Form15 = new Form15();
                     Form15.v_cikk = v_cikk;
                     ShowForm(Form15);
                     break;  
                case Keys.F:
                     FormZaras();
                     Form10 Form10 = new Form10();
                     Form10.v_cikk = v_cikk;
                     ShowForm(Form10);
                     break;
                case Keys.E:
                    FormZaras();
                    Form20 Form20 = new Form20();
                    Form20.v_cikk = v_cikk;
                    ShowForm(Form20);
                    break;
                case Keys.I:
                    FormZaras();
                    Form19 Form19 = new Form19();
                    Form19.v_cikk = v_cikk;
                    ShowForm(Form19);
                    break;
                case Keys.C:
                    FormZaras();
                    Form17 Form17 = new Form17();
                    Form17.v_cikk = v_cikk;
                    ShowForm(Form17);
                    break;
                case Keys.S:
                    FormZaras();
                    Form16 Form16 = new Form16();
                    Form16.v_cikk = v_cikk;
                    ShowForm(Form16);
                    break;
                case Keys.U:
                    FormZaras();
                    if (v_cikk != "" && v_cikk!=null)
                    {
                        Form12 Form12 = new Form12();
                        Form12.v_cikk = v_cikk;
                        Form12.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("      NINCS KIVÁLASZTOTT CIKK !!       ");
                        treeView1.SelectedNode = null;
                        textBox1.Select();
                    }
                    break;
               }
        }

        public void ShowForm(Form sender)
        {
            if (v_cikk != null && v_cikk!="")
            {
                //sender.ControlBox = false;
                //sender.FormBorderStyle = FormBorderStyle.Fixed3D;
                //sender.ShowInTaskbar = true;
                sender.TopLevel = false;
                this.splitContainer1.Panel1.Controls.Add(sender);
                sender.Show();
            }
            else
            {
                MessageBox.Show("      NINCS KIVÁLASZTOTT CIKK !!       ");
                treeView1.SelectedNode = null;
                textBox1.Select();
            }
        }

     private void keresmezo()
     {
         toolStripButton1.Visible = true;
         textBox1.ReadOnly = false;
         textBox1.Clear();
         textBox1.Select();
      }

     private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string wkeres = " ";

            string seekValue = this.textBox6.Text;
            if (seekValue != wkeres)
            {
                if (!string.IsNullOrEmpty(seekValue))
                {
                   crystalNyilvBindingSource.Filter = "Cim like '%" + seekValue + "%'";
                }
                else
                {
                    try
                    {
                      crystalNyilvBindingSource.Filter = "";
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                }
                wkeres = seekValue;
            }
        }

      private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
          v_report = dataGridView2.CurrentRow.Cells[1].Value.ToString();
          textBox6.Clear();
          Form6 Form6 = new Form6();
          Form6.v_report = v_report;
          ShowForm2(Form6);
      }

      private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
      {
           if (e.KeyCode == Keys.Enter)
          {
              e.Handled = true;
              v_report = dataGridView2.CurrentRow.Cells[1].Value.ToString();
              textBox6.Clear();
              Form6 Form6 = new Form6();
              Form6.v_report = v_report;
              ShowForm2(Form6);
           }
      }

      private void ShowForm2(Form sender)
      {
         sender.TopLevel = false;
      //   this.splitContainer1.Panel1.Controls.Clear(); //clear panel first
          this.splitContainer1.Panel1.Controls.Add(sender);
          sender.Show();
      }

      private void toolStripButton1_Click(object sender, EventArgs e)
      {
          scaCompDBDataSet.Clear();
          this.vF_SC010300_StockfileTableAdapter.Fill(this.scaCompDBDataSet.VF_SC010300_Stockfile);
      }
  
      private void FormZaras()
    {
        if (Application.OpenForms["Form2"] != null)
            Application.OpenForms["Form2"].Close();
        if (Application.OpenForms["Form3"] != null)
            Application.OpenForms["Form3"].Close();
        if (Application.OpenForms["Form4"] != null)
            Application.OpenForms["Form4"].Close();
        if (Application.OpenForms["Form5"] != null)
            Application.OpenForms["Form5"].Close();
        if (Application.OpenForms["Form6"] != null)
            Application.OpenForms["Form6"].Close();
        if (Application.OpenForms["Form7"] != null)
            Application.OpenForms["Form7"].Close();
        if (Application.OpenForms["Form8"] != null)
            Application.OpenForms["Form8"].Close();
        if (Application.OpenForms["Form9"] != null)
            Application.OpenForms["Form9"].Close();
        if (Application.OpenForms["Form10"] != null)
            Application.OpenForms["Form10"].Close();
        if (Application.OpenForms["Form12"] != null)
            Application.OpenForms["Form12"].Close();
        if (Application.OpenForms["Form15"] != null)
            Application.OpenForms["Form15"].Close();
        if (Application.OpenForms["Form17"] != null)
            Application.OpenForms["Form17"].Close();
        if (Application.OpenForms["Form19"] != null)
            Application.OpenForms["Form19"].Close();
       if (Application.OpenForms["Form20"] != null)
           Application.OpenForms["Form20"].Close();
       if (Application.OpenForms["Form16"] != null)
           Application.OpenForms["Form16"].Close();
       if (Application.OpenForms["Form21"] != null)
           Application.OpenForms["Form21"].Close();
       if (Application.OpenForms["Form22"] != null)
           Application.OpenForms["Form22"].Close();
        }
   
    }
        }
    

