namespace CikkLekérdezés
{
    partial class Form19
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet19 = new CikkLekérdezés.DataSet19();
            this.invoicesTableAdapter = new CikkLekérdezés.DataSet19TableAdapters.InvoicesTableAdapter();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCodeInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPONoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineNoXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intrPlanningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purcaseOrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivDateReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivDateActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyOrderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyOriginalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.custCodeInvDataGridViewTextBoxColumn,
            this.CustName,
            this.custPONoDataGridViewTextBoxColumn,
            this.shipmentMarkDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.lineNoXDataGridViewTextBoxColumn,
            this.intrPlanningDataGridViewTextBoxColumn,
            this.purcaseOrNoDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.qtyDeliveredDataGridViewTextBoxColumn,
            this.delivDateReqDataGridViewTextBoxColumn,
            this.delivDateActDataGridViewTextBoxColumn,
            this.invoiceFullDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.qtyOrderedDataGridViewTextBoxColumn,
            this.qtyOriginalDataGridViewTextBoxColumn,
            this.salesmanNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoicesBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 650);
            this.dataGridView1.TabIndex = 0;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.dataSet19;
            // 
            // dataSet19
            // 
            this.dataSet19.DataSetName = "DataSet19";
            this.dataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custCodeInvDataGridViewTextBoxColumn
            // 
            this.custCodeInvDataGridViewTextBoxColumn.DataPropertyName = "CustCodeInv";
            this.custCodeInvDataGridViewTextBoxColumn.HeaderText = "CustCodeInv";
            this.custCodeInvDataGridViewTextBoxColumn.Name = "custCodeInvDataGridViewTextBoxColumn";
            this.custCodeInvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "CustName";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            // 
            // custPONoDataGridViewTextBoxColumn
            // 
            this.custPONoDataGridViewTextBoxColumn.DataPropertyName = "CustPONo";
            this.custPONoDataGridViewTextBoxColumn.HeaderText = "CustPONo";
            this.custPONoDataGridViewTextBoxColumn.Name = "custPONoDataGridViewTextBoxColumn";
            this.custPONoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipmentMarkDataGridViewTextBoxColumn
            // 
            this.shipmentMarkDataGridViewTextBoxColumn.DataPropertyName = "ShipmentMark";
            this.shipmentMarkDataGridViewTextBoxColumn.HeaderText = "ShipmentMark";
            this.shipmentMarkDataGridViewTextBoxColumn.Name = "shipmentMarkDataGridViewTextBoxColumn";
            this.shipmentMarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineNoXDataGridViewTextBoxColumn
            // 
            this.lineNoXDataGridViewTextBoxColumn.DataPropertyName = "LineNoX";
            this.lineNoXDataGridViewTextBoxColumn.HeaderText = "LineNoX";
            this.lineNoXDataGridViewTextBoxColumn.Name = "lineNoXDataGridViewTextBoxColumn";
            this.lineNoXDataGridViewTextBoxColumn.ReadOnly = true;
            this.lineNoXDataGridViewTextBoxColumn.Width = 70;
            // 
            // intrPlanningDataGridViewTextBoxColumn
            // 
            this.intrPlanningDataGridViewTextBoxColumn.DataPropertyName = "IntrPlanning";
            this.intrPlanningDataGridViewTextBoxColumn.HeaderText = "IntrPlanning";
            this.intrPlanningDataGridViewTextBoxColumn.Name = "intrPlanningDataGridViewTextBoxColumn";
            this.intrPlanningDataGridViewTextBoxColumn.ReadOnly = true;
            this.intrPlanningDataGridViewTextBoxColumn.Width = 80;
            // 
            // purcaseOrNoDataGridViewTextBoxColumn
            // 
            this.purcaseOrNoDataGridViewTextBoxColumn.DataPropertyName = "PurcaseOrNo";
            this.purcaseOrNoDataGridViewTextBoxColumn.HeaderText = "PurcaseOrNo";
            this.purcaseOrNoDataGridViewTextBoxColumn.Name = "purcaseOrNoDataGridViewTextBoxColumn";
            this.purcaseOrNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // qtyDeliveredDataGridViewTextBoxColumn
            // 
            this.qtyDeliveredDataGridViewTextBoxColumn.DataPropertyName = "QtyDelivered";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.qtyDeliveredDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtyDeliveredDataGridViewTextBoxColumn.HeaderText = "QtyDelivered";
            this.qtyDeliveredDataGridViewTextBoxColumn.Name = "qtyDeliveredDataGridViewTextBoxColumn";
            this.qtyDeliveredDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDeliveredDataGridViewTextBoxColumn.Width = 80;
            // 
            // delivDateReqDataGridViewTextBoxColumn
            // 
            this.delivDateReqDataGridViewTextBoxColumn.DataPropertyName = "DelivDateReq";
            this.delivDateReqDataGridViewTextBoxColumn.HeaderText = "DelivDateReq";
            this.delivDateReqDataGridViewTextBoxColumn.Name = "delivDateReqDataGridViewTextBoxColumn";
            this.delivDateReqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delivDateActDataGridViewTextBoxColumn
            // 
            this.delivDateActDataGridViewTextBoxColumn.DataPropertyName = "DelivDateAct";
            this.delivDateActDataGridViewTextBoxColumn.HeaderText = "DelivDateAct";
            this.delivDateActDataGridViewTextBoxColumn.Name = "delivDateActDataGridViewTextBoxColumn";
            this.delivDateActDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceFullDataGridViewTextBoxColumn
            // 
            this.invoiceFullDataGridViewTextBoxColumn.DataPropertyName = "InvoiceFull";
            this.invoiceFullDataGridViewTextBoxColumn.HeaderText = "InvoiceFull";
            this.invoiceFullDataGridViewTextBoxColumn.Name = "invoiceFullDataGridViewTextBoxColumn";
            this.invoiceFullDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description1";
            this.description1DataGridViewTextBoxColumn.HeaderText = "Description1";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            this.description1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // description2DataGridViewTextBoxColumn
            // 
            this.description2DataGridViewTextBoxColumn.DataPropertyName = "Description2";
            this.description2DataGridViewTextBoxColumn.HeaderText = "Description2";
            this.description2DataGridViewTextBoxColumn.Name = "description2DataGridViewTextBoxColumn";
            this.description2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internRem1DataGridViewTextBoxColumn
            // 
            this.internRem1DataGridViewTextBoxColumn.DataPropertyName = "InternRem1";
            this.internRem1DataGridViewTextBoxColumn.HeaderText = "InternRem1";
            this.internRem1DataGridViewTextBoxColumn.Name = "internRem1DataGridViewTextBoxColumn";
            this.internRem1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyOrderedDataGridViewTextBoxColumn
            // 
            this.qtyOrderedDataGridViewTextBoxColumn.DataPropertyName = "QtyOrdered";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.qtyOrderedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.qtyOrderedDataGridViewTextBoxColumn.HeaderText = "QtyOrdered";
            this.qtyOrderedDataGridViewTextBoxColumn.Name = "qtyOrderedDataGridViewTextBoxColumn";
            this.qtyOrderedDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyOrderedDataGridViewTextBoxColumn.Width = 80;
            // 
            // qtyOriginalDataGridViewTextBoxColumn
            // 
            this.qtyOriginalDataGridViewTextBoxColumn.DataPropertyName = "QtyOriginal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.qtyOriginalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.qtyOriginalDataGridViewTextBoxColumn.HeaderText = "QtyOriginal";
            this.qtyOriginalDataGridViewTextBoxColumn.Name = "qtyOriginalDataGridViewTextBoxColumn";
            this.qtyOriginalDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyOriginalDataGridViewTextBoxColumn.Width = 80;
            // 
            // salesmanNoDataGridViewTextBoxColumn
            // 
            this.salesmanNoDataGridViewTextBoxColumn.DataPropertyName = "SalesmanNo";
            this.salesmanNoDataGridViewTextBoxColumn.HeaderText = "SalesmanNo";
            this.salesmanNoDataGridViewTextBoxColumn.Name = "salesmanNoDataGridViewTextBoxColumn";
            this.salesmanNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesmanNoDataGridViewTextBoxColumn.Width = 60;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 650);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form19";
            this.Text = "Kimenő Számlák";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet19)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet19 dataSet19;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private DataSet19TableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCodeInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPONoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineNoXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intrPlanningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purcaseOrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivDateReqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delivDateActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceFullDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyOrderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyOriginalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanNoDataGridViewTextBoxColumn;
    }
}