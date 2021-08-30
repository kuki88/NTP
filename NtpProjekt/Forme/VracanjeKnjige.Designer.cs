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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VracanjeKnjige));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // iznosTxt
            // 
            resources.ApplyResources(this.iznosTxt, "iznosTxt");
            this.iznosTxt.Name = "iznosTxt";
            this.iznosTxt.ReadOnly = true;
            // 
            // clanskiTxt
            // 
            resources.ApplyResources(this.clanskiTxt, "clanskiTxt");
            this.clanskiTxt.Name = "clanskiTxt";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // posudbaPicker
            // 
            resources.ApplyResources(this.posudbaPicker, "posudbaPicker");
            this.posudbaPicker.Name = "posudbaPicker";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // povratakPicker
            // 
            resources.ApplyResources(this.povratakPicker, "povratakPicker");
            this.povratakPicker.Name = "povratakPicker";
            // 
            // vratiBtn
            // 
            resources.ApplyResources(this.vratiBtn, "vratiBtn");
            this.vratiBtn.Name = "vratiBtn";
            this.vratiBtn.UseVisualStyleBackColor = true;
            this.vratiBtn.Click += new System.EventHandler(this.vratiBtn_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // idPosudbeTxt
            // 
            resources.ApplyResources(this.idPosudbeTxt, "idPosudbeTxt");
            this.idPosudbeTxt.Name = "idPosudbeTxt";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // isbnTxt
            // 
            resources.ApplyResources(this.isbnTxt, "isbnTxt");
            this.isbnTxt.Name = "isbnTxt";
            // 
            // provjeraBtn
            // 
            resources.ApplyResources(this.provjeraBtn, "provjeraBtn");
            this.provjeraBtn.Name = "provjeraBtn";
            this.provjeraBtn.UseVisualStyleBackColor = true;
            this.provjeraBtn.Click += new System.EventHandler(this.provjeraBtn_Click);
            // 
            // ponistiBtn
            // 
            resources.ApplyResources(this.ponistiBtn, "ponistiBtn");
            this.ponistiBtn.Name = "ponistiBtn";
            this.ponistiBtn.UseVisualStyleBackColor = true;
            this.ponistiBtn.Click += new System.EventHandler(this.ponistiBtn_Click);
            // 
            // produziBtn
            // 
            resources.ApplyResources(this.produziBtn, "produziBtn");
            this.produziBtn.Name = "produziBtn";
            this.produziBtn.UseVisualStyleBackColor = true;
            this.produziBtn.Click += new System.EventHandler(this.produziBtn_Click);
            // 
            // VracanjeKnjige
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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