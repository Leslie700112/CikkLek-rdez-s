namespace CikkLekérdezés
{
    partial class Form10
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workCenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDescrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setupTime1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runTime1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcontrCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mP52002DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mP52003DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mP52018DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mP52019DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vFMP630300OperationMPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new CikkLekérdezés.DataSet12();
            this.vF_MP630300_OperationMPCTableAdapter = new CikkLekérdezés.DataSet12TableAdapters.VF_MP630300_OperationMPCTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFMP630300OperationMPCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operationNoDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.workCenterDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.operationDescrDataGridViewTextBoxColumn,
            this.setupTime1DataGridViewTextBoxColumn,
            this.runTime1DataGridViewTextBoxColumn,
            this.subcontrCostDataGridViewTextBoxColumn,
            this.costCodeDataGridViewTextBoxColumn,
            this.toolNumberDataGridViewTextBoxColumn,
            this.mP52002DataGridViewTextBoxColumn,
            this.mP52003DataGridViewTextBoxColumn,
            this.mP52018DataGridViewTextBoxColumn,
            this.mP52019DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vFMP630300OperationMPCBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 643);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // operationNoDataGridViewTextBoxColumn
            // 
            this.operationNoDataGridViewTextBoxColumn.DataPropertyName = "OperationNo";
            this.operationNoDataGridViewTextBoxColumn.HeaderText = "Műv.Sorszám";
            this.operationNoDataGridViewTextBoxColumn.Name = "operationNoDataGridViewTextBoxColumn";
            this.operationNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationNoDataGridViewTextBoxColumn.Width = 75;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Művelet";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 80;
            // 
            // workCenterDataGridViewTextBoxColumn
            // 
            this.workCenterDataGridViewTextBoxColumn.DataPropertyName = "WorkCenter";
            this.workCenterDataGridViewTextBoxColumn.HeaderText = "Munkahely";
            this.workCenterDataGridViewTextBoxColumn.Name = "workCenterDataGridViewTextBoxColumn";
            this.workCenterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description_";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Megnevezés";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 200;
            // 
            // operationDescrDataGridViewTextBoxColumn
            // 
            this.operationDescrDataGridViewTextBoxColumn.DataPropertyName = "OperationDescr";
            this.operationDescrDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.operationDescrDataGridViewTextBoxColumn.Name = "operationDescrDataGridViewTextBoxColumn";
            this.operationDescrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // setupTime1DataGridViewTextBoxColumn
            // 
            this.setupTime1DataGridViewTextBoxColumn.DataPropertyName = "SetupTime1";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.setupTime1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.setupTime1DataGridViewTextBoxColumn.HeaderText = "Beállítási idő(óra)";
            this.setupTime1DataGridViewTextBoxColumn.Name = "setupTime1DataGridViewTextBoxColumn";
            this.setupTime1DataGridViewTextBoxColumn.ReadOnly = true;
            this.setupTime1DataGridViewTextBoxColumn.Width = 70;
            // 
            // runTime1DataGridViewTextBoxColumn
            // 
            this.runTime1DataGridViewTextBoxColumn.DataPropertyName = "RunTime1";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N5";
            dataGridViewCellStyle17.NullValue = null;
            this.runTime1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.runTime1DataGridViewTextBoxColumn.HeaderText = "Gyártási idő (óra)";
            this.runTime1DataGridViewTextBoxColumn.Name = "runTime1DataGridViewTextBoxColumn";
            this.runTime1DataGridViewTextBoxColumn.ReadOnly = true;
            this.runTime1DataGridViewTextBoxColumn.Width = 70;
            // 
            // subcontrCostDataGridViewTextBoxColumn
            // 
            this.subcontrCostDataGridViewTextBoxColumn.DataPropertyName = "SubcontrCost";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N4";
            dataGridViewCellStyle18.NullValue = null;
            this.subcontrCostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.subcontrCostDataGridViewTextBoxColumn.HeaderText = "Alváll.Költség";
            this.subcontrCostDataGridViewTextBoxColumn.Name = "subcontrCostDataGridViewTextBoxColumn";
            this.subcontrCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.subcontrCostDataGridViewTextBoxColumn.Width = 75;
            // 
            // costCodeDataGridViewTextBoxColumn
            // 
            this.costCodeDataGridViewTextBoxColumn.DataPropertyName = "CostCode";
            this.costCodeDataGridViewTextBoxColumn.HeaderText = "KöltségKód";
            this.costCodeDataGridViewTextBoxColumn.Name = "costCodeDataGridViewTextBoxColumn";
            this.costCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.costCodeDataGridViewTextBoxColumn.Width = 70;
            // 
            // toolNumberDataGridViewTextBoxColumn
            // 
            this.toolNumberDataGridViewTextBoxColumn.DataPropertyName = "ToolNumber";
            this.toolNumberDataGridViewTextBoxColumn.HeaderText = "Szerszám";
            this.toolNumberDataGridViewTextBoxColumn.Name = "toolNumberDataGridViewTextBoxColumn";
            this.toolNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mP52002DataGridViewTextBoxColumn
            // 
            this.mP52002DataGridViewTextBoxColumn.DataPropertyName = "MP52002";
            this.mP52002DataGridViewTextBoxColumn.HeaderText = "Szerszám Név";
            this.mP52002DataGridViewTextBoxColumn.Name = "mP52002DataGridViewTextBoxColumn";
            this.mP52002DataGridViewTextBoxColumn.ReadOnly = true;
            this.mP52002DataGridViewTextBoxColumn.Width = 120;
            // 
            // mP52003DataGridViewTextBoxColumn
            // 
            this.mP52003DataGridViewTextBoxColumn.DataPropertyName = "MP52003";
            this.mP52003DataGridViewTextBoxColumn.HeaderText = "Rajzszám";
            this.mP52003DataGridViewTextBoxColumn.Name = "mP52003DataGridViewTextBoxColumn";
            this.mP52003DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mP52018DataGridViewTextBoxColumn
            // 
            this.mP52018DataGridViewTextBoxColumn.DataPropertyName = "MP52018";
            this.mP52018DataGridViewTextBoxColumn.HeaderText = "Megevezés";
            this.mP52018DataGridViewTextBoxColumn.Name = "mP52018DataGridViewTextBoxColumn";
            this.mP52018DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mP52019DataGridViewTextBoxColumn
            // 
            this.mP52019DataGridViewTextBoxColumn.DataPropertyName = "MP52019";
            this.mP52019DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.mP52019DataGridViewTextBoxColumn.Name = "mP52019DataGridViewTextBoxColumn";
            this.mP52019DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vFMP630300OperationMPCBindingSource
            // 
            this.vFMP630300OperationMPCBindingSource.DataMember = "VF_MP630300_OperationMPC";
            this.vFMP630300OperationMPCBindingSource.DataSource = this.dataSet12BindingSource;
            // 
            // dataSet12BindingSource
            // 
            this.dataSet12BindingSource.DataSource = this.dataSet12;
            this.dataSet12BindingSource.Position = 0;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet12";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vF_MP630300_OperationMPCTableAdapter
            // 
            this.vF_MP630300_OperationMPCTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 621);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1294, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(91, 17);
            this.toolStripStatusLabel1.Text = "Gyártási idő :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(165, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel3.Text = "óra";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel4.Text = "Mennyiség :";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 643);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10";
            this.ShowIcon = false;
            this.Text = "Munkafolyamatok";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vFMP630300OperationMPCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet12BindingSource;
        private DataSet12 dataSet12;
        private System.Windows.Forms.BindingSource vFMP630300OperationMPCBindingSource;
        private DataSet12TableAdapters.VF_MP630300_OperationMPCTableAdapter vF_MP630300_OperationMPCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workCenterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDescrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setupTime1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runTime1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcontrCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mP52002DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mP52003DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mP52018DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mP52019DataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}