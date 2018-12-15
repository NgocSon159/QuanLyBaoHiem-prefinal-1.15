namespace QuanLyBaoHiem
{
    partial class FormThemNhanVien
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
            this.cboQuyenHan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dtngaysinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtSdt = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTenNV = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNVQL = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboQuyenHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNVQL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboQuyenHan
            // 
            this.cboQuyenHan.Enabled = false;
            this.cboQuyenHan.Location = new System.Drawing.Point(198, 95);
            this.cboQuyenHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboQuyenHan.Name = "cboQuyenHan";
            this.cboQuyenHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboQuyenHan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboQuyenHan.Size = new System.Drawing.Size(251, 22);
            this.cboQuyenHan.TabIndex = 56;
            this.cboQuyenHan.TextChanged += new System.EventHandler(this.cboQuyenHan_TextChanged);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Location = new System.Drawing.Point(198, 160);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboGioiTinh.Size = new System.Drawing.Size(251, 22);
            this.cboGioiTinh.TabIndex = 55;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(89, 98);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(68, 17);
            this.labelControl16.TabIndex = 54;
            this.labelControl16.Text = "Quyền hạn";
            // 
            // dtngaysinh
            // 
            this.dtngaysinh.EditValue = null;
            this.dtngaysinh.Location = new System.Drawing.Point(198, 194);
            this.dtngaysinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtngaysinh.Name = "dtngaysinh";
            this.dtngaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtngaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtngaysinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtngaysinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtngaysinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtngaysinh.Size = new System.Drawing.Size(251, 22);
            this.dtngaysinh.TabIndex = 49;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(487, 65);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(130, 17);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Mã nhân viên quản lý";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(487, 97);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 17);
            this.labelControl9.TabIndex = 46;
            this.labelControl9.Text = "Địa Chỉ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(487, 130);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 17);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Điện Thoại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(89, 199);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Ngày Sinh";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(89, 165);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 17);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "Giới Tính";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(89, 130);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 17);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "Họ Tên NV";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(89, 66);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 16);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Mã Nhân Viên";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(632, 93);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(251, 22);
            this.txtDiaChi.TabIndex = 37;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(632, 126);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Properties.Mask.EditMask = "[0-9]{10}";
            this.txtSdt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSdt.Size = new System.Drawing.Size(251, 22);
            this.txtSdt.TabIndex = 36;
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Location = new System.Drawing.Point(198, 125);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Properties.Mask.EditMask = "[^0-9`~!@#$%^&*()_+-={}|\\][;\',.:\"?><+]+";
            this.txtHoTenNV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtHoTenNV.Size = new System.Drawing.Size(251, 22);
            this.txtHoTenNV.TabIndex = 34;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(198, 61);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(251, 22);
            this.txtMaNV.TabIndex = 33;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.cen1;
            this.simpleButton5.Location = new System.Drawing.Point(531, 253);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(93, 32);
            this.simpleButton5.TabIndex = 58;
            this.simpleButton5.Text = "Hủy bỏ";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(356, 253);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 32);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(487, 166);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(31, 16);
            this.labelControl6.TabIndex = 60;
            this.labelControl6.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(632, 162);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Properties.Mask.EditMask = "\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.txtemail.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtemail.Size = new System.Drawing.Size(251, 22);
            this.txtemail.TabIndex = 59;
            // 
            // txtMaNVQL
            // 
            this.txtMaNVQL.Enabled = false;
            this.txtMaNVQL.Location = new System.Drawing.Point(632, 61);
            this.txtMaNVQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNVQL.Name = "txtMaNVQL";
            this.txtMaNVQL.Size = new System.Drawing.Size(251, 22);
            this.txtMaNVQL.TabIndex = 38;
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 335);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboQuyenHan);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.labelControl16);
            this.Controls.Add(this.dtngaysinh);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtHoTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtMaNVQL);
            this.Name = "FormThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.FormThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboQuyenHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtngaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNVQL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboQuyenHan;
        private DevExpress.XtraEditors.ComboBoxEdit cboGioiTinh;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.DateEdit dtngaysinh;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtSdt;
        private DevExpress.XtraEditors.TextEdit txtHoTenNV;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.TextEdit txtMaNVQL;
    }
}