namespace QuanLyBaoHiem
{
    partial class ucQuanLyChucVuNV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQuanLyChucVuNV));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnChuyenNVcuaTruongPhong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.cboTenCV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboMaNVQL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridChucvu = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNVQL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNVQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnChuyenNVcuaTruongPhong);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMaNV);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.txtTenNV);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cboTenCV);
            this.groupControl1.Controls.Add(this.cboMaNVQL);
            this.groupControl1.Location = new System.Drawing.Point(14, 19);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1023, 239);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Lựa chọn chức vụ";
            // 
            // btnChuyenNVcuaTruongPhong
            // 
            this.btnChuyenNVcuaTruongPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenNVcuaTruongPhong.ImageOptions.Image")));
            this.btnChuyenNVcuaTruongPhong.Location = new System.Drawing.Point(184, 188);
            this.btnChuyenNVcuaTruongPhong.Name = "btnChuyenNVcuaTruongPhong";
            this.btnChuyenNVcuaTruongPhong.Size = new System.Drawing.Size(195, 29);
            this.btnChuyenNVcuaTruongPhong.TabIndex = 53;
            this.btnChuyenNVcuaTruongPhong.Text = "Chuyển tiếp nhân viên";
            this.btnChuyenNVcuaTruongPhong.Visible = false;
            this.btnChuyenNVcuaTruongPhong.Click += new System.EventHandler(this.btnChuyenNVcuaTruongPhong_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(485, 110);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 17);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "Mã nhân viên quản lý";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(151, 61);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaNV.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(245, 22);
            this.txtMaNV.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã nhân viên";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(528, 186);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 32);
            this.btnHuy.TabIndex = 46;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.apply;
            this.btnLuu.Location = new System.Drawing.Point(406, 186);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 32);
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(640, 61);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenNV.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenNV.Properties.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(245, 22);
            this.txtTenNV.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(485, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên chức vụ";
            // 
            // cboTenCV
            // 
            this.cboTenCV.Enabled = false;
            this.cboTenCV.Location = new System.Drawing.Point(149, 107);
            this.cboTenCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTenCV.Name = "cboTenCV";
            this.cboTenCV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboTenCV.Properties.Appearance.Options.UseBackColor = true;
            this.cboTenCV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTenCV.Size = new System.Drawing.Size(245, 22);
            this.cboTenCV.TabIndex = 40;
            this.cboTenCV.SelectedIndexChanged += new System.EventHandler(this.cboTenCV_SelectedIndexChanged);
            // 
            // cboMaNVQL
            // 
            this.cboMaNVQL.Enabled = false;
            this.cboMaNVQL.Location = new System.Drawing.Point(640, 106);
            this.cboMaNVQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaNVQL.Name = "cboMaNVQL";
            this.cboMaNVQL.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboMaNVQL.Properties.Appearance.Options.UseBackColor = true;
            this.cboMaNVQL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaNVQL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMaNVQL.Size = new System.Drawing.Size(245, 22);
            this.cboMaNVQL.TabIndex = 52;
            // 
            // gridChucvu
            // 
            this.gridChucvu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridChucvu.Location = new System.Drawing.Point(14, 302);
            this.gridChucvu.MainView = this.gridView2;
            this.gridChucvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridChucvu.Name = "gridChucvu";
            this.gridChucvu.Size = new System.Drawing.Size(1023, 340);
            this.gridChucvu.TabIndex = 36;
            this.gridChucvu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridChucvu.Click += new System.EventHandler(this.gridChucvu_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colTenCV,
            this.colTenNV,
            this.colMaCV,
            this.colMaNVQL});
            this.gridView2.DetailHeight = 431;
            this.gridView2.GridControl = this.gridChucvu;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.MinWidth = 23;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            this.colMaNV.Width = 87;
            // 
            // colTenCV
            // 
            this.colTenCV.Caption = "Tên chức vụ";
            this.colTenCV.FieldName = "TenCV";
            this.colTenCV.MinWidth = 23;
            this.colTenCV.Name = "colTenCV";
            this.colTenCV.Visible = true;
            this.colTenCV.VisibleIndex = 2;
            this.colTenCV.Width = 87;
            // 
            // colTenNV
            // 
            this.colTenNV.Caption = "Tên nhân viên";
            this.colTenNV.FieldName = "TenNV";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 1;
            // 
            // colMaCV
            // 
            this.colMaCV.Caption = "Mã CV";
            this.colMaCV.FieldName = "MaCV";
            this.colMaCV.Name = "colMaCV";
            // 
            // colMaNVQL
            // 
            this.colMaNVQL.Caption = "Mã nhân viên quản lý";
            this.colMaNVQL.FieldName = "MaNVQuanLi";
            this.colMaNVQL.Name = "colMaNVQL";
            this.colMaNVQL.Visible = true;
            this.colMaNVQL.VisibleIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 273);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 17);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "Tìm kiếm";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(113, 270);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Size = new System.Drawing.Size(245, 22);
            this.textEdit1.TabIndex = 51;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(367, 270);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(65, 22);
            this.simpleButton1.TabIndex = 52;
            this.simpleButton1.Text = "Xóa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // ucQuanLyChucVuNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridChucvu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucQuanLyChucVuNV";
            this.Size = new System.Drawing.Size(1050, 662);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTenCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNVQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridChucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraGrid.GridControl gridChucvu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCV;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCV;
        private DevExpress.XtraEditors.ComboBoxEdit cboTenCV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNVQL;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboMaNVQL;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnChuyenNVcuaTruongPhong;
    }
}
