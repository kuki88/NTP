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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosudbaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPdf = new System.Windows.Forms.Button();
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
            this.knjiznicaManagementDataSet = new NtpProjekt.KnjiznicaManagementDataSet();
            this.knjiznicaManagementDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.knjigeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjigeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnPdf);
            this.groupBox1.Controls.Add(this.btnShowSveKnjigeReport);
            this.groupBox1.Controls.Add(this.pretragaBtn);
            this.groupBox1.Controls.Add(this.kkategorijaCombo);
            this.groupBox1.Controls.Add(this.knazivTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnPdf
            // 
            resources.ApplyResources(this.btnPdf, "btnPdf");
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnShowSveKnjigeReport
            // 
            resources.ApplyResources(this.btnShowSveKnjigeReport, "btnShowSveKnjigeReport");
            this.btnShowSveKnjigeReport.Name = "btnShowSveKnjigeReport";
            this.btnShowSveKnjigeReport.UseVisualStyleBackColor = true;
            this.btnShowSveKnjigeReport.Click += new System.EventHandler(this.btnShowSveKnjigeReport_Click);
            // 
            // pretragaBtn
            // 
            resources.ApplyResources(this.pretragaBtn, "pretragaBtn");
            this.pretragaBtn.Name = "pretragaBtn";
            this.pretragaBtn.UseVisualStyleBackColor = true;
            this.pretragaBtn.Click += new System.EventHandler(this.pretragaBtn_Click);
            // 
            // kkategorijaCombo
            // 
            resources.ApplyResources(this.kkategorijaCombo, "kkategorijaCombo");
            this.kkategorijaCombo.FormattingEnabled = true;
            this.kkategorijaCombo.Name = "kkategorijaCombo";
            // 
            // knazivTxt
            // 
            resources.ApplyResources(this.knazivTxt, "knazivTxt");
            this.knazivTxt.Name = "knazivTxt";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // knjigeGrid
            // 
            resources.ApplyResources(this.knjigeGrid, "knjigeGrid");
            this.knjigeGrid.AllowUserToAddRows = false;
            this.knjigeGrid.AllowUserToDeleteRows = false;
            this.knjigeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.knjigeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Naziv,
            this.Autor,
            this.Kategorija,
            this.Količina});
            this.knjigeGrid.Name = "knjigeGrid";
            this.knjigeGrid.ReadOnly = true;
            this.knjigeGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            resources.ApplyResources(this.ISBN, "ISBN");
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "NazivKnjige";
            resources.ApplyResources(this.Naziv, "Naziv");
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.DataPropertyName = "Autor";
            resources.ApplyResources(this.Autor, "Autor");
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            resources.ApplyResources(this.Kategorija, "Kategorija");
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.DataPropertyName = "Količina";
            resources.ApplyResources(this.Količina, "Količina");
            this.Količina.Name = "Količina";
            this.Količina.ReadOnly = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // posudbeReportBtn
            // 
            resources.ApplyResources(this.posudbeReportBtn, "posudbeReportBtn");
            this.posudbeReportBtn.Name = "posudbeReportBtn";
            this.posudbeReportBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvoClanskiTxt
            // 
            resources.ApplyResources(this.dvoClanskiTxt, "dvoClanskiTxt");
            this.dvoClanskiTxt.Name = "dvoClanskiTxt";
            this.dvoClanskiTxt.TextChanged += new System.EventHandler(this.dvoClanskiTxt_TextChanged);
            // 
            // dClanskiTxt
            // 
            resources.ApplyResources(this.dClanskiTxt, "dClanskiTxt");
            this.dClanskiTxt.Name = "dClanskiTxt";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // posudbaBtn
            // 
            resources.ApplyResources(this.posudbaBtn, "posudbaBtn");
            this.posudbaBtn.Name = "posudbaBtn";
            this.posudbaBtn.UseVisualStyleBackColor = true;
            this.posudbaBtn.Click += new System.EventHandler(this.posudbaBtn_Click);
            // 
            // bkategorijaCombo
            // 
            resources.ApplyResources(this.bkategorijaCombo, "bkategorijaCombo");
            this.bkategorijaCombo.FormattingEnabled = true;
            this.bkategorijaCombo.Name = "bkategorijaCombo";
            // 
            // pAutorTxt
            // 
            resources.ApplyResources(this.pAutorTxt, "pAutorTxt");
            this.pAutorTxt.Name = "pAutorTxt";
            // 
            // kolicinaTxt
            // 
            resources.ApplyResources(this.kolicinaTxt, "kolicinaTxt");
            this.kolicinaTxt.Name = "kolicinaTxt";
            // 
            // isbnTxt
            // 
            resources.ApplyResources(this.isbnTxt, "isbnTxt");
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.TextChanged += new System.EventHandler(this.isbnTxt_TextChanged);
            // 
            // cTelTxt
            // 
            resources.ApplyResources(this.cTelTxt, "cTelTxt");
            this.cTelTxt.Name = "cTelTxt";
            // 
            // cPrezimeTxt
            // 
            resources.ApplyResources(this.cPrezimeTxt, "cPrezimeTxt");
            this.cPrezimeTxt.Name = "cPrezimeTxt";
            // 
            // cImeTxt
            // 
            resources.ApplyResources(this.cImeTxt, "cImeTxt");
            this.cImeTxt.Name = "cImeTxt";
            // 
            // pnazivTxt
            // 
            resources.ApplyResources(this.pnazivTxt, "pnazivTxt");
            this.pnazivTxt.Name = "pnazivTxt";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // knjigeBindingSource
            // 
            this.knjigeBindingSource.DataMember = "Knjige";
            // 
            // knjigeBindingSource1
            // 
            this.knjigeBindingSource1.DataMember = "Knjige";
            // 
            // PosudbaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.knjigeGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "PosudbaForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjigeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knjiznicaManagementDataSet1BindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
    }
}