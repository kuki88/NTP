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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrijavaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoTxt = new System.Windows.Forms.TextBox();
            this.lozinkaTxt = new System.Windows.Forms.TextBox();
            this.prijavaBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // korisnickoTxt
            // 
            resources.ApplyResources(this.korisnickoTxt, "korisnickoTxt");
            this.korisnickoTxt.Name = "korisnickoTxt";
            // 
            // lozinkaTxt
            // 
            resources.ApplyResources(this.lozinkaTxt, "lozinkaTxt");
            this.lozinkaTxt.Name = "lozinkaTxt";
            // 
            // prijavaBtn
            // 
            resources.ApplyResources(this.prijavaBtn, "prijavaBtn");
            this.prijavaBtn.Name = "prijavaBtn";
            this.prijavaBtn.UseVisualStyleBackColor = true;
            this.prijavaBtn.Click += new System.EventHandler(this.prijavaBtn_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // PrijavaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.prijavaBtn);
            this.Controls.Add(this.lozinkaTxt);
            this.Controls.Add(this.korisnickoTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrijavaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoTxt;
        private System.Windows.Forms.TextBox lozinkaTxt;
        private System.Windows.Forms.Button prijavaBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}