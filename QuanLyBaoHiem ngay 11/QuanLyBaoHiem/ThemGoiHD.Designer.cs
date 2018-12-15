namespace QuanLyBaoHiem
{
    partial class ThemGoiHD
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
            this.txtMaGHD = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThoiHanBaoHiem = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaTriBaoHiem = new DevExpress.XtraEditors.TextEdit();
            this.txtThoiHanDongPhi = new DevExpress.XtraEditors.TextEdit();
            this.txtMucPhi = new DevExpress.XtraEditors.TextEdit();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHanBaoHiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTriBaoHiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHanDongPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucPhi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã gói hợp đồng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaGHD
            // 
            this.txtMaGHD.Location = new System.Drawing.Point(331, 69);
            this.txtMaGHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaGHD.Name = "txtMaGHD";
            this.txtMaGHD.Properties.Mask.EditMask = "[a-zA-Z0-9]+";
            this.txtMaGHD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMaGHD.Size = new System.Drawing.Size(192, 22);
            this.txtMaGHD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mức phí";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thời hạn bảo hiểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá trị bảo hiểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thời hạn đóng phí";
            // 
            // txtThoiHanBaoHiem
            // 
            this.txtThoiHanBaoHiem.Location = new System.Drawing.Point(331, 242);
            this.txtThoiHanBaoHiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiHanBaoHiem.Name = "txtThoiHanBaoHiem";
            this.txtThoiHanBaoHiem.Properties.Mask.EditMask = "[0-9]+";
            this.txtThoiHanBaoHiem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtThoiHanBaoHiem.Size = new System.Drawing.Size(61, 22);
            this.txtThoiHanBaoHiem.TabIndex = 8;
            // 
            // txtGiaTriBaoHiem
            // 
            this.txtGiaTriBaoHiem.Location = new System.Drawing.Point(331, 186);
            this.txtGiaTriBaoHiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaTriBaoHiem.Name = "txtGiaTriBaoHiem";
            this.txtGiaTriBaoHiem.Properties.Mask.EditMask = "n";
            this.txtGiaTriBaoHiem.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGiaTriBaoHiem.Size = new System.Drawing.Size(192, 22);
            this.txtGiaTriBaoHiem.TabIndex = 9;
            // 
            // txtThoiHanDongPhi
            // 
            this.txtThoiHanDongPhi.Location = new System.Drawing.Point(331, 300);
            this.txtThoiHanDongPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiHanDongPhi.Name = "txtThoiHanDongPhi";
            this.txtThoiHanDongPhi.Properties.Mask.EditMask = "[0-9]+";
            this.txtThoiHanDongPhi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtThoiHanDongPhi.Size = new System.Drawing.Size(61, 22);
            this.txtThoiHanDongPhi.TabIndex = 10;
            // 
            // txtMucPhi
            // 
            this.txtMucPhi.Location = new System.Drawing.Point(331, 129);
            this.txtMucPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMucPhi.Name = "txtMucPhi";
            this.txtMucPhi.Properties.Mask.EditMask = "n";
            this.txtMucPhi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMucPhi.Size = new System.Drawing.Size(192, 22);
            this.txtMucPhi.TabIndex = 11;
            // 
            // btn_luu
            // 
            this.btn_luu.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.add;
            this.btn_luu.Location = new System.Drawing.Point(208, 402);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(87, 28);
            this.btn_luu.TabIndex = 12;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.cen1;
            this.btn_thoat.Location = new System.Drawing.Point(360, 402);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(87, 28);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Năm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Năm";
            // 
            // ThemGoiHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 481);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txtMucPhi);
            this.Controls.Add(this.txtThoiHanDongPhi);
            this.Controls.Add(this.txtGiaTriBaoHiem);
            this.Controls.Add(this.txtThoiHanBaoHiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaGHD);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemGoiHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm gói hợp đồng";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHanBaoHiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaTriBaoHiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiHanDongPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucPhi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaGHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtThoiHanBaoHiem;
        private DevExpress.XtraEditors.TextEdit txtGiaTriBaoHiem;
        private DevExpress.XtraEditors.TextEdit txtThoiHanDongPhi;
        private DevExpress.XtraEditors.TextEdit txtMucPhi;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}