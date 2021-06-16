namespace CikkLekérdezés
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vFSC230300WarehouseInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet131 = new CikkLekérdezés.DataSet13();
            this.dataSet13BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet13 = new CikkLekérdezés.DataSet13();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vF_SC010300_StockfileTableAdapter = new CikkLekérdezés.DataSet13TableAdapters.VF_SC010300_StockfileTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdCostPric1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InternRem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InternRem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egysegmegn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.vF_SC230300_WarehouseInfoTableAdapter = new CikkLekérdezés.DataSet13TableAdapters.VF_SC230300_WarehouseInfoTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.VF_SC360300_StockBinNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vF_SC360300_StockBinNoTableAdapter = new CikkLekérdezés.DataSet13TableAdapters.VF_SC360300_StockBinNoTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vFSC230300WarehouseInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet131)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VF_SC360300_StockBinNoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cikkszám  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(63, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raktár  :";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vFSC230300WarehouseInfoBindingSource;
            this.comboBox1.DisplayMember = "Megnev";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(217, 114);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Megnev";
            // 
            // vFSC230300WarehouseInfoBindingSource
            // 
            this.vFSC230300WarehouseInfoBindingSource.DataMember = "VF_SC230300_WarehouseInfo";
            this.vFSC230300WarehouseInfoBindingSource.DataSource = this.dataSet131;
            // 
            // dataSet131
            // 
            this.dataSet131.DataSetName = "DataSet13";
            this.dataSet131.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet13BindingSource
            // 
            this.dataSet13BindingSource.DataMember = "VF_SC010300_Stockfile";
            this.dataSet13BindingSource.DataSource = this.dataSet13;
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet13";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mennyiség :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(217, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 23);
            this.textBox3.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Módosítás oka  :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(217, 247);
            this.textBox4.MaxLength = 250;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(420, 92);
            this.textBox4.TabIndex = 20;
            // 
            // vF_SC010300_StockfileTableAdapter
            // 
            this.vF_SC010300_StockfileTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet13BindingSource, "Description1", true));
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(214, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockCodeDataGridViewTextBoxColumn,
            this.Description1,
            this.Description2,
            this.StdCostPric1,
            this.InternRem1,
            this.InternRem2,
            this.Egysegmegn});
            this.dataGridView1.DataSource = this.dataSet13BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(411, 97);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.Visible = false;
            // 
            // stockCodeDataGridViewTextBoxColumn
            // 
            this.stockCodeDataGridViewTextBoxColumn.DataPropertyName = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.HeaderText = "StockCode";
            this.stockCodeDataGridViewTextBoxColumn.Name = "stockCodeDataGridViewTextBoxColumn";
            this.stockCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Description1
            // 
            this.Description1.DataPropertyName = "Description1";
            this.Description1.HeaderText = "Description1";
            this.Description1.Name = "Description1";
            this.Description1.ReadOnly = true;
            // 
            // Description2
            // 
            this.Description2.DataPropertyName = "Description2";
            this.Description2.HeaderText = "Description2";
            this.Description2.Name = "Description2";
            this.Description2.ReadOnly = true;
            // 
            // StdCostPric1
            // 
            this.StdCostPric1.DataPropertyName = "StdCostPric1";
            this.StdCostPric1.HeaderText = "StdCostPric1";
            this.StdCostPric1.Name = "StdCostPric1";
            this.StdCostPric1.ReadOnly = true;
            // 
            // InternRem1
            // 
            this.InternRem1.DataPropertyName = "InternRem1";
            this.InternRem1.HeaderText = "InternRem1";
            this.InternRem1.Name = "InternRem1";
            this.InternRem1.ReadOnly = true;
            // 
            // InternRem2
            // 
            this.InternRem2.DataPropertyName = "InternRem2";
            this.InternRem2.HeaderText = "InternRem2";
            this.InternRem2.Name = "InternRem2";
            this.InternRem2.ReadOnly = true;
            // 
            // Egysegmegn
            // 
            this.Egysegmegn.DataPropertyName = "Description";
            this.Egysegmegn.HeaderText = "Description";
            this.Egysegmegn.Name = "Egysegmegn";
            this.Egysegmegn.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Megnevezés :";
            // 
            // vF_SC230300_WarehouseInfoTableAdapter
            // 
            this.vF_SC230300_WarehouseInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(395, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(480, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pozitív mennyiség esetén készlet növelés";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(480, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Negatív mennyiség esetén készlet csökkenés";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 31);
            this.button1.TabIndex = 35;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 30);
            this.button2.TabIndex = 40;
            this.button2.Text = "Kilépés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kérelmező :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(217, 371);
            this.textBox8.MaxLength = 250;
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(420, 89);
            this.textBox8.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Javító intézkedések :";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(217, 491);
            this.textBox12.MaxLength = 50;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(429, 23);
            this.textBox12.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(71, 600);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(234, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "* Minden cella kitöltése kötelező !";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox13.Location = new System.Drawing.Point(66, 247);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(115, 52);
            this.textBox13.TabIndex = 36;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "(Mikor, hol, miért keletkezett az eltérés)";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox14.Location = new System.Drawing.Point(66, 396);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(85, 14);
            this.textBox14.TabIndex = 37;
            this.textBox14.TabStop = false;
            this.textBox14.Text = "(Akció terv)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(561, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(85, 14);
            this.textBox2.TabIndex = 38;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Kilépés Esc";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(561, 355);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(85, 14);
            this.textBox5.TabIndex = 39;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Kilépés Esc";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(217, 157);
            this.textBox6.MaxLength = 10;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(160, 23);
            this.textBox6.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 160);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Polc :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 30);
            this.button3.TabIndex = 35;
            this.button3.Text = "Mégsem";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VF_SC360300_StockBinNoBindingSource
            // 
            this.VF_SC360300_StockBinNoBindingSource.DataMember = "VF_SC360300_StockBinNo";
            this.VF_SC360300_StockBinNoBindingSource.DataSource = this.dataSet131;
            // 
            // vF_SC360300_StockBinNoTableAdapter
            // 
            this.vF_SC360300_StockBinNoTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(678, 409);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 16);
            this.label14.TabIndex = 35;
            this.label14.Text = "Következő mező ESC segítségével.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(678, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Következő mező ESC segítségével.";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1070, 632);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form12";
            this.Text = "Készlet módosítás kérés";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vFSC230300WarehouseInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet131)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VF_SC360300_StockBinNoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dataSet13BindingSource;
        private DataSet13 dataSet13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private DataSet13TableAdapters.VF_SC010300_StockfileTableAdapter vF_SC010300_StockfileTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private DataSet13 dataSet131;
        private System.Windows.Forms.BindingSource vFSC230300WarehouseInfoBindingSource;
        private DataSet13TableAdapters.VF_SC230300_WarehouseInfoTableAdapter vF_SC230300_WarehouseInfoTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdCostPric1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InternRem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InternRem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egysegmegn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource VF_SC360300_StockBinNoBindingSource;
        private DataSet13TableAdapters.VF_SC360300_StockBinNoTableAdapter vF_SC360300_StockBinNoTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}