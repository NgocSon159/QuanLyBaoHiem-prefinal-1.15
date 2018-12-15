namespace QuanLyBaoHiem
{
    partial class ucQuanLyCapDoKH
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.cboMaCV = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenCV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.khachHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCapDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHopDongs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiThans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHopDongs1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.cboMaCV);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTenKH);
            this.groupControl1.Controls.Add(this.txtMaKH);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtTenCV);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(14, 20);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1023, 239);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "Điền các thông tin";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(535, 183);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 32);
            this.btnHuy.TabIndex = 56;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.apply;
            this.btnLuu.Location = new System.Drawing.Point(419, 183);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 32);
            this.btnLuu.TabIndex = 55;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboMaCV
            // 
            this.cboMaCV.Enabled = false;
            this.cboMaCV.Location = new System.Drawing.Point(177, 46);
            this.cboMaCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaCV.Name = "cboMaCV";
            this.cboMaCV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaCV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMaCV.Size = new System.Drawing.Size(245, 22);
            this.cboMaCV.TabIndex = 54;
            this.cboMaCV.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(594, 101);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 16);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Tên Khách Hàng";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(723, 101);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.ReadOnly = true;
            this.txtTenKH.Properties.UseReadOnlyAppearance = false;
            this.txtTenKH.Size = new System.Drawing.Size(245, 22);
            this.txtTenKH.TabIndex = 51;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(723, 46);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.ReadOnly = true;
            this.txtMaKH.Properties.UseReadOnlyAppearance = false;
            this.txtMaKH.Size = new System.Drawing.Size(245, 22);
            this.txtMaKH.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(594, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Enabled = false;
            this.txtTenCV.Location = new System.Drawing.Point(177, 95);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Properties.ReadOnly = true;
            this.txtTenCV.Properties.UseReadOnlyAppearance = false;
            this.txtTenCV.Size = new System.Drawing.Size(245, 22);
            this.txtTenCV.TabIndex = 40;
            this.txtTenCV.EditValueChanged += new System.EventHandler(this.txtTenCV_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã Cấp Độ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(70, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cấp Độ";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.khachHangsBindingSource;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Location = new System.Drawing.Point(14, 266);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1023, 330);
            this.gridControl2.TabIndex = 36;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // khachHangsBindingSource
            // 
            this.khachHangsBindingSource.DataSource = typeof(QuanLyBaoHiem.Models.KhachHang);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colMaCD,
            this.colTenKH,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colSdt,
            this.colCMND,
            this.colHinhAnh,
            this.colCapDo,
            this.colHopDongs,
            this.colNguoiThans,
            this.colHopDongs1});
            this.gridView2.DetailHeight = 431;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Mã Khách Hàng";
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.MinWidth = 23;
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.OptionsColumn.ReadOnly = true;
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            this.colMaKH.Width = 87;
            // 
            // colMaCD
            // 
            this.colMaCD.Caption = "Mã Cấp Độ";
            this.colMaCD.FieldName = "MaCD";
            this.colMaCD.MinWidth = 23;
            this.colMaCD.Name = "colMaCD";
            this.colMaCD.OptionsColumn.ReadOnly = true;
            this.colMaCD.Visible = true;
            this.colMaCD.VisibleIndex = 2;
            this.colMaCD.Width = 87;
            // 
            // colTenKH
            // 
            this.colTenKH.Caption = "Tên Khách Hàng";
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.MinWidth = 23;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.OptionsColumn.ReadOnly = true;
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
            this.colTenKH.Width = 87;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 23;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 87;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.MinWidth = 23;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 87;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 23;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 87;
            // 
            // colSdt
            // 
            this.colSdt.FieldName = "Sdt";
            this.colSdt.MinWidth = 23;
            this.colSdt.Name = "colSdt";
            this.colSdt.Width = 87;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 23;
            this.colCMND.Name = "colCMND";
            this.colCMND.Width = 87;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.FieldName = "HinhAnh";
            this.colHinhAnh.MinWidth = 23;
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.Width = 87;
            // 
            // colCapDo
            // 
            this.colCapDo.Caption = "Tên Cấp Độ";
            this.colCapDo.FieldName = "CapDo.TenCD";
            this.colCapDo.MinWidth = 23;
            this.colCapDo.Name = "colCapDo";
            this.colCapDo.OptionsColumn.ReadOnly = true;
            this.colCapDo.Visible = true;
            this.colCapDo.VisibleIndex = 3;
            this.colCapDo.Width = 87;
            // 
            // colHopDongs
            // 
            this.colHopDongs.FieldName = "HopDongs";
            this.colHopDongs.MinWidth = 23;
            this.colHopDongs.Name = "colHopDongs";
            this.colHopDongs.Width = 87;
            // 
            // colNguoiThans
            // 
            this.colNguoiThans.FieldName = "NguoiThans";
            this.colNguoiThans.MinWidth = 23;
            this.colNguoiThans.Name = "colNguoiThans";
            this.colNguoiThans.Width = 87;
            // 
            // colHopDongs1
            // 
            this.colHopDongs1.FieldName = "HopDongs1";
            this.colHopDongs1.MinWidth = 23;
            this.colHopDongs1.Name = "colHopDongs1";
            this.colHopDongs1.Width = 87;
            // 
            // ucQuanLyCapDoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucQuanLyCapDoKH";
            this.Size = new System.Drawing.Size(1050, 615);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTenCV;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private System.Windows.Forms.BindingSource khachHangsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCD;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSdt;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHinhAnh;
        private DevExpress.XtraGrid.Columns.GridColumn colCapDo;
        private DevExpress.XtraGrid.Columns.GridColumn colHopDongs;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiThans;
        private DevExpress.XtraGrid.Columns.GridColumn colHopDongs1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.ComboBoxEdit cboMaCV;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}
