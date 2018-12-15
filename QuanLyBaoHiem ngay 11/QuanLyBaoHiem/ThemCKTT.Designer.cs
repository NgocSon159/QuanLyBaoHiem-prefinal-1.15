namespace QuanLyBaoHiem
{
    partial class ThemCKTT
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
            this.cboSothang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMaCK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cboSothang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSothang
            // 
            this.cboSothang.Location = new System.Drawing.Point(311, 101);
            this.cboSothang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSothang.Name = "cboSothang";
            this.cboSothang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSothang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSothang.Size = new System.Drawing.Size(55, 22);
            this.cboSothang.TabIndex = 46;
            // 
            // txtMaCK
            // 
            this.txtMaCK.Location = new System.Drawing.Point(311, 48);
            this.txtMaCK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaCK.Name = "txtMaCK";
            this.txtMaCK.Properties.Mask.EditMask = "[A-zA-Z0-9]+";
            this.txtMaCK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMaCK.Size = new System.Drawing.Size(170, 22);
            this.txtMaCK.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(130, 105);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Chu Kỳ Đóng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(130, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Chu Kỳ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.add;
            this.simpleButton1.Location = new System.Drawing.Point(165, 163);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 29);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.cen1;
            this.simpleButton2.Location = new System.Drawing.Point(352, 163);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(87, 29);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(372, 106);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "tháng";
            // 
            // ThemCKTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 248);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cboSothang);
            this.Controls.Add(this.txtMaCK);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemCKTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Chu Kỳ Thanh Toán";
            ((System.ComponentModel.ISupportInitialize)(this.cboSothang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtMaCK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ComboBoxEdit cboSothang;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}