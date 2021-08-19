namespace NtpProjekt.Forme
{
    partial class KnjigeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dKolicinaNumeric = new System.Windows.Forms.NumericUpDown();
            this.dKategorijaCombo = new System.Windows.Forms.ComboBox();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dAutorTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dNazivTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dIsbnTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uKolicinaNumeric = new System.Windows.Forms.NumericUpDown();
            this.traziBtn = new System.Windows.Forms.Button();
            this.ukloniBtn = new System.Windows.Forms.Button();
            this.uDostupnaTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uAutorTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ukategorijaTxt = new System.Windows.Forms.TextBox();
            this.uNazivTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uIsbnTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dKolicinaNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uKolicinaNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dKolicinaNumeric);
            this.groupBox1.Controls.Add(this.dKategorijaCombo);
            this.groupBox1.Controls.Add(this.DodajBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dAutorTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dNazivTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dIsbnTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj knjigu";
            // 
            // dKolicinaNumeric
            // 
            this.dKolicinaNumeric.Location = new System.Drawing.Point(132, 132);
            this.dKolicinaNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.dKolicinaNumeric.Name = "dKolicinaNumeric";
            this.dKolicinaNumeric.Size = new System.Drawing.Size(194, 20);
            this.dKolicinaNumeric.TabIndex = 3;
            // 
            // dKategorijaCombo
            // 
            this.dKategorijaCombo.FormattingEnabled = true;
            this.dKategorijaCombo.Location = new System.Drawing.Point(132, 98);
            this.dKategorijaCombo.Name = "dKategorijaCombo";
            this.dKategorijaCombo.Size = new System.Drawing.Size(194, 21);
            this.dKategorijaCombo.TabIndex = 3;
            // 
            // DodajBtn
            // 
            this.DodajBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DodajBtn.Location = new System.Drawing.Point(3, 215);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(326, 38);
            this.DodajBtn.TabIndex = 2;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = true;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Količina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategorija";
            // 
            // dAutorTxt
            // 
            this.dAutorTxt.Location = new System.Drawing.Point(132, 167);
            this.dAutorTxt.Name = "dAutorTxt";
            this.dAutorTxt.Size = new System.Drawing.Size(194, 20);
            this.dAutorTxt.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Autor";
            // 
            // dNazivTxt
            // 
            this.dNazivTxt.Location = new System.Drawing.Point(132, 64);
            this.dNazivTxt.Name = "dNazivTxt";
            this.dNazivTxt.Size = new System.Drawing.Size(194, 20);
            this.dNazivTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv";
            // 
            // dIsbnTxt
            // 
            this.dIsbnTxt.Location = new System.Drawing.Point(132, 28);
            this.dIsbnTxt.Name = "dIsbnTxt";
            this.dIsbnTxt.Size = new System.Drawing.Size(194, 20);
            this.dIsbnTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uKolicinaNumeric);
            this.groupBox2.Controls.Add(this.traziBtn);
            this.groupBox2.Controls.Add(this.ukloniBtn);
            this.groupBox2.Controls.Add(this.uDostupnaTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.uAutorTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ukategorijaTxt);
            this.groupBox2.Controls.Add(this.uNazivTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.uIsbnTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 283);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ukloni knjigu";
            // 
            // uKolicinaNumeric
            // 
            this.uKolicinaNumeric.Location = new System.Drawing.Point(132, 134);
            this.uKolicinaNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.uKolicinaNumeric.Name = "uKolicinaNumeric";
            this.uKolicinaNumeric.Size = new System.Drawing.Size(194, 20);
            this.uKolicinaNumeric.TabIndex = 3;
            // 
            // traziBtn
            // 
            this.traziBtn.Location = new System.Drawing.Point(243, 28);
            this.traziBtn.Name = "traziBtn";
            this.traziBtn.Size = new System.Drawing.Size(75, 20);
            this.traziBtn.TabIndex = 4;
            this.traziBtn.Text = "Traži";
            this.traziBtn.UseVisualStyleBackColor = true;
            this.traziBtn.Click += new System.EventHandler(this.traziBtn_Click);
            // 
            // ukloniBtn
            // 
            this.ukloniBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ukloniBtn.Location = new System.Drawing.Point(3, 242);
            this.ukloniBtn.Name = "ukloniBtn";
            this.ukloniBtn.Size = new System.Drawing.Size(326, 38);
            this.ukloniBtn.TabIndex = 2;
            this.ukloniBtn.Text = "Ukloni";
            this.ukloniBtn.UseVisualStyleBackColor = true;
            this.ukloniBtn.Click += new System.EventHandler(this.ukloniBtn_Click);
            // 
            // uDostupnaTxt
            // 
            this.uDostupnaTxt.Location = new System.Drawing.Point(132, 168);
            this.uDostupnaTxt.Name = "uDostupnaTxt";
            this.uDostupnaTxt.Size = new System.Drawing.Size(194, 20);
            this.uDostupnaTxt.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Dostupna Količina";
            // 
            // uAutorTxt
            // 
            this.uAutorTxt.Location = new System.Drawing.Point(132, 204);
            this.uAutorTxt.Name = "uAutorTxt";
            this.uAutorTxt.Size = new System.Drawing.Size(194, 20);
            this.uAutorTxt.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Količina";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kategorija";
            // 
            // ukategorijaTxt
            // 
            this.ukategorijaTxt.Location = new System.Drawing.Point(132, 98);
            this.ukategorijaTxt.Name = "ukategorijaTxt";
            this.ukategorijaTxt.Size = new System.Drawing.Size(194, 20);
            this.ukategorijaTxt.TabIndex = 1;
            this.ukategorijaTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uNazivTxt
            // 
            this.uNazivTxt.Location = new System.Drawing.Point(132, 64);
            this.uNazivTxt.Name = "uNazivTxt";
            this.uNazivTxt.Size = new System.Drawing.Size(194, 20);
            this.uNazivTxt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Naziv";
            // 
            // uIsbnTxt
            // 
            this.uIsbnTxt.Location = new System.Drawing.Point(132, 28);
            this.uIsbnTxt.Name = "uIsbnTxt";
            this.uIsbnTxt.Size = new System.Drawing.Size(105, 20);
            this.uIsbnTxt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ISBN";
            // 
            // KnjigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KnjigeForm";
            this.Text = "KnjigeForm";
            this.Load += new System.EventHandler(this.KnjigeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dKolicinaNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uKolicinaNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dKategorijaCombo;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dNazivTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dIsbnTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button traziBtn;
        private System.Windows.Forms.Button ukloniBtn;
        private System.Windows.Forms.TextBox uDostupnaTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uNazivTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uIsbnTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ukategorijaTxt;
        private System.Windows.Forms.NumericUpDown dKolicinaNumeric;
        private System.Windows.Forms.NumericUpDown uKolicinaNumeric;
        private System.Windows.Forms.TextBox dAutorTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uAutorTxt;
        private System.Windows.Forms.Label label11;
    }
}