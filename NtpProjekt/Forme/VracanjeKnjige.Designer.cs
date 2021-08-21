namespace NtpProjekt
{
    partial class VracanjeKnjige
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iznosTxt = new System.Windows.Forms.TextBox();
            this.clanskiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.posudbaPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.povratakPicker = new System.Windows.Forms.DateTimePicker();
            this.vratiBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idPosudbeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isbnTxt = new System.Windows.Forms.TextBox();
            this.provjeraBtn = new System.Windows.Forms.Button();
            this.ponistiBtn = new System.Windows.Forms.Button();
            this.produziBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iznos povratka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Članski broj:";
            // 
            // iznosTxt
            // 
            this.iznosTxt.Location = new System.Drawing.Point(113, 235);
            this.iznosTxt.Name = "iznosTxt";
            this.iznosTxt.ReadOnly = true;
            this.iznosTxt.Size = new System.Drawing.Size(100, 20);
            this.iznosTxt.TabIndex = 1;
            // 
            // clanskiTxt
            // 
            this.clanskiTxt.Location = new System.Drawing.Point(113, 122);
            this.clanskiTxt.Name = "clanskiTxt";
            this.clanskiTxt.Size = new System.Drawing.Size(100, 20);
            this.clanskiTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Datum posudbe";
            // 
            // posudbaPicker
            // 
            this.posudbaPicker.Location = new System.Drawing.Point(16, 163);
            this.posudbaPicker.Name = "posudbaPicker";
            this.posudbaPicker.Size = new System.Drawing.Size(110, 20);
            this.posudbaPicker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datum povratka";
            // 
            // povratakPicker
            // 
            this.povratakPicker.Location = new System.Drawing.Point(16, 209);
            this.povratakPicker.Name = "povratakPicker";
            this.povratakPicker.Size = new System.Drawing.Size(110, 20);
            this.povratakPicker.TabIndex = 2;
            // 
            // vratiBtn
            // 
            this.vratiBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vratiBtn.Location = new System.Drawing.Point(0, 313);
            this.vratiBtn.Name = "vratiBtn";
            this.vratiBtn.Size = new System.Drawing.Size(232, 41);
            this.vratiBtn.TabIndex = 3;
            this.vratiBtn.Text = "Vrati";
            this.vratiBtn.UseVisualStyleBackColor = true;
            this.vratiBtn.Click += new System.EventHandler(this.vratiBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Unesi ID narudžbe:";
            // 
            // idPosudbeTxt
            // 
            this.idPosudbeTxt.Location = new System.Drawing.Point(113, 12);
            this.idPosudbeTxt.Name = "idPosudbeTxt";
            this.idPosudbeTxt.Size = new System.Drawing.Size(100, 20);
            this.idPosudbeTxt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ISBN knjige:";
            // 
            // isbnTxt
            // 
            this.isbnTxt.Location = new System.Drawing.Point(113, 96);
            this.isbnTxt.Name = "isbnTxt";
            this.isbnTxt.Size = new System.Drawing.Size(100, 20);
            this.isbnTxt.TabIndex = 1;
            // 
            // provjeraBtn
            // 
            this.provjeraBtn.Location = new System.Drawing.Point(160, 38);
            this.provjeraBtn.Name = "provjeraBtn";
            this.provjeraBtn.Size = new System.Drawing.Size(58, 23);
            this.provjeraBtn.TabIndex = 4;
            this.provjeraBtn.Text = "Provjeri";
            this.provjeraBtn.UseVisualStyleBackColor = true;
            this.provjeraBtn.Click += new System.EventHandler(this.provjeraBtn_Click);
            // 
            // ponistiBtn
            // 
            this.ponistiBtn.Location = new System.Drawing.Point(96, 38);
            this.ponistiBtn.Name = "ponistiBtn";
            this.ponistiBtn.Size = new System.Drawing.Size(58, 23);
            this.ponistiBtn.TabIndex = 4;
            this.ponistiBtn.Text = "Poništi";
            this.ponistiBtn.UseVisualStyleBackColor = true;
            this.ponistiBtn.Click += new System.EventHandler(this.ponistiBtn_Click);
            // 
            // produziBtn
            // 
            this.produziBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.produziBtn.Location = new System.Drawing.Point(0, 272);
            this.produziBtn.Name = "produziBtn";
            this.produziBtn.Size = new System.Drawing.Size(232, 41);
            this.produziBtn.TabIndex = 3;
            this.produziBtn.Text = "Produži";
            this.produziBtn.UseVisualStyleBackColor = true;
            this.produziBtn.Click += new System.EventHandler(this.produziBtn_Click);
            // 
            // VracanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 354);
            this.Controls.Add(this.ponistiBtn);
            this.Controls.Add(this.provjeraBtn);
            this.Controls.Add(this.produziBtn);
            this.Controls.Add(this.vratiBtn);
            this.Controls.Add(this.povratakPicker);
            this.Controls.Add(this.posudbaPicker);
            this.Controls.Add(this.isbnTxt);
            this.Controls.Add(this.clanskiTxt);
            this.Controls.Add(this.idPosudbeTxt);
            this.Controls.Add(this.iznosTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VracanjeKnjige";
            this.Text = "Vracanje Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iznosTxt;
        private System.Windows.Forms.TextBox clanskiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker posudbaPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker povratakPicker;
        private System.Windows.Forms.Button vratiBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idPosudbeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isbnTxt;
        private System.Windows.Forms.Button provjeraBtn;
        private System.Windows.Forms.Button ponistiBtn;
        private System.Windows.Forms.Button produziBtn;
    }
}