namespace RevitAddinSeesion04
{
    partial class FfmWallsFromLines
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
            this.label2 = new System.Windows.Forms.Label();
            this.CmbLinestyles = new System.Windows.Forms.ComboBox();
            this.CmbWalltypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxWallHeight = new System.Windows.Forms.TextBox();
            this.CbxStructural = new System.Windows.Forms.CheckBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select line style";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            // 
            // CmbLinestyles
            // 
            this.CmbLinestyles.FormattingEnabled = true;
            this.CmbLinestyles.Location = new System.Drawing.Point(13, 30);
            this.CmbLinestyles.Name = "CmbLinestyles";
            this.CmbLinestyles.Size = new System.Drawing.Size(376, 21);
            this.CmbLinestyles.TabIndex = 2;
            // 
            // CmbWalltypes
            // 
            this.CmbWalltypes.FormattingEnabled = true;
            this.CmbWalltypes.Location = new System.Drawing.Point(12, 85);
            this.CmbWalltypes.Name = "CmbWalltypes";
            this.CmbWalltypes.Size = new System.Drawing.Size(377, 21);
            this.CmbWalltypes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Wall Height";
            // 
            // TbxWallHeight
            // 
            this.TbxWallHeight.Location = new System.Drawing.Point(12, 141);
            this.TbxWallHeight.Name = "TbxWallHeight";
            this.TbxWallHeight.Size = new System.Drawing.Size(377, 20);
            this.TbxWallHeight.TabIndex = 5;
            // 
            // CbxStructural
            // 
            this.CbxStructural.AutoSize = true;
            this.CbxStructural.Location = new System.Drawing.Point(13, 194);
            this.CbxStructural.Name = "CbxStructural";
            this.CbxStructural.Size = new System.Drawing.Size(71, 17);
            this.CbxStructural.TabIndex = 6;
            this.CbxStructural.Text = "Stuctural ";
            this.CbxStructural.UseVisualStyleBackColor = true;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(314, 194);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(79, 23);
            this.BtnOk.TabIndex = 7;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(222, 194);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(79, 23);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Select Line Style";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select Wall Type";
            // 
            // FfmWallsFromLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 243);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CbxStructural);
            this.Controls.Add(this.TbxWallHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbWalltypes);
            this.Controls.Add(this.CmbLinestyles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FfmWallsFromLines";
            this.Text = "Walls from lines";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbLinestyles;
        private System.Windows.Forms.ComboBox CmbWalltypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxWallHeight;
        private System.Windows.Forms.CheckBox CbxStructural;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}