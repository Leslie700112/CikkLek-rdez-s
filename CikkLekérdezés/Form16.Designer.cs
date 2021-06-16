namespace CikkLekérdezés
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.raklapRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rakomany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaklapFajta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RaklapSuly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZarasIdo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiSzallNapja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rakomanyido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megjegyz1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megjegyz2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megjegyz3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megjegyz4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raklapkezeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Felhasznalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRendelesRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Munkahely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikkszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internRem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPONoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scalaszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallhetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kertHetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCodeInvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csomFajtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyujtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raklapMRendelesekJelentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet15 = new CikkLekérdezés.DataSet15();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.raklap_MRendelesek_JelentTableAdapter = new CikkLekérdezés.DataSet15TableAdapters.Raklap_MRendelesek_JelentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raklapMRendelesekJelentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 7F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.raklapRDataGridViewTextBoxColumn,
            this.Rakomany,
            this.RaklapFajta,
            this.Status,
            this.RaklapSuly,
            this.ZarasIdo,
            this.KiSzallNapja,
            this.Rakomanyido,
            this.Rendszam,
            this.Megjegyz1,
            this.Megjegyz2,
            this.Megjegyz3,
            this.Megjegyz4,
            this.raklapkezeloDataGridViewTextBoxColumn,
            this.Felhasznalo,
            this.mRendelesRDataGridViewTextBoxColumn,
            this.Munkahely,
            this.mennyisegDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.cikkszamDataGridViewTextBoxColumn,
            this.description1DataGridViewTextBoxColumn,
            this.description2DataGridViewTextBoxColumn,
            this.internRem1DataGridViewTextBoxColumn,
            this.custPONoDataGridViewTextBoxColumn,
            this.scalaszamDataGridViewTextBoxColumn,
            this.szallhetDataGridViewTextBoxColumn,
            this.kertHetDataGridViewTextBoxColumn,
            this.custCodeInvDataGridViewTextBoxColumn,
            this.csomFajtaDataGridViewTextBoxColumn,
            this.egysegDataGridViewTextBoxColumn,
            this.gyujtoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.raklapMRendelesekJelentBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 7F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 7F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1366, 637);
            this.dataGridView1.TabIndex = 0;
            // 
            // raklapRDataGridViewTextBoxColumn
            // 
            this.raklapRDataGridViewTextBoxColumn.DataPropertyName = "Raklap_R";
            this.raklapRDataGridViewTextBoxColumn.HeaderText = "Raklapkód";
            this.raklapRDataGridViewTextBoxColumn.Name = "raklapRDataGridViewTextBoxColumn";
            this.raklapRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Rakomany
            // 
            this.Rakomany.DataPropertyName = "Rakomany";
            this.Rakomany.HeaderText = "Rakomány";
            this.Rakomany.Name = "Rakomany";
            this.Rakomany.ReadOnly = true;
            // 
            // RaklapFajta
            // 
            this.RaklapFajta.DataPropertyName = "RaklapFajta";
            this.RaklapFajta.HeaderText = "Raklap Típusa";
            this.RaklapFajta.Name = "RaklapFajta";
            this.RaklapFajta.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Státusz";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 60;
            // 
            // RaklapSuly
            // 
            this.RaklapSuly.DataPropertyName = "RaklapSuly";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.RaklapSuly.DefaultCellStyle = dataGridViewCellStyle2;
            this.RaklapSuly.HeaderText = "Raklap Súly";
            this.RaklapSuly.Name = "RaklapSuly";
            this.RaklapSuly.ReadOnly = true;
            this.RaklapSuly.Width = 80;
            // 
            // ZarasIdo
            // 
            this.ZarasIdo.DataPropertyName = "ZarasIdo";
            this.ZarasIdo.HeaderText = "Zárás Idő";
            this.ZarasIdo.Name = "ZarasIdo";
            this.ZarasIdo.ReadOnly = true;
            // 
            // KiSzallNapja
            // 
            this.KiSzallNapja.DataPropertyName = "KiSzallNapja";
            this.KiSzallNapja.HeaderText = "KiSzáll. Napja";
            this.KiSzallNapja.Name = "KiSzallNapja";
            this.KiSzallNapja.ReadOnly = true;
            // 
            // Rakomanyido
            // 
            this.Rakomanyido.DataPropertyName = "Rakomanyido";
            this.Rakomanyido.HeaderText = "Rakományidő";
            this.Rakomanyido.Name = "Rakomanyido";
            this.Rakomanyido.ReadOnly = true;
            // 
            // Rendszam
            // 
            this.Rendszam.DataPropertyName = "Rendszam";
            this.Rendszam.HeaderText = "Rendszám";
            this.Rendszam.Name = "Rendszam";
            this.Rendszam.ReadOnly = true;
            // 
            // Megjegyz1
            // 
            this.Megjegyz1.DataPropertyName = "Megjegyz1";
            this.Megjegyz1.HeaderText = "Megjegyzés";
            this.Megjegyz1.Name = "Megjegyz1";
            this.Megjegyz1.ReadOnly = true;
            // 
            // Megjegyz2
            // 
            this.Megjegyz2.DataPropertyName = "Megjegyz2";
            this.Megjegyz2.HeaderText = "Megjegyzés";
            this.Megjegyz2.Name = "Megjegyz2";
            this.Megjegyz2.ReadOnly = true;
            // 
            // Megjegyz3
            // 
            this.Megjegyz3.DataPropertyName = "Megjegyz3";
            this.Megjegyz3.HeaderText = "Megjegyzés";
            this.Megjegyz3.Name = "Megjegyz3";
            this.Megjegyz3.ReadOnly = true;
            // 
            // Megjegyz4
            // 
            this.Megjegyz4.DataPropertyName = "Megjegyz4";
            this.Megjegyz4.HeaderText = "Megjegyzés";
            this.Megjegyz4.Name = "Megjegyz4";
            this.Megjegyz4.ReadOnly = true;
            // 
            // raklapkezeloDataGridViewTextBoxColumn
            // 
            this.raklapkezeloDataGridViewTextBoxColumn.DataPropertyName = "Raklapkezelo";
            this.raklapkezeloDataGridViewTextBoxColumn.HeaderText = "R.kezelő";
            this.raklapkezeloDataGridViewTextBoxColumn.Name = "raklapkezeloDataGridViewTextBoxColumn";
            this.raklapkezeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.raklapkezeloDataGridViewTextBoxColumn.Width = 80;
            // 
            // Felhasznalo
            // 
            this.Felhasznalo.DataPropertyName = "Felhasznalo";
            this.Felhasznalo.HeaderText = "R.ellenőr";
            this.Felhasznalo.Name = "Felhasznalo";
            this.Felhasznalo.ReadOnly = true;
            this.Felhasznalo.Width = 80;
            // 
            // mRendelesRDataGridViewTextBoxColumn
            // 
            this.mRendelesRDataGridViewTextBoxColumn.DataPropertyName = "MRendeles_R";
            this.mRendelesRDataGridViewTextBoxColumn.HeaderText = "Munkarendelés";
            this.mRendelesRDataGridViewTextBoxColumn.Name = "mRendelesRDataGridViewTextBoxColumn";
            this.mRendelesRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Munkahely
            // 
            this.Munkahely.DataPropertyName = "Munkahely";
            this.Munkahely.HeaderText = "Munkahely";
            this.Munkahely.Name = "Munkahely";
            this.Munkahely.ReadOnly = true;
            // 
            // mennyisegDataGridViewTextBoxColumn
            // 
            this.mennyisegDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.mennyisegDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mennyisegDataGridViewTextBoxColumn.HeaderText = "Mennyiség";
            this.mennyisegDataGridViewTextBoxColumn.Name = "mennyisegDataGridViewTextBoxColumn";
            this.mennyisegDataGridViewTextBoxColumn.ReadOnly = true;
            this.mennyisegDataGridViewTextBoxColumn.Width = 80;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "M.Egys.";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 60;
            // 
            // cikkszamDataGridViewTextBoxColumn
            // 
            this.cikkszamDataGridViewTextBoxColumn.DataPropertyName = "Cikkszam";
            this.cikkszamDataGridViewTextBoxColumn.HeaderText = "Cikkszám";
            this.cikkszamDataGridViewTextBoxColumn.Name = "cikkszamDataGridViewTextBoxColumn";
            this.cikkszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikkszamDataGridViewTextBoxColumn.Width = 120;
            // 
            // description1DataGridViewTextBoxColumn
            // 
            this.description1DataGridViewTextBoxColumn.DataPropertyName = "Description1";
            this.description1DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description1DataGridViewTextBoxColumn.Name = "description1DataGridViewTextBoxColumn";
            this.description1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // description2DataGridViewTextBoxColumn
            // 
            this.description2DataGridViewTextBoxColumn.DataPropertyName = "Description2";
            this.description2DataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.description2DataGridViewTextBoxColumn.Name = "description2DataGridViewTextBoxColumn";
            this.description2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internRem1DataGridViewTextBoxColumn
            // 
            this.internRem1DataGridViewTextBoxColumn.DataPropertyName = "InternRem1";
            this.internRem1DataGridViewTextBoxColumn.HeaderText = "Rajzszám";
            this.internRem1DataGridViewTextBoxColumn.Name = "internRem1DataGridViewTextBoxColumn";
            this.internRem1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custPONoDataGridViewTextBoxColumn
            // 
            this.custPONoDataGridViewTextBoxColumn.DataPropertyName = "CustPONo";
            this.custPONoDataGridViewTextBoxColumn.HeaderText = "Vevői.R.Szám";
            this.custPONoDataGridViewTextBoxColumn.Name = "custPONoDataGridViewTextBoxColumn";
            this.custPONoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scalaszamDataGridViewTextBoxColumn
            // 
            this.scalaszamDataGridViewTextBoxColumn.DataPropertyName = "Scalaszam";
            this.scalaszamDataGridViewTextBoxColumn.HeaderText = "Scalaszám";
            this.scalaszamDataGridViewTextBoxColumn.Name = "scalaszamDataGridViewTextBoxColumn";
            this.scalaszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szallhetDataGridViewTextBoxColumn
            // 
            this.szallhetDataGridViewTextBoxColumn.DataPropertyName = "Szallhet";
            this.szallhetDataGridViewTextBoxColumn.HeaderText = "Szállhét";
            this.szallhetDataGridViewTextBoxColumn.Name = "szallhetDataGridViewTextBoxColumn";
            this.szallhetDataGridViewTextBoxColumn.ReadOnly = true;
            this.szallhetDataGridViewTextBoxColumn.Width = 80;
            // 
            // kertHetDataGridViewTextBoxColumn
            // 
            this.kertHetDataGridViewTextBoxColumn.DataPropertyName = "KertHet";
            this.kertHetDataGridViewTextBoxColumn.HeaderText = "KértHét";
            this.kertHetDataGridViewTextBoxColumn.Name = "kertHetDataGridViewTextBoxColumn";
            this.kertHetDataGridViewTextBoxColumn.ReadOnly = true;
            this.kertHetDataGridViewTextBoxColumn.Width = 80;
            // 
            // custCodeInvDataGridViewTextBoxColumn
            // 
            this.custCodeInvDataGridViewTextBoxColumn.DataPropertyName = "CustCodeInv";
            this.custCodeInvDataGridViewTextBoxColumn.HeaderText = "Vevő";
            this.custCodeInvDataGridViewTextBoxColumn.Name = "custCodeInvDataGridViewTextBoxColumn";
            this.custCodeInvDataGridViewTextBoxColumn.ReadOnly = true;
            this.custCodeInvDataGridViewTextBoxColumn.Width = 60;
            // 
            // csomFajtaDataGridViewTextBoxColumn
            // 
            this.csomFajtaDataGridViewTextBoxColumn.DataPropertyName = "CsomFajta";
            this.csomFajtaDataGridViewTextBoxColumn.HeaderText = "Csom. Fajta";
            this.csomFajtaDataGridViewTextBoxColumn.Name = "csomFajtaDataGridViewTextBoxColumn";
            this.csomFajtaDataGridViewTextBoxColumn.ReadOnly = true;
            this.csomFajtaDataGridViewTextBoxColumn.Width = 60;
            // 
            // egysegDataGridViewTextBoxColumn
            // 
            this.egysegDataGridViewTextBoxColumn.DataPropertyName = "Egyseg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.egysegDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.egysegDataGridViewTextBoxColumn.HeaderText = "Egység Csom.";
            this.egysegDataGridViewTextBoxColumn.Name = "egysegDataGridViewTextBoxColumn";
            this.egysegDataGridViewTextBoxColumn.ReadOnly = true;
            this.egysegDataGridViewTextBoxColumn.Width = 80;
            // 
            // gyujtoDataGridViewTextBoxColumn
            // 
            this.gyujtoDataGridViewTextBoxColumn.DataPropertyName = "Gyujto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.gyujtoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.gyujtoDataGridViewTextBoxColumn.HeaderText = "Gyűjtő Csom.";
            this.gyujtoDataGridViewTextBoxColumn.Name = "gyujtoDataGridViewTextBoxColumn";
            this.gyujtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.gyujtoDataGridViewTextBoxColumn.Width = 80;
            // 
            // raklapMRendelesekJelentBindingSource
            // 
            this.raklapMRendelesekJelentBindingSource.DataMember = "Raklap_MRendelesek_Jelent";
            this.raklapMRendelesekJelentBindingSource.DataSource = this.dataSet15;
            // 
            // dataSet15
            // 
            this.dataSet15.DataSetName = "DataSet15";
            this.dataSet15.EnforceConstraints = false;
            this.dataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1366, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(98, 36);
            this.toolStripButton1.Text = "Frissítés";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(89, 36);
            this.toolStripButton2.Text = "Kilépés";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // raklap_MRendelesek_JelentTableAdapter
            // 
            this.raklap_MRendelesek_JelentTableAdapter.ClearBeforeFill = true;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 676);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "Kimenő Szállítmányok";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raklapMRendelesekJelentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet15 dataSet15;
        private System.Windows.Forms.BindingSource raklapMRendelesekJelentBindingSource;
        private DataSet15TableAdapters.Raklap_MRendelesek_JelentTableAdapter raklap_MRendelesek_JelentTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn munkahelyRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raklapRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rakomany;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaklapFajta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaklapSuly;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZarasIdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiSzallNapja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rakomanyido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megjegyz1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megjegyz2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megjegyz3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megjegyz4;
        private System.Windows.Forms.DataGridViewTextBoxColumn raklapkezeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Felhasznalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRendelesRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Munkahely;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyisegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikkszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn description2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internRem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custPONoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scalaszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallhetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kertHetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCodeInvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csomFajtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egysegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyujtoDataGridViewTextBoxColumn;
    }
}