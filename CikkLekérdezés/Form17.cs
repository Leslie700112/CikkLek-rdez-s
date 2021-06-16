using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CikkLekérdezés
{
    public partial class Form17 : Form
    {
        public string v_cikk;
        private int elso = 0;
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            textBox1.Text = "5.13";
            textBox2.Text = "6.33";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "30";
            Kalkulál();
            Szamolgat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Szamolgat();
        }

        private void Kalkulál()
        {
             Cursor.Current = Cursors.WaitCursor;
            SqlConnection connection = new SqlConnection("Data Source=SCALA1;Initial Catalog=ScaCompDB;Persist Security Info=True;User ID=termelesmonitor;Password=TERM123");
            connection.Open();
            SqlCommand mySqlCommand = connection.CreateCommand();
            da.SelectCommand = new SqlCommand(@"exec KalkSulyAtlAr; "+

"WITH Stuky(ParentItem,Description1P, Component,Description1C,OperationNo, Quantity,Level,Sort,Szorzo,Szorzo2) AS "+
"(SELECT ParentItem,Description1P, Component,Description1C,OperationNo, Quantity, 0 as Level, CAST('¤'+rtrim(Component) as nvarchar(255)), Quantity, Quantity " + 
    "FROM VF_MP610300_Struct_SC01_desc "+
    "WHERE ParentItem='"+v_cikk+"'" +
    " UNION ALL "+
    "SELECT e.ParentItem,e.Description1P, e.Component,e.Description1C,e.OperationNo,e.Quantity, Level+1,CAST(Sort+'¤'+rtrim(e.Component) as nvarchar(255)), Szorzo,d.Quantity "+
        "FROM VF_MP610300_Struct_SC01_desc AS e "+
        "INNER JOIN Stuky AS d ON e.ParentItem = d.Component) "+
"SELECT rtrim(Stuky.Component) as Component,Stuky.Description1C,SC0C.Description2,SC0C.InternRem1,Sort,MP.WorkCenter+' '+MP.Description as WorkCenter,CostCode,Stuky.Quantity,substring(SCU.Description,3,3) as Unit ,"+
"case when Stuky.Szorzo=Stuky.Szorzo2 or Stuky.Szorzo2=Stuky.Quantity then (case when Level=0 or Stuky.ParentItem='020599820001' then 1 else Stuky.Szorzo end) else Stuky.Szorzo*Stuky.Szorzo2 end Szorzo," +
"SA.Fifoar as Price,MP.RunTime1,MP.SubcontrCost,0.0000 as MaterialCost,0.0000 as SubcontractCost ,0.0000 as ShippingCost,0.0000 as SmallmaterialCost," +
"0.0000 as TotalMaterial,0.0000 as ManufacturingCost,0.0000 as MarginalCost,0.0000 Coefficient,0.0000 SalesPrice  " +
"FROM Stuky left outer join "+
"Fusetech.dbo.SulyAtlAr2 as SA on Stuky.Component=SA.Item left outer join "+
"VF_MP630300_OperationMPC as MP on Stuky.Component=MP.ParentItem left outer join "+ 
"VF_SC010300_Stockfile as SC0C on Stuky.Component=SC0C.StockCode left outer join "+
"VF_SCUN0300_UnitCode as SCU on SC0C.UnitCodeMPC=SCU.UnitCode "+
"union all "+
"select rtrim(MP2.ParentItem) as Component, '' as Desription1C,'' as Description2,'' as InternRem1,'" + v_cikk + "',MP2.WorkCenter+' '+MP2.Description as WorkCenter,MP2.CostCode,1,'' as Unit," +
            "1,0,MP2.RunTime1,MP2.SubcontrCost,0.0000 as MaterialCost,0.0000 as SubcontractCost,0.0000 as ShippingCost,0.0000 as SmallmaterialCost, " +
            "0.0000 as TotalMaterial,0.0000 as ManufacturingCost,0.0000 as MarginalCost,0.0000 Coefficient,0.0000 SalesPrice " +
"from VF_MP630300_OperationMPC as MP2 "+
            "where MP2.ParentItem='"+v_cikk+"'"+
"ORDER BY Sort ",connection);
            ds.Clear();
            da.Fill(ds, "Kalkulal");
            this.dataGridView1.DataSource = ds;
            this.dataGridView1.DataMember = "Kalkulal";

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds;
            bindingSource.DataMember = "Kalkulal";
            dataGridView1.DataSource = bindingSource;
            connection.Close();
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[13].ReadOnly = true;
            dataGridView1.Columns[14].ReadOnly = true;
            dataGridView1.Columns[15].ReadOnly = true;
            dataGridView1.Columns[16].ReadOnly = true;
            dataGridView1.Columns[17].ReadOnly = true;
            dataGridView1.Columns[18].ReadOnly = true;
            dataGridView1.Columns[19].ReadOnly = true;
            dataGridView1.Columns[20].ReadOnly = true;
            dataGridView1.Columns[21].ReadOnly = true;
            this.dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.NullValue = null;
            for (int x = 0; x < dataGridView1.Columns.Count; ++x)
            {
                if (x == 6)
                    dataGridView1.Columns[x].Width = 50;
                if (x == 8)
                    dataGridView1.Columns[x].Width = 40;
                if (x == 9)
                {
                    dataGridView1.Columns[x].Width = 50;
                }
                if (x == 7 || (x >= 9 && x <= 21))
                {
                    //if (x >= 13)
                    //    dataGridViewCellStyle7.Format = "N4";
                    //else
                    dataGridViewCellStyle7.Format = "N5";
                    dataGridView1.Columns[x].DefaultCellStyle = dataGridViewCellStyle7;
                    dataGridView1.Columns[x].Width = 80;
                }

            }
        }
      
  private void Szamolgat()
        {
            double material=0,subcont=0,shipping=0,small=0,totalm=0,manufact=0;
            for (int x = 0; x < dataGridView1.Rows.Count - 1; ++x)
            {
                if (dataGridView1.Rows[x].Cells["Component"].Value.ToString().Length!=0 && dataGridView1.Rows[x].Cells["Component"].Value.ToString().Substring(0, 2) == "03")
                {
                    dataGridView1.Rows[x].Cells["MaterialCost"].Value =
                      Convert.ToDouble(dataGridView1.Rows[x].Cells["Price"].Value) *
                       Convert.ToDouble(dataGridView1.Rows[x].Cells["Szorzo"].Value) * Convert.ToDouble(dataGridView1.Rows[x].Cells["Quantity"].Value);
                }
                else
                    dataGridView1.Rows[x].Cells["MaterialCost"].Value = 0;

                if (dataGridView1.Rows[x].Cells["CostCode"].Value.ToString().Trim() == "K3")
                    dataGridView1.Rows[x].Cells["SubcontractCost"].Value =
                          Convert.ToDouble(dataGridView1.Rows[x].Cells["SubcontrCost"].Value) *
                        Convert.ToDouble(dataGridView1.Rows[x].Cells["Szorzo"].Value) * Convert.ToDouble(dataGridView1.Rows[x].Cells["Quantity"].Value);
                else
                    dataGridView1.Rows[x].Cells["SubcontractCost"].Value = 0;

               dataGridView1.Rows[x].Cells["ShippingCost"].Value =(Convert.ToDouble(dataGridView1.Rows[x].Cells["MaterialCost"].Value) +
                                                                  Convert.ToDouble(dataGridView1.Rows[x].Cells["SubcontractCost"].Value))*
                                                                  (Convert.ToDouble(textBox3.Text)/100);
               dataGridView1.Rows[x].Cells["SmallmaterialCost"].Value = (Convert.ToDouble(dataGridView1.Rows[x].Cells["MaterialCost"].Value) +
                                                                Convert.ToDouble(dataGridView1.Rows[x].Cells["SubcontractCost"].Value)) *
                                                                (Convert.ToDouble(textBox4.Text) / 100);
               dataGridView1.Rows[x].Cells["TotalMaterial"].Value = Convert.ToDouble(dataGridView1.Rows[x].Cells["MaterialCost"].Value) +
                                                                  Convert.ToDouble(dataGridView1.Rows[x].Cells["SubcontractCost"].Value) +
                                                                  Convert.ToDouble(dataGridView1.Rows[x].Cells["ShippingCost"].Value) +
                                                                  Convert.ToDouble(dataGridView1.Rows[x].Cells["SmallmaterialCost"].Value);
               switch (dataGridView1.Rows[x].Cells["CostCode"].Value.ToString().Trim())
               {
                   case "K1":
                       dataGridView1.Rows[x].Cells["ManufacturingCost"].Value =
                       Convert.ToDouble(textBox1.Text.Trim()) * Convert.ToDouble(dataGridView1.Rows[x].Cells["RunTime1"].Value) *
                       Convert.ToDouble(dataGridView1.Rows[x].Cells["Szorzo"].Value) * Convert.ToDouble(dataGridView1.Rows[x].Cells["Quantity"].Value);
                       break;
                   case "K2":
                       dataGridView1.Rows[x].Cells["ManufacturingCost"].Value =
                       Convert.ToDouble(textBox2.Text.Trim()) * Convert.ToDouble(dataGridView1.Rows[x].Cells["RunTime1"].Value) *
                       Convert.ToDouble(dataGridView1.Rows[x].Cells["Szorzo"].Value) * Convert.ToDouble(dataGridView1.Rows[x].Cells["Quantity"].Value);
                       break;
                   default:
                       dataGridView1.Rows[x].Cells["ManufacturingCost"].Value = 0;
                       break;
               }
                dataGridView1.Rows[x].Cells["MarginalCost"].Value = Convert.ToDouble(dataGridView1.Rows[x].Cells["TotalMaterial"].Value) +
                                                                 Convert.ToDouble(dataGridView1.Rows[x].Cells["ManufacturingCost"].Value);
               dataGridView1.Rows[x].Cells["Coefficient"].Value = Convert.ToDouble(dataGridView1.Rows[x].Cells["MarginalCost"].Value) *
                                                                 (Convert.ToDouble(textBox5.Text.Trim()) / 100);
               dataGridView1.Rows[x].Cells["SalesPrice"].Value = Convert.ToDouble(dataGridView1.Rows[x].Cells["MarginalCost"].Value) *
                                                               ((Convert.ToDouble(textBox5.Text.Trim()) / 100)+1);
                material = material + Convert.ToDouble(dataGridView1.Rows[x].Cells["MaterialCost"].Value);
               subcont = subcont + Convert.ToDouble(dataGridView1.Rows[x].Cells["SubcontractCost"].Value);
               shipping = shipping + Convert.ToDouble(dataGridView1.Rows[x].Cells["ShippingCost"].Value);
               small = small + Convert.ToDouble(dataGridView1.Rows[x].Cells["SmallmaterialCost"].Value);
               totalm = totalm + Convert.ToDouble(dataGridView1.Rows[x].Cells["TotalMaterial"].Value);
               manufact = manufact + Convert.ToDouble(dataGridView1.Rows[x].Cells["ManufacturingCost"].Value);
            }
            if (elso == 0)
            {
                label8.Text = material.ToString("N4");
                label10.Text = subcont.ToString("N4");
                label11.Text = shipping.ToString("N4");
                label13.Text = small.ToString("N4");
                label15.Text = totalm.ToString("N4");
                label17.Text = manufact.ToString("N4");
                label19.Text = (totalm + manufact).ToString("N4");
                label21.Text = ((totalm + manufact) * (Convert.ToDouble(textBox5.Text.Trim()) / 100)).ToString("N4");
                label23.Text = ((totalm + manufact) * ((Convert.ToDouble(textBox5.Text.Trim()) / 100)+1)).ToString("N4");
            }
                textBox6.Text = material.ToString("N4");
                textBox7.Text = subcont.ToString("N4");
                textBox8.Text = shipping.ToString("N4");
                textBox9.Text = small.ToString("N4");
                textBox10.Text = totalm.ToString("N4");
                textBox11.Text = manufact.ToString("N4");
                textBox12.Text = (totalm + manufact).ToString("N4");
                textBox13.Text = ((totalm + manufact) * (Convert.ToDouble(textBox5.Text.Trim()) / 100)).ToString("N4");
                textBox14.Text = ((totalm + manufact) * ((Convert.ToDouble(textBox5.Text.Trim()) / 100)+1)).ToString("N4");
                elso = 1;
        }

  private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
  {
      e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
    
      {
          TextBox tb = e.Control as TextBox;
          if (tb != null)
          {
              tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
          }
      }
      
  }
  private void Column1_KeyPress(object sender, KeyPressEventArgs e)
  {
      if (dataGridView1.CurrentCell.ColumnIndex!=6)
     {
      if (dataGridView1.CurrentCell.ColumnIndex==0)
      {
          if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
          {
              e.Handled = true;
          }

      }
      else
      {
          if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
          {
              e.Handled = true;
          }
          // only allow one decimal point 
          if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
          {
              e.Handled = true;
          }
      }
     }
  }



    }
}
