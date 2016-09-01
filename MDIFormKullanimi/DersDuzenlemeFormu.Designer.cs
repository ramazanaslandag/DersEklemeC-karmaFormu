namespace MDIFormKullanimi
{
    partial class DersDuzenlemeFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDers = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERS:";
            // 
            // cbDers
            // 
            this.cbDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Location = new System.Drawing.Point(109, 32);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(200, 26);
            this.cbDers.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(333, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 27);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "DÜZENLE";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.btnUpdate);
            this.grpClass.Controls.Add(this.txtCredit);
            this.grpClass.Controls.Add(this.txtHour);
            this.grpClass.Controls.Add(this.txtName);
            this.grpClass.Controls.Add(this.label4);
            this.grpClass.Controls.Add(this.label3);
            this.grpClass.Controls.Add(this.label2);
            this.grpClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpClass.Location = new System.Drawing.Point(0, 84);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(444, 204);
            this.grpClass.TabIndex = 3;
            this.grpClass.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "SAAT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "KREDİ:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 24);
            this.txtName.TabIndex = 0;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(109, 93);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(200, 24);
            this.txtHour.TabIndex = 1;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(109, 133);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(200, 24);
            this.txtCredit.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(333, 166);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 26);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "SAKLA";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DersDuzenlemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 288);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbDers);
            this.Controls.Add(this.label1);
            this.Name = "DersDuzenlemeFormu";
            this.Text = "DersDuzenlemeFormu";
            this.Load += new System.EventHandler(this.DersDuzenlemeFormu_Load);
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}