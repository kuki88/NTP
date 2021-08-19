namespace NtpProjekt
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.posudbaBtn = new System.Windows.Forms.Button();
            this.vracanjeBtn = new System.Windows.Forms.Button();
            this.dodajUkloniBtn = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mainMenu2 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mainMenu3 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mainMenu4 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clanBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // posudbaBtn
            // 
            this.posudbaBtn.Location = new System.Drawing.Point(-1, 0);
            this.posudbaBtn.Name = "posudbaBtn";
            this.posudbaBtn.Size = new System.Drawing.Size(123, 23);
            this.posudbaBtn.TabIndex = 0;
            this.posudbaBtn.Text = "Posudba / Pretraga";
            this.posudbaBtn.UseVisualStyleBackColor = true;
            this.posudbaBtn.Click += new System.EventHandler(this.posudbaBtn_Click);
            // 
            // vracanjeBtn
            // 
            this.vracanjeBtn.Location = new System.Drawing.Point(150, 0);
            this.vracanjeBtn.Name = "vracanjeBtn";
            this.vracanjeBtn.Size = new System.Drawing.Size(123, 23);
            this.vracanjeBtn.TabIndex = 0;
            this.vracanjeBtn.Text = "Vraćanje";
            this.vracanjeBtn.UseVisualStyleBackColor = true;
            this.vracanjeBtn.Click += new System.EventHandler(this.vracanjeBtn_Click);
            // 
            // dodajUkloniBtn
            // 
            this.dodajUkloniBtn.Location = new System.Drawing.Point(450, 0);
            this.dodajUkloniBtn.Name = "dodajUkloniBtn";
            this.dodajUkloniBtn.Size = new System.Drawing.Size(123, 23);
            this.dodajUkloniBtn.TabIndex = 0;
            this.dodajUkloniBtn.Text = "Dodaj / Ukloni Knjigu";
            this.dodajUkloniBtn.UseVisualStyleBackColor = true;
            this.dodajUkloniBtn.Click += new System.EventHandler(this.dodajUkloniBtn_Click);
            // 
            // mainMenu2
            // 
            this.mainMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "a";
            // 
            // mainMenu3
            // 
            this.mainMenu3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "AAA";
            // 
            // mainMenu4
            // 
            this.mainMenu4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3});
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "AAA";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // clanBtn
            // 
            this.clanBtn.Location = new System.Drawing.Point(300, 0);
            this.clanBtn.Name = "clanBtn";
            this.clanBtn.Size = new System.Drawing.Size(123, 23);
            this.clanBtn.TabIndex = 0;
            this.clanBtn.Text = "Dodaj / Ukloni Člana";
            this.clanBtn.UseVisualStyleBackColor = true;
            this.clanBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posudbe:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clanBtn);
            this.Controls.Add(this.dodajUkloniBtn);
            this.Controls.Add(this.vracanjeBtn);
            this.Controls.Add(this.posudbaBtn);
            this.Menu = this.mainMenu1;
            this.Name = "MainMenu";
            this.Text = "Knjižnica";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button posudbaBtn;
        private System.Windows.Forms.Button vracanjeBtn;
        private System.Windows.Forms.Button dodajUkloniBtn;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MainMenu mainMenu3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MainMenu mainMenu4;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button clanBtn;
        private System.Windows.Forms.Label label1;
    }
}

