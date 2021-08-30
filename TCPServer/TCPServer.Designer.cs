namespace TCPServer
{
    partial class TCPServerForm
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
            this.infoTxt = new System.Windows.Forms.TextBox();
            this.porukaTxt = new System.Windows.Forms.TextBox();
            this.serverIpTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spojeniKlijentTxt = new System.Windows.Forms.TextBox();
            this.iskljuciBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoTxt
            // 
            this.infoTxt.Enabled = false;
            this.infoTxt.Location = new System.Drawing.Point(73, 43);
            this.infoTxt.Multiline = true;
            this.infoTxt.Name = "infoTxt";
            this.infoTxt.Size = new System.Drawing.Size(349, 146);
            this.infoTxt.TabIndex = 33;
            // 
            // porukaTxt
            // 
            this.porukaTxt.Location = new System.Drawing.Point(73, 195);
            this.porukaTxt.Name = "porukaTxt";
            this.porukaTxt.Size = new System.Drawing.Size(349, 20);
            this.porukaTxt.TabIndex = 29;
            // 
            // serverIpTxt
            // 
            this.serverIpTxt.Location = new System.Drawing.Point(73, 16);
            this.serverIpTxt.Name = "serverIpTxt";
            this.serverIpTxt.Size = new System.Drawing.Size(349, 20);
            this.serverIpTxt.TabIndex = 30;
            this.serverIpTxt.Text = "127.0.0.1:9000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(11, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Poruka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Server:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(428, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Spojeni klijent:";
            // 
            // spojeniKlijentTxt
            // 
            this.spojeniKlijentTxt.Enabled = false;
            this.spojeniKlijentTxt.Location = new System.Drawing.Point(428, 43);
            this.spojeniKlijentTxt.Name = "spojeniKlijentTxt";
            this.spojeniKlijentTxt.Size = new System.Drawing.Size(102, 20);
            this.spojeniKlijentTxt.TabIndex = 35;
            // 
            // iskljuciBtn
            // 
            this.iskljuciBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iskljuciBtn.Location = new System.Drawing.Point(545, 194);
            this.iskljuciBtn.Name = "iskljuciBtn";
            this.iskljuciBtn.Size = new System.Drawing.Size(75, 23);
            this.iskljuciBtn.TabIndex = 32;
            this.iskljuciBtn.Text = "Isključi";
            this.iskljuciBtn.UseVisualStyleBackColor = true;
            this.iskljuciBtn.Click += new System.EventHandler(this.iskljuciBtn_Click);
            // 
            // TCPServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 229);
            this.Controls.Add(this.spojeniKlijentTxt);
            this.Controls.Add(this.infoTxt);
            this.Controls.Add(this.iskljuciBtn);
            this.Controls.Add(this.porukaTxt);
            this.Controls.Add(this.serverIpTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "TCPServerForm";
            this.Text = "TCP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoTxt;
        private System.Windows.Forms.TextBox porukaTxt;
        private System.Windows.Forms.TextBox serverIpTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spojeniKlijentTxt;
        private System.Windows.Forms.Button iskljuciBtn;
    }
}

