namespace NtpProjekt.Forme
{
    partial class UrediKnjigeForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UrediBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.uAutorTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ukategorijaTxt = new System.Windows.Forms.TextBox();
            this.uNazivTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uIsbnTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ukloniBtn = new System.Windows.Forms.Button();
            this.kolicinaNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kolicinaNum);
            this.groupBox2.Controls.Add(this.ukloniBtn);
            this.groupBox2.Controls.Add(this.UrediBtn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.uAutorTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ukategorijaTxt);
            this.groupBox2.Controls.Add(this.uNazivTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.uIsbnTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ukloni knjigu";
            // 
            // UrediBtn
            // 
            this.UrediBtn.Location = new System.Drawing.Point(0, 216);
            this.UrediBtn.Name = "UrediBtn";
            this.UrediBtn.Size = new System.Drawing.Size(160, 38);
            this.UrediBtn.TabIndex = 2;
            this.UrediBtn.Text = "Uredi";
            this.UrediBtn.UseVisualStyleBackColor = true;
            this.UrediBtn.Click += new System.EventHandler(this.UrediBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Količina";
            // 
            // uAutorTxt
            // 
            this.uAutorTxt.Location = new System.Drawing.Point(132, 171);
            this.uAutorTxt.Name = "uAutorTxt";
            this.uAutorTxt.Size = new System.Drawing.Size(194, 20);
            this.uAutorTxt.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Autor";
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
            this.uIsbnTxt.Size = new System.Drawing.Size(194, 20);
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
            // ukloniBtn
            // 
            this.ukloniBtn.Location = new System.Drawing.Point(172, 216);
            this.ukloniBtn.Name = "ukloniBtn";
            this.ukloniBtn.Size = new System.Drawing.Size(160, 38);
            this.ukloniBtn.TabIndex = 2;
            this.ukloniBtn.Text = "Ukloni";
            this.ukloniBtn.UseVisualStyleBackColor = true;
            this.ukloniBtn.Click += new System.EventHandler(this.ukloniBtn_Click);
            // 
            // kolicinaNum
            // 
            this.kolicinaNum.Location = new System.Drawing.Point(132, 136);
            this.kolicinaNum.Name = "kolicinaNum";
            this.kolicinaNum.Size = new System.Drawing.Size(194, 20);
            this.kolicinaNum.TabIndex = 3;
            // 
            // UrediKnjigeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.groupBox2);
            this.Name = "UrediKnjigeForm";
            this.Text = "UrediKnjigeForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button UrediBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uAutorTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ukategorijaTxt;
        private System.Windows.Forms.TextBox uNazivTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uIsbnTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ukloniBtn;
        private System.Windows.Forms.NumericUpDown kolicinaNum;
    }
}