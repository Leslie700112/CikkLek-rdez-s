using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdvancedDataGridView;


namespace CikkLekérdezés
{
    public partial class Form8 : Form
    {
        public string v_cikk, a_cikk, a_mertegys,a_megn1,a_megn2,a_megn3;
        private int korx, kory;
        private List<Category> items = new List<Category>();
        public Form8()
        {
            InitializeComponent();
            this.treeGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(treeGridView1_MouseClick);
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           this.struktura_NewTableAdapter.Fill(this.dataSet10.Struktura_New, v_cikk);//"0001000100101004"

                foreach (DataRow dr in dataSet10.Tables[0].Rows)
                {
                    items.Add(new Category(dr[3].ToString().Trim(), dr[2].ToString().Trim(), dr[3].ToString(), dr[8].ToString(), dr[9].ToString(),
                        dr[10].ToString(), dr[13].ToString(), Convert.ToDecimal(dr[7].ToString()), Convert.ToDecimal(dr[11].ToString()), 
                        Convert.ToDecimal(dr[12].ToString()), dr[14].ToString(),dr[16].ToString()));
                }

                treeGridView1.Nodes.Clear();
                LoadBaseNodes();
                Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);
          
        }
        private void LoadBaseNodes()
        {
            Font boldFont = new Font(treeGridView1.DefaultCellStyle.Font, FontStyle.Bold);
            string baseParent = v_cikk; // Find the lowest root category parent value
            TreeGridNode node;
           // foreach (Category cat in items)
           // {
           //     if (cat.ParentID != baseParent)
           //         baseParent = cat.ParentID;
           // }
            foreach (Category cat in items) // iterate through the categories
            {
                if (cat.ParentID == baseParent) // found a matching root item
                {

                    node = treeGridView1.Nodes.Add(cat.NodeText.Trim(), cat.desc1, cat.megn, cat.intrem, cat.egys, cat.szuks, cat.keszl,
                        cat.szabad,cat.techni,cat.ware); // add it to the tree
                    node.Tag = cat; // send the category into the tag for future processing
                    if (cat.NodeText.Substring(0, 2) == "02")
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
            Category nodeCat = (Category)node.Tag; // get the category for this node
            foreach (Category cat in items) // locate all children of this category
            {
                if (cat.ParentID == nodeCat.ID) // found a child
                {
                    Node = node.Nodes.Add(cat.NodeText.Trim(), cat.desc1, cat.megn, cat.intrem, cat.egys, cat.szuks, 
                        cat.keszl, cat.szabad,cat.techni,cat.ware); // add the child
                    Node.Tag = cat; // set its tag to its category

                    if (cat.NodeText.Substring(0, 2) == "02")
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
                alap.Click += new EventHandler(alap_Click);
                keszlet.Click += new EventHandler(keszlet_Click);
                beerk.Click += new EventHandler(beerk_Click);
                varhat.Click += new EventHandler(varhat_Click);
                tranz.Click += new EventHandler(tranz_Click);
                m.MenuItems.AddRange(new MenuItem[] {alap, keszlet, beerk, varhat, tranz});
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
    
    
    
    }
    
    class Category
    {
        public string ID, ParentID, NodeText, desc1, megn, intrem, egys,techni,ware ;
        public decimal szuks, keszl,szabad;
        public Category(string ID, string ParentID, string NodeText, string desc1, string megn, string intrem, string egys, decimal szuks, decimal keszl, decimal szabad,string techni,string ware)
        {
            this.ID = ID;
            this.ParentID = ParentID;
            this.NodeText = NodeText;
            this.desc1 = desc1;
            this.megn = megn;
            this.intrem = intrem;
            this.egys = egys;
            this.szuks = szuks;
            this.keszl = keszl;
            this.szabad = szabad;
            this.techni = techni;
            this.ware = ware;
        }
        public override string ToString()
        {
            return this.NodeText;
        }
       
    }
}
