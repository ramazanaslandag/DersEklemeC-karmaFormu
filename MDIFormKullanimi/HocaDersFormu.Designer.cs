namespace MDIFormKullanimi
{
    partial class HocaDersFormu
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
            this.cbEgitmen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDersler = new System.Windows.Forms.ListBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEgitmen
            // 
            this.cbEgitmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbEgitmen.FormattingEnabled = true;
            this.cbEgitmen.Location = new System.Drawing.Point(102, 26);
            this.cbEgitmen.Name = "cbEgitmen";
            this.cbEgitmen.Size = new System.Drawing.Size(175, 26);
            this.cbEgitmen.TabIndex = 0;
            this.cbEgitmen.SelectedIndexChanged += new System.EventHandler(this.cbEgitmen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eğitmen:";
            // 
            // lbDersler
            // 
            this.lbDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDersler.FormattingEnabled = true;
            this.lbDersler.ItemHeight = 18;
            this.lbDersler.Location = new System.Drawing.Point(342, 26);
            this.lbDersler.Name = "lbDersler";
            this.lbDersler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDersler.Size = new System.Drawing.Size(206, 148);
            this.lbDersler.TabIndex = 2;
            // 
            // btnYaz
            // 
            this.btnYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaz.Location = new System.Drawing.Point(577, 28);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(75, 36);
            this.btnYaz.TabIndex = 3;
            this.btnYaz.Text = "YAZ";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // HocaDersFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 388);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.lbDersler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEgitmen);
            this.Name = "HocaDersFormu";
            this.Text = "HocaDersFormu";
            this.Load += new System.EventHandler(this.HocaDersFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEgitmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDersler;
        private System.Windows.Forms.Button btnYaz;
    }
}