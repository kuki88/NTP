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
            this.posudbaBtn = new System.Windows.Forms.Button();
            this.bkategorijaCombo = new System.Windows.Forms.ComboBox();
            this.pAutorTxt = new System.Windows.Forms.TextBox();
            this.clanskiBrTxt = new System.Windows.Forms.TextBox();
            this.kolicinaTxt = new System.Windows.Forms.TextBox();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.pnazivTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.knjigeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knjiznicaManagementDataSet = new NtpProjekt.KnjiznicaManagementDataSet();
            this.knjiznicaManagementDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.groupBox1.Controls.Add(this.pretragaBtn);
            this.groupBox1.Controls.Add(this.kkategorijaCombo);
            this.groupBox1.Controls.Add(this.knazivTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(637, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // pretragaBtn
            // 
            this.pretragaBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pretragaBtn.Location = new System.Drawing.Point(3, 230);
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
            this.knjigeGrid.Size = new System.Drawing.Size(965, 282);
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
            this.groupBox2.Controls.Add(this.posudbaBtn);
            this.groupBox2.Controls.Add(this.bkategorijaCombo);
            this.groupBox2.Controls.Add(this.pAutorTxt);
            this.groupBox2.Controls.Add(this.clanskiBrTxt);
            this.groupBox2.Controls.Add(this.kolicinaTxt);
            this.groupBox2.Controls.Add(this.isbnTxt);
            this.groupBox2.Controls.Add(this.pnazivTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 278);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Posudba";
            // 
            // posudbaBtn
            // 
            this.posudbaBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.posudbaBtn.Location = new System.Drawing.Point(3, 233);
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
            this.bkategorijaCombo.Location = new System.Drawing.Point(138, 81);
            this.bkategorijaCombo.Name = "bkategorijaCombo";
            this.bkategorijaCombo.Size = new System.Drawing.Size(181, 21);
            this.bkategorijaCombo.TabIndex = 2;
            // 
            // pAutorTxt
            // 
            this.pAutorTxt.Location = new System.Drawing.Point(423, 123);
            this.pAutorTxt.Name = "pAutorTxt";
            this.pAutorTxt.Size = new System.Drawing.Size(181, 20);
            this.pAutorTxt.TabIndex = 1;
            // 
            // clanskiBrTxt
            // 
            this.clanskiBrTxt.Location = new System.Drawing.Point(423, 74);
            this.clanskiBrTxt.Name = "clanskiBrTxt";
            this.clanskiBrTxt.Size = new System.Drawing.Size(181, 20);
            this.clanskiBrTxt.TabIndex = 1;
            // 
            // kolicinaTxt
            // 
            this.kolicinaTxt.Location = new System.Drawing.Point(138, 135);
            this.kolicinaTxt.Name = "kolicinaTxt";
            this.kolicinaTxt.Size = new System.Drawing.Size(25, 20);
            this.kolicinaTxt.TabIndex = 1;
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(423, 28);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(181, 20);
            this.isbnTxt.TabIndex = 1;
            // 
            // pnazivTxt
            // 
            this.pnazivTxt.Location = new System.Drawing.Point(138, 28);
            this.pnazivTxt.Name = "pnazivTxt";
            this.pnazivTxt.Size = new System.Drawing.Size(181, 20);
            this.pnazivTxt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategorija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Članski broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dostupna količina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ISBN Knjige";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
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
            // PosudbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 590);
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
        private System.Windows.Forms.TextBox clanskiBrTxt;
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
    }
}