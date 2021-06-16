using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdvancedDataGridView;
using System.Drawing.Printing;
using System.DirectoryServices;

namespace CikkLekérdezés
{
    public partial class Form9 : Form
    {
        public string v_cikk, a_cikk, a_mertegys, a_megn1, a_megn2, a_megn3, user,cikkadatok,munkarendi;
        private int korx, kory;
        private List<Hotegory> items = new List<Hotegory>();
        DataGridViewPrinter MyDataGridViewPrinter;
        public Form9()
        {
            InitializeComponent();
            this.treeGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(treeGridView1_MouseClick);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.VF_MP64_OR0103_2021_Workorder_Sales' table. You can move, or remove it, as needed.
            //this.vF_MP64_OR0103_2021_Workorder_SalesTableAdapter.Fill(this.dataSet11.VF_MP64_OR0103_2021_Workorder_Sales);
            // TODO: This line of code loads data into the 'dataSet11.MP610300' table. You can move, or remove it, as needed.
            // this.mP610300TableAdapter.Fill(this.dataSet11.MP610300);
            // TODO: This line of code loads data into the 'dataSet11.CikkAdatok' table. You can move, or remove it, as needed.
            // this.cikkAdatokTableAdapter.Fill(this.dataSet11.CikkAdatok);
            this.struk_HolHa_lScalaTableAdapter.Fill(this.dataSet11.Struk_HolHa_lScala, v_cikk);

            foreach (DataRow dh in dataSet11.Tables[0].Rows)
            {
                items.Add(new Hotegory(dh[3].ToString(), dh[2].ToString(), dh[3].ToString(), dh[8].ToString(), dh[9].ToString(), dh[10].ToString(), dh[13].ToString(), Convert.ToDecimal(dh[4].ToString()), Convert.ToDecimal(dh[11].ToString()), Convert.ToDecimal(dh[12].ToString())));
            }

            treeGridView1.Nodes.Clear();
            LoadBaseNodes();
            Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);

        }
        private void LoadBaseNodes()
        {
            Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            string baseParent = ""; // Find the lowest root Hotegory parent value
            TreeGridNode node;
            foreach (Hotegory cat in items)
            {
                if (cat.HParentID != baseParent)
                    baseParent = cat.HParentID;
            }
            foreach (Hotegory cat in items) // iterate through the categories
            {
                if (cat.HParentID == baseParent) // found a matching root item
                {

                    node = treeGridView1.Nodes.Add(cat.HNodeText.Trim(), cat.Hdesc1, cat.Hmegn, cat.Hintrem, cat.Hegys, cat.Hqty, cat.Hkeszl, cat.Hszabad); // add it to the tree
                    node.Tag = cat; // send the Hotegory into the tag for future processing
                    if (cat.HNodeText.Substring(0, 2) == "02")
                    {
                        node.ImageIndex = 0;
                        node.DefaultCellStyle.Font = boldFont;
                    }
                    else
                        node.ImageIndex = 1;
                    getChildren(node); // load all the children of this node
                }
            }
        }

        private void getChildren(TreeGridNode node)
        {
            Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            TreeGridNode Node = null;
            Hotegory nodeCat = (Hotegory)node.Tag; // get the Hotegory for this node
            foreach (Hotegory cat in items) // locate all children of this Hotegory
            {
                if (cat.HParentID == nodeCat.HID) // found a child
                {
                    Node = node.Nodes.Add(cat.HNodeText.Trim(), cat.Hdesc1, cat.Hmegn, cat.Hintrem, cat.Hegys, cat.Hqty, cat.Hkeszl, cat.Hszabad); // add the child
                    Node.Tag = cat; // set its tag to its Hotegory

                    if (cat.HNodeText.Substring(0, 2) == "02")
                    {
                        Node.ImageIndex = 0;
                        Node.DefaultCellStyle.Font = boldFont;
                    }
                    else

                        Node.ImageIndex = 1;
                    getChildren(Node); // find this child's children
                }
            }
        }
        private void treeGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                MenuItem alap = new MenuItem("Alap Információk");
                MenuItem keszlet = new MenuItem("Készletek");
                MenuItem beerk = new MenuItem("Beérkezések");
                MenuItem varhat = new MenuItem("Várható");
                MenuItem tranz = new MenuItem("Tranzakciók");
                MenuItem kiolv = new MenuItem("Kiolvasztás");
                alap.Click += new EventHandler(alap_Click);
                keszlet.Click += new EventHandler(keszlet_Click);
                beerk.Click += new EventHandler(beerk_Click);
                varhat.Click += new EventHandler(varhat_Click);
                tranz.Click += new EventHandler(tranz_Click);
                kiolv.Click += new EventHandler(kiolv_Click);
                m.MenuItems.AddRange(new MenuItem[] { alap, keszlet, beerk, varhat, tranz, kiolv });
                korx = e.X;
                kory = e.Y;
                m.Show(treeGridView1, new Point(e.X, e.Y));
                a_cikk = treeGridView1.Rows[treeGridView1.HitTest(e.X, e.Y).RowIndex].Cells[0].Value.ToString();
                a_mertegys = treeGridView1.Rows[treeGridView1.HitTest(e.X, e.Y).RowIndex].Cells[4].Value.ToString();
                a_megn1 = treeGridView1.Rows[treeGridView1.HitTest(e.X, e.Y).RowIndex].Cells[1].Value.ToString();
                a_megn2 = treeGridView1.Rows[treeGridView1.HitTest(e.X, e.Y).RowIndex].Cells[2].Value.ToString();
                a_megn3 = treeGridView1.Rows[treeGridView1.HitTest(e.X, e.Y).RowIndex].Cells[3].Value.ToString();
            }
        }
        private void alap_Click(object sender, EventArgs e)
        {
            Form2 al = new Form2();
            al.v_cikk = a_cikk;
            al.ShowDialog();
        }
        private void keszlet_Click(object sender, EventArgs e)
        {
            Form3 ke = new Form3();
            ke.v_cikk = a_cikk;
            ke.v_mertegys = a_mertegys;
            ke.v_megn1 = a_megn1;
            ke.v_megn2 = a_megn2;
            ke.v_megn3 = a_megn3;
            ke.ShowDialog();
        }
        private void beerk_Click(object sender, EventArgs e)
        {
            Form4 bee = new Form4();
            bee.v_cikk = a_cikk;
            bee.v_mertegys = a_mertegys;
            bee.v_megn1 = a_megn1;
            bee.v_megn2 = a_megn2;
            bee.v_megn3 = a_megn3;
            bee.ShowDialog();
        }
        private void varhat_Click(object sender, EventArgs e)
        {
            Form5 va = new Form5();
            va.v_cikk = a_cikk;
            va.v_mertegys = a_mertegys;
            va.v_megn1 = a_megn1;
            va.v_megn2 = a_megn2;
            va.v_megn3 = a_megn3;
            va.ShowDialog();
        }
        private void tranz_Click(object sender, EventArgs e)
        {
            Form7 tra = new Form7();
            tra.v_cikk = a_cikk;
            tra.v_mertegys = a_mertegys;
            tra.v_megn1 = a_megn1;
            tra.v_megn2 = a_megn2;
            tra.v_megn3 = a_megn3;
            tra.ShowDialog();
        }
        private void kiolv_Click(object sender, EventArgs e)
        {
            DirectoryEntry de = new DirectoryEntry("WinNT://" + Environment.UserDomainName + "/" + Environment.UserName);
            user = de.Properties["fullName"].Value.ToString();

            this.cikkAdatokTableAdapter.Fill(this.dataSet11.CikkAdatok, a_cikk);
            int cikkFound = CikkAdatokBindingSource.Count;
            if (cikkFound < 0)
            {
                MessageBox.Show("NINCS ILYEN CIKKADAT !!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cikkadatok ="Ellenállás érték: "+ dataSet11.Tables["CikkAdatok"].Rows[0]["EllenallasMin"].ToString().Trim() + " - " +
                                  dataSet11.Tables["CikkAdatok"].Rows[0]["EllenallasMax"].ToString().Trim();

                this.mP610300TableAdapter.Fill(this.dataSet11.MP610300, a_cikk);
                int BomFound = mP610300BindingSource.Count;
                if (BomFound < 0)
                {
                    MessageBox.Show("NINCS ANYAGJEGYZÉK !!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.vF_MP64_OR0103_2021_Workorder_SalesTableAdapter.Fill(this.dataSet11.VF_MP64_OR0103_2021_Workorder_Sales, a_cikk);
                    int MunkRFound = VF_MP64_OR0103_2021_Workorder_SalesBindingSource.Count;
                    if (MunkRFound <= 0)
                    {
                        munkarendi = "";
                        MessageBox.Show("NINCS MUNKARENDELÉS !!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        munkarendi = dataSet11.Tables["VF_MP64_OR0103_2021_Workorder_Sales"].Rows[0]["WorkorderNo"].ToString().Trim();
                     this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MyPrintDocument_PrintPage);
                     Nyomisz();
                    
                }
            }
        }

        private void Nyomisz()
        {
            SetupThePrinting();

            PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
            MyPrintPreviewDialog.Document = MyPrintDocument;
            MyPrintPreviewDialog.ShowDialog();
        }
        private bool SetupThePrinting()
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = true; //false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;

            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;

            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            this.MyPrintDocument.DefaultPageSettings.Landscape = false;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(5, 5, 300, 1);

            MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView1, MyPrintDocument, true, true, "", new Font("Verdana", 16, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }
        private void MyPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image newImage = Image.FromFile("Logo_FT.jpg");
            Point ulCorner = new Point(25, 25);
            string mystring = Convert.ToString(DateTime.Now);
            System.Drawing.Graphics g = e.Graphics;
            StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
            format2.LineAlignment = StringAlignment.Center;
            format2.Alignment = StringAlignment.Far;

            StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
            format1.LineAlignment = StringAlignment.Center;
            format1.Alignment = StringAlignment.Center;

            StringFormat format3 = new StringFormat(StringFormatFlags.NoClip);
            format3.LineAlignment = StringAlignment.Center;
            format3.Alignment = StringAlignment.Far;
            format3.FormatFlags = StringFormatFlags.DirectionVertical;

            e.Graphics.DrawImage(newImage, ulCorner);
            g.DrawString("Kaposvár," + mystring.Substring(0, 11), new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(750, 70), format2);
            g.DrawString("Nyomtatta : " + user, new System.Drawing.Font("Verdana", 8F), new SolidBrush(Color.Black), new Point(750, 90), format2);
            Pen blackPen = new Pen(Color.Black, 1);
            Rectangle rect1 = new Rectangle(30, 120, 760, 120);
            e.Graphics.DrawRectangle(blackPen, rect1);
            g.DrawString(a_megn1.Trim(), new System.Drawing.Font("Verdana", 20F, FontStyle.Bold), new SolidBrush(Color.Black), new Point(400, 150), format1);
            g.DrawString("*"+munkarendi.Trim()+"*", new System.Drawing.Font("Code 39", 26F), new SolidBrush(Color.Black), new Point(400, 200), format1);      
            g.DrawString(munkarendi.Trim(), new System.Drawing.Font("Verdana", 9F), new SolidBrush(Color.Black), new Point(400, 230), format1);
            g.DrawString(cikkadatok.Trim(), new System.Drawing.Font("Verdana", 15F, FontStyle.Underline), new SolidBrush(Color.Green), new Point(400, 270), format1);
            g.DrawString("!! TÉPÉSPRÓBA !!", new System.Drawing.Font("Verdana", 15F, FontStyle.Bold), new SolidBrush(Color.Red), new Point(400,310+(20*dataGridView1.RowCount)), format1);
            g.DrawString("Hol hegesztették? :", new System.Drawing.Font("Verdana", 12F), new SolidBrush(Color.Black), new Point(130, 350 + (20 * dataGridView1.RowCount)), format1);
            g.DrawString("Hol homokozták?  :", new System.Drawing.Font("Verdana", 12F), new SolidBrush(Color.Black), new Point(130, 380 + (20 * dataGridView1.RowCount)), format1);
            bool more = MyDataGridViewPrinter.DrawDataGridView(g);
            if (more == true)
                e.HasMorePages = true;
        }
    }

    class Hotegory
    {
        public string HID, HParentID, HNodeText, Hdesc1, Hmegn, Hintrem, Hegys;
        public decimal Hkeszl, Hszabad,Hqty;
        public Hotegory(string HID, string HParentID, string HNodeText, string Hdesc1, string Hmegn, string Hintrem, string Hegys, decimal Hqty, decimal Hkeszl, decimal Hszabad)
        {
            this.HID = HID;
            this.HParentID = HParentID;
            this.HNodeText = HNodeText;
            this.Hdesc1 = Hdesc1;
            this.Hmegn = Hmegn;
            this.Hintrem = Hintrem;
            this.Hegys = Hegys;
            this.Hqty = Hqty;
            this.Hkeszl = Hkeszl;
            this.Hszabad = Hszabad;
        }
        public override string ToString()
        {
            return this.HNodeText;
        }
   
    }
}
