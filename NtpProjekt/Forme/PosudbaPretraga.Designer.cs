namespace NtpProjekt
{
    partial class PosudbaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowSveKnjigeReport = new System.Windows.Forms.Button();
            this.pretragaBtn = new System.Windows.Forms.Button();
            this.kkategorijaCombo = new System.Windows.Forms.ComboBox();
            this.knazivTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.knjigeGrid = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.posudbeReportBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dvoClanskiTxt = new System.Windows.Forms.TextBox();
            this.dClanskiTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.posudbaBtn = new System.Windows.Forms.Button();
            this.bkategorijaCombo = new System.Windows.Forms.ComboBox();
            this.pAutorTxt = new System.Windows.Forms.TextBox();
            this.kolicinaTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.cTelTxt = new System.Windows.Forms.TextBox();
            this.cPrezimeTxt = new System.Windows.Forms.TextBox();
            this.cImeTxt = new System.Windows.Forms.TextBox();
            this.pnazivTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.knjigeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSet = new NtpProjekt.KnjiznicaManagementDataSet();
            this.knjiznicaManagementDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPdf);
            this.groupBox1.Controls.Add(this.btnShowSveKnjigeReport);
            this.groupBox1.Controls.Add(this.pretragaBtn);
            this.groupBox1.Controls.Add(this.kkategorijaCombo);
            this.groupBox1.Controls.Add(this.knazivTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(637, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // btnShowSveKnjigeReport
            // 
            this.btnShowSveKnjigeReport.Location = new System.Drawing.Point(3, 228);
            this.btnShowSveKnjigeReport.Name = "btnShowSveKnjigeReport";
            this.btnShowSveKnjigeReport.Size = new System.Drawing.Size(167, 42);
            this.btnShowSveKnjigeReport.TabIndex = 4;
            this.btnShowSveKnjigeReport.Text = "Sve knjige";
            this.btnShowSveKnjigeReport.UseVisualStyleBackColor = true;
            this.btnShowSveKnjigeReport.Click += new System.EventHandler(this.btnShowSveKnjigeReport_Click);
            // 
            // pretragaBtn
            // 
            this.pretragaBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pretragaBtn.Location = new System.Drawing.Point(3, 270);
            this.pretragaBtn.Name = "pretragaBtn";
            this.pretragaBtn.Size = new System.Drawing.Size(334, 42);
            this.pretragaBtn.TabIndex = 3;
            this.pretragaBtn.Text = "Traži";
            this.pretragaBtn.UseVisualStyleBackColor = true;
            this.pretragaBtn.Click += new System.EventHandler(this.pretragaBtn_Click);
            // 
            // kkategorijaCombo
            // 
            this.kkategorijaCombo.FormattingEnabled = true;
            this.kkategorijaCombo.Location = new System.Drawing.Point(77, 119);
            this.kkategorijaCombo.Name = "kkategorijaCombo";
            this.kkategorijaCombo.Size = new System.Drawing.Size(181, 21);
            this.kkategorijaCombo.TabIndex = 2;
            // 
            // knazivTxt
            // 
            this.knazivTxt.Location = new System.Drawing.Point(77, 28);
            this.knazivTxt.Name = "knazivTxt";
            this.knazivTxt.Size = new System.Drawing.Size(181, 20);
            this.knazivTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategorija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv knjige";
            // 
            // knjigeGrid
            // 
            this.knjigeGrid.AllowUserToAddRows = false;
            this.knjigeGrid.AllowUserToDeleteRows = false;
            this.knjigeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.knjigeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knjigeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Naziv,
            this.Autor,
            this.Kategorija,
            this.Količina});
            this.knjigeGrid.Location = new System.Drawing.Point(12, 12);
            this.knjigeGrid.Name = "knjigeGrid";
            this.knjigeGrid.ReadOnly = true;
            this.knjigeGrid.Size = new System.Drawing.Size(966, 282);
            this.knjigeGrid.TabIndex = 1;
            this.knjigeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "NazivKnjige";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "Količina";
            this.Količina.HeaderText = "Količina";
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            // 
            // knjigeBindingSource
            // 
            this.knjigeBindingSource.DataMember = "Knjige";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.posudbeReportBtn);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dvoClanskiTxt);
            this.groupBox2.Controls.Add(this.dClanskiTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.posudbaBtn);
            this.groupBox2.Controls.Add(this.bkategorijaCombo);
            this.groupBox2.Controls.Add(this.pAutorTxt);
            this.groupBox2.Controls.Add(this.kolicinaTxt);
            this.groupBox2.Controls.Add(this.isbnTxt);
            this.groupBox2.Controls.Add(this.cTelTxt);
            this.groupBox2.Controls.Add(this.cPrezimeTxt);
            this.groupBox2.Controls.Add(this.cImeTxt);
            this.groupBox2.Controls.Add(this.pnazivTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 315);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posudba";
            // 
            // posudbeReportBtn
            // 
            this.posudbeReportBtn.Location = new System.Drawing.Point(410, 228);
            this.posudbeReportBtn.Name = "posudbeReportBtn";
            this.posudbeReportBtn.Size = new System.Drawing.Size(195, 36);
            this.posudbeReportBtn.TabIndex = 8;
            this.posudbeReportBtn.Text = "Posudbe od člana";
            this.posudbeReportBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 20);
            this.button2.TabIndex = 7;
            this.button2.Text = "Očisti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Traži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvoClanskiTxt
            // 
            this.dvoClanskiTxt.Location = new System.Drawing.Point(410, 40);
            this.dvoClanskiTxt.MaxLength = 2;
            this.dvoClanskiTxt.Name = "dvoClanskiTxt";
            this.dvoClanskiTxt.Size = new System.Drawing.Size(35, 20);
            this.dvoClanskiTxt.TabIndex = 4;
            this.dvoClanskiTxt.TextChanged += new System.EventHandler(this.dvoClanskiTxt_TextChanged);
            // 
            // dClanskiTxt
            // 
            this.dClanskiTxt.Location = new System.Drawing.Point(471, 40);
            this.dClanskiTxt.MaxLength = 6;
            this.dClanskiTxt.Name = "dClanskiTxt";
            this.dClanskiTxt.Size = new System.Drawing.Size(134, 20);
            this.dClanskiTxt.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "/";
            // 
            // posudbaBtn
            // 
            this.posudbaBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.posudbaBtn.Location = new System.Drawing.Point(3, 270);
            this.posudbaBtn.Name = "posudbaBtn";
            this.posudbaBtn.Size = new System.Drawing.Size(605, 42);
            this.posudbaBtn.TabIndex = 3;
            this.posudbaBtn.Text = "Posudi";
            this.posudbaBtn.UseVisualStyleBackColor = true;
            this.posudbaBtn.Click += new System.EventHandler(this.posudbaBtn_Click);
            // 
            // bkategorijaCombo
            // 
            this.bkategorijaCombo.FormattingEnabled = true;
            this.bkategorijaCombo.Location = new System.Drawing.Point(6, 90);
            this.bkategorijaCombo.Name = "bkategorijaCombo";
            this.bkategorijaCombo.Size = new System.Drawing.Size(181, 21);
            this.bkategorijaCombo.TabIndex = 2;
            // 
            // pAutorTxt
            // 
            this.pAutorTxt.Location = new System.Drawing.Point(6, 194);
            this.pAutorTxt.Name = "pAutorTxt";
            this.pAutorTxt.Size = new System.Drawing.Size(181, 20);
            this.pAutorTxt.TabIndex = 1;
            // 
            // kolicinaTxt
            // 
            this.kolicinaTxt.Location = new System.Drawing.Point(193, 37);
            this.kolicinaTxt.Name = "kolicinaTxt";
            this.kolicinaTxt.Size = new System.Drawing.Size(25, 20);
            this.kolicinaTxt.TabIndex = 1;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(6, 141);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(181, 20);
            this.isbnTxt.TabIndex = 1;
            this.isbnTxt.TextChanged += new System.EventHandler(this.isbnTxt_TextChanged);
            // 
            // cTelTxt
            // 
            this.cTelTxt.Location = new System.Drawing.Point(410, 194);
            this.cTelTxt.Name = "cTelTxt";
            this.cTelTxt.Size = new System.Drawing.Size(195, 20);
            this.cTelTxt.TabIndex = 1;
            // 
            // cPrezimeTxt
            // 
            this.cPrezimeTxt.Location = new System.Drawing.Point(410, 141);
            this.cPrezimeTxt.Name = "cPrezimeTxt";
            this.cPrezimeTxt.Size = new System.Drawing.Size(195, 20);
            this.cPrezimeTxt.TabIndex = 1;
            // 
            // cImeTxt
            // 
            this.cImeTxt.Location = new System.Drawing.Point(410, 91);
            this.cImeTxt.Name = "cImeTxt";
            this.cImeTxt.Size = new System.Drawing.Size(195, 20);
            this.cImeTxt.TabIndex = 1;
            // 
            // pnazivTxt
            // 
            this.pnazivTxt.Location = new System.Drawing.Point(6, 37);
            this.pnazivTxt.Name = "pnazivTxt";
            this.pnazivTxt.Size = new System.Drawing.Size(181, 20);
            this.pnazivTxt.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(407, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Autor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategorija";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Članski broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dostupna količina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ISBN Knjige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Naziv knjige";
            // 
            // knjigeBindingSource1
            // 
            this.knjigeBindingSource1.DataMember = "Knjige";
            // 
            // knjiznicaManagementDataSet
            // 
            this.knjiznicaManagementDataSet.DataSetName = "KnjiznicaManagementDataSet";
            this.knjiznicaManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // knjiznicaManagementDataSetBindingSource1
            // 
            this.knjiznicaManagementDataSetBindingSource1.DataSource = this.knjiznicaManagementDataSet;
            this.knjiznicaManagementDataSetBindingSource1.Position = 0;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(170, 228);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(167, 42);
            this.btnPdf.TabIndex = 4;
            this.btnPdf.Text = "Export PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // PosudbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.knjigeGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "PosudbaForm";
            this.Text = "Posudba";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pretragaBtn;
        private System.Windows.Forms.ComboBox kkategorijaCombo;
        private System.Windows.Forms.TextBox knazivTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView knjigeGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button posudbaBtn;
        private System.Windows.Forms.ComboBox bkategorijaCombo;
        private System.Windows.Forms.TextBox kolicinaTxt;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.TextBox pnazivTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource knjigeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivKnjigeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn količinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource knjigeBindingSource1;
        private System.Windows.Forms.BindingSource knjiznicaManagementDataSetBindingSource;
        private System.Windows.Forms.BindingSource knjiznicaManagementDataSet1BindingSource;
        private KnjiznicaManagementDataSet knjiznicaManagementDataSet;
        private System.Windows.Forms.BindingSource knjiznicaManagementDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
        private System.Windows.Forms.TextBox pAutorTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dvoClanskiTxt;
        private System.Windows.Forms.TextBox dClanskiTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cTelTxt;
        private System.Windows.Forms.TextBox cPrezimeTxt;
        private System.Windows.Forms.TextBox cImeTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button posudbeReportBtn;
        private System.Windows.Forms.Button btnShowSveKnjigeReport;
        private System.Windows.Forms.Button btnPdf;
    }
}