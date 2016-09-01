namespace MDIFormKullanimi
{
    partial class Form1
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
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eğitmenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sınıfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hocaDersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.aktarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersToolStripMenuItem,
            this.eğitmenToolStripMenuItem,
            this.sınıfToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.dersToolStripMenuItem.Text = "Ders";
            this.dersToolStripMenuItem.Click += new System.EventHandler(this.dersToolStripMenuItem_Click);
            // 
            // eğitmenToolStripMenuItem
            // 
            this.eğitmenToolStripMenuItem.Name = "eğitmenToolStripMenuItem";
            this.eğitmenToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.eğitmenToolStripMenuItem.Text = "Eğitmen";
            this.eğitmenToolStripMenuItem.Click += new System.EventHandler(this.eğitmenToolStripMenuItem_Click);
            // 
            // sınıfToolStripMenuItem
            // 
            this.sınıfToolStripMenuItem.Name = "sınıfToolStripMenuItem";
            this.sınıfToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.sınıfToolStripMenuItem.Text = "Sınıf";
            this.sınıfToolStripMenuItem.Click += new System.EventHandler(this.sınıfToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dersToolStripMenuItem1,
            this.eğitmenToolStripMenuItem1,
            this.sınıfToolStripMenuItem1});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // dersToolStripMenuItem1
            // 
            this.dersToolStripMenuItem1.Name = "dersToolStripMenuItem1";
            this.dersToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.dersToolStripMenuItem1.Text = "Ders";
            this.dersToolStripMenuItem1.Click += new System.EventHandler(this.dersToolStripMenuItem1_Click);
            // 
            // eğitmenToolStripMenuItem1
            // 
            this.eğitmenToolStripMenuItem1.Name = "eğitmenToolStripMenuItem1";
            this.eğitmenToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.eğitmenToolStripMenuItem1.Text = "Eğitmen";
            this.eğitmenToolStripMenuItem1.Click += new System.EventHandler(this.eğitmenToolStripMenuItem1_Click);
            // 
            // sınıfToolStripMenuItem1
            // 
            this.sınıfToolStripMenuItem1.Name = "sınıfToolStripMenuItem1";
            this.sınıfToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.sınıfToolStripMenuItem1.Text = "Sınıf";
            this.sınıfToolStripMenuItem1.Click += new System.EventHandler(this.sınıfToolStripMenuItem1_Click);
            // 
            // aktarToolStripMenuItem
            // 
            this.aktarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hocaDersToolStripMenuItem,
            this.öğrenciDersToolStripMenuItem});
            this.aktarToolStripMenuItem.Name = "aktarToolStripMenuItem";
            this.aktarToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.aktarToolStripMenuItem.Text = "Aktar";
            // 
            // hocaDersToolStripMenuItem
            // 
            this.hocaDersToolStripMenuItem.Name = "hocaDersToolStripMenuItem";
            this.hocaDersToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.hocaDersToolStripMenuItem.Text = "Hoca-Ders";
            this.hocaDersToolStripMenuItem.Click += new System.EventHandler(this.hocaDersToolStripMenuItem_Click);
            // 
            // öğrenciDersToolStripMenuItem
            // 
            this.öğrenciDersToolStripMenuItem.Name = "öğrenciDersToolStripMenuItem";
            this.öğrenciDersToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.öğrenciDersToolStripMenuItem.Text = "Öğrenci-Ders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 467);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Uygulama X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eğitmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eğitmenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sınıfToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hocaDersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDersToolStripMenuItem;
    }
}

