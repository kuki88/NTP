namespace NtpProjekt.Forme
{
    partial class RESTForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtOdgovor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(12, 10);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(232, 20);
            this.txtLink.TabIndex = 1;
            // 
            // txtOdgovor
            // 
            this.txtOdgovor.Location = new System.Drawing.Point(12, 47);
            this.txtOdgovor.Multiline = true;
            this.txtOdgovor.Name = "txtOdgovor";
            this.txtOdgovor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOdgovor.Size = new System.Drawing.Size(313, 319);
            this.txtOdgovor.TabIndex = 2;
            this.txtOdgovor.TextChanged += new System.EventHandler(this.txtOdgovor_TextChanged);
            // 
            // RESTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 387);
            this.Controls.Add(this.txtOdgovor);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.button1);
            this.Name = "RESTForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtOdgovor;
    }
}