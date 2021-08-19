namespace NtpProjekt
{
    partial class PrijavaForm
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
            this.korisnickoTxt = new System.Windows.Forms.TextBox();
            this.lozinkaTxt = new System.Windows.Forms.TextBox();
            this.prijavaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lozinka:";
            // 
            // korisnickoTxt
            // 
            this.korisnickoTxt.Location = new System.Drawing.Point(43, 49);
            this.korisnickoTxt.Name = "korisnickoTxt";
            this.korisnickoTxt.Size = new System.Drawing.Size(175, 20);
            this.korisnickoTxt.TabIndex = 0;
            // 
            // lozinkaTxt
            // 
            this.lozinkaTxt.Location = new System.Drawing.Point(43, 117);
            this.lozinkaTxt.Name = "lozinkaTxt";
            this.lozinkaTxt.PasswordChar = '*';
            this.lozinkaTxt.Size = new System.Drawing.Size(175, 20);
            this.lozinkaTxt.TabIndex = 1;
            // 
            // prijavaBtn
            // 
            this.prijavaBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prijavaBtn.Location = new System.Drawing.Point(0, 166);
            this.prijavaBtn.Name = "prijavaBtn";
            this.prijavaBtn.Size = new System.Drawing.Size(258, 52);
            this.prijavaBtn.TabIndex = 2;
            this.prijavaBtn.Text = "Prijava";
            this.prijavaBtn.UseVisualStyleBackColor = true;
            this.prijavaBtn.Click += new System.EventHandler(this.prijavaBtn_Click);
            // 
            // PrijavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 218);
            this.Controls.Add(this.prijavaBtn);
            this.Controls.Add(this.lozinkaTxt);
            this.Controls.Add(this.korisnickoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrijavaForm";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoTxt;
        private System.Windows.Forms.TextBox lozinkaTxt;
        private System.Windows.Forms.Button prijavaBtn;
    }
}