namespace BankingApp
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHesapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümHesaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilançoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fDGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diğerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHesapToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.görüntüleToolStripMenuItem,
            this.diğerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniHesapToolStripMenuItem
            // 
            this.yeniHesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHesapToolStripMenuItem1,
            this.güncelleToolStripMenuItem,
            this.tümHesaplarToolStripMenuItem});
            this.yeniHesapToolStripMenuItem.Name = "yeniHesapToolStripMenuItem";
            this.yeniHesapToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.yeniHesapToolStripMenuItem.Text = "Hesap";
            // 
            // yeniHesapToolStripMenuItem1
            // 
            this.yeniHesapToolStripMenuItem1.Name = "yeniHesapToolStripMenuItem1";
            this.yeniHesapToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.yeniHesapToolStripMenuItem1.Text = "Yeni hesap";
            this.yeniHesapToolStripMenuItem1.Click += new System.EventHandler(this.yeniHesapToolStripMenuItem1_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.güncelleToolStripMenuItem.Text = "Güncelle / Hesap ara";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // tümHesaplarToolStripMenuItem
            // 
            this.tümHesaplarToolStripMenuItem.Name = "tümHesaplarToolStripMenuItem";
            this.tümHesaplarToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.tümHesaplarToolStripMenuItem.Text = "Tüm hesaplar";
            this.tümHesaplarToolStripMenuItem.Click += new System.EventHandler(this.tümHesaplarToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraEklemeToolStripMenuItem,
            this.paraÇekmeToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.fDFormToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // paraEklemeToolStripMenuItem
            // 
            this.paraEklemeToolStripMenuItem.Name = "paraEklemeToolStripMenuItem";
            this.paraEklemeToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.paraEklemeToolStripMenuItem.Text = "Para yatırma";
            this.paraEklemeToolStripMenuItem.Click += new System.EventHandler(this.paraEklemeToolStripMenuItem_Click);
            // 
            // paraÇekmeToolStripMenuItem
            // 
            this.paraÇekmeToolStripMenuItem.Name = "paraÇekmeToolStripMenuItem";
            this.paraÇekmeToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.paraÇekmeToolStripMenuItem.Text = "Para çekme";
            this.paraÇekmeToolStripMenuItem.Click += new System.EventHandler(this.paraÇekmeToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // fDFormToolStripMenuItem
            // 
            this.fDFormToolStripMenuItem.Name = "fDFormToolStripMenuItem";
            this.fDFormToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.fDFormToolStripMenuItem.Text = "Vade Formu";
            this.fDFormToolStripMenuItem.Click += new System.EventHandler(this.fDFormToolStripMenuItem_Click);
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilançoToolStripMenuItem,
            this.fDGörüntüleToolStripMenuItem});
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.görüntüleToolStripMenuItem.Text = "Görüntüle";
            // 
            // bilançoToolStripMenuItem
            // 
            this.bilançoToolStripMenuItem.Name = "bilançoToolStripMenuItem";
            this.bilançoToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.bilançoToolStripMenuItem.Text = "Bilanço";
            this.bilançoToolStripMenuItem.Click += new System.EventHandler(this.bilançoToolStripMenuItem_Click);
            // 
            // fDGörüntüleToolStripMenuItem
            // 
            this.fDGörüntüleToolStripMenuItem.Name = "fDGörüntüleToolStripMenuItem";
            this.fDGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.fDGörüntüleToolStripMenuItem.Text = "Vade görüntüle";
            this.fDGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.fDGörüntüleToolStripMenuItem_Click);
            // 
            // diğerToolStripMenuItem
            // 
            this.diğerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.diğerToolStripMenuItem.Name = "diğerToolStripMenuItem";
            this.diğerToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.diğerToolStripMenuItem.Text = "Diğer";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.logoutToolStripMenuItem.Text = "Kullanıcı değiştir";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniHesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniHesapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümHesaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilançoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diğerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fDFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
    }
}