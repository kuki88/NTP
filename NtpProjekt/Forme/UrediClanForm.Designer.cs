namespace NtpProjekt.Forme
{
    partial class UrediClanForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdresaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrezimeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ImeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClanskiTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.AdresaTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TelTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PrezimeTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ImeTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ClanskiTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uredi člana";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ukloni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ukloniBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Uredi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.urediBtn_Click);
            // 
            // AdresaTxt
            // 
            this.AdresaTxt.Location = new System.Drawing.Point(132, 132);
            this.AdresaTxt.MaxLength = 50;
            this.AdresaTxt.Name = "AdresaTxt";
            this.AdresaTxt.Size = new System.Drawing.Size(194, 20);
            this.AdresaTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresa";
            // 
            // TelTxt
            // 
            this.TelTxt.Location = new System.Drawing.Point(132, 106);
            this.TelTxt.MaxLength = 50;
            this.TelTxt.Name = "TelTxt";
            this.TelTxt.Size = new System.Drawing.Size(194, 20);
            this.TelTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefonski Broj";
            // 
            // PrezimeTxt
            // 
            this.PrezimeTxt.Location = new System.Drawing.Point(132, 80);
            this.PrezimeTxt.MaxLength = 50;
            this.PrezimeTxt.Name = "PrezimeTxt";
            this.PrezimeTxt.Size = new System.Drawing.Size(194, 20);
            this.PrezimeTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prezime";
            // 
            // ImeTxt
            // 
            this.ImeTxt.Location = new System.Drawing.Point(132, 54);
            this.ImeTxt.MaxLength = 50;
            this.ImeTxt.Name = "ImeTxt";
            this.ImeTxt.Size = new System.Drawing.Size(194, 20);
            this.ImeTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ime";
            // 
            // ClanskiTxt
            // 
            this.ClanskiTxt.Location = new System.Drawing.Point(132, 28);
            this.ClanskiTxt.MaxLength = 9;
            this.ClanskiTxt.Name = "ClanskiTxt";
            this.ClanskiTxt.Size = new System.Drawing.Size(194, 20);
            this.ClanskiTxt.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Članski broj";
            // 
            // UrediClanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 281);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrediClanForm";
            this.Text = "UrediClanForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox AdresaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TelTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrezimeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ImeTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClanskiTxt;
        private System.Windows.Forms.Label label5;
    }
}