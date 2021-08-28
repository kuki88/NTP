namespace NtpProjekt.Forme
{
    partial class RegistracijaForm
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
            this.btnReg = new System.Windows.Forms.Button();
            this.korisnickoTxt = new System.Windows.Forms.TextBox();
            this.lozinkaTxt = new System.Windows.Forms.TextBox();
            this.lozinkaPonTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(184, 140);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "Registriraj";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // korisnickoTxt
            // 
            this.korisnickoTxt.Location = new System.Drawing.Point(122, 25);
            this.korisnickoTxt.Name = "korisnickoTxt";
            this.korisnickoTxt.Size = new System.Drawing.Size(137, 20);
            this.korisnickoTxt.TabIndex = 1;
            // 
            // lozinkaTxt
            // 
            this.lozinkaTxt.Location = new System.Drawing.Point(122, 65);
            this.lozinkaTxt.Name = "lozinkaTxt";
            this.lozinkaTxt.Size = new System.Drawing.Size(137, 20);
            this.lozinkaTxt.TabIndex = 1;
            // 
            // lozinkaPonTxt
            // 
            this.lozinkaPonTxt.Location = new System.Drawing.Point(122, 104);
            this.lozinkaPonTxt.Name = "lozinkaPonTxt";
            this.lozinkaPonTxt.Size = new System.Drawing.Size(137, 20);
            this.lozinkaPonTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ponovljena lozinka";
            // 
            // RegistracijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 175);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lozinkaPonTxt);
            this.Controls.Add(this.lozinkaTxt);
            this.Controls.Add(this.korisnickoTxt);
            this.Controls.Add(this.btnReg);
            this.Name = "RegistracijaForm";
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox korisnickoTxt;
        private System.Windows.Forms.TextBox lozinkaTxt;
        private System.Windows.Forms.TextBox lozinkaPonTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}