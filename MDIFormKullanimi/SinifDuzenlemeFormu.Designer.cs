namespace MDIFormKullanimi
{
    partial class SinifDuzenlemeFormu
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
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpClass = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "SINIF:";
            // 
            // cbClass
            // 
            this.cbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(108, 39);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(193, 26);
            this.cbClass.TabIndex = 2;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.Location = new System.Drawing.Point(339, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "DÜZENLE";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpClass
            // 
            this.grpClass.Controls.Add(this.btnUpdate);
            this.grpClass.Controls.Add(this.nud);
            this.grpClass.Controls.Add(this.txtName);
            this.grpClass.Controls.Add(this.label3);
            this.grpClass.Controls.Add(this.label2);
            this.grpClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpClass.Location = new System.Drawing.Point(0, 149);
            this.grpClass.Name = "grpClass";
            this.grpClass.Size = new System.Drawing.Size(450, 159);
            this.grpClass.TabIndex = 4;
            this.grpClass.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(339, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "SAKLA";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(148, 94);
            this.nud.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nud.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(153, 24);
            this.nud.TabIndex = 3;
            this.nud.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 24);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "KAPASİTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD:";
            // 
            // SinifDuzenlemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 308);
            this.Controls.Add(this.grpClass);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label1);
            this.Name = "SinifDuzenlemeFormu";
            this.Text = "SinifDuzenlemeFormu";
            this.Load += new System.EventHandler(this.SinifDuzenlemeFormu_Load);
            this.grpClass.ResumeLayout(false);
            this.grpClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpClass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}