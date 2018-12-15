namespace QuanLyBaoHiem
{
    partial class FormSetNVQLcon
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNV = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.cboMaNVQL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTenCV = new DevExpress.XtraEditors.TextEdit();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNVQL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNVQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 182);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(985, 257);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colTenCV,
            this.colMaNVQL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(538, 82);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(130, 17);
            this.labelControl2.TabIndex = 59;
            this.labelControl2.Text = "Mã nhân viên quản lý";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(204, 33);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMaNV.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaNV.Properties.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(245, 22);
            this.txtMaNV.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(75, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(693, 33);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenNV.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenNV.Properties.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(245, 22);
            this.txtTenNV.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(538, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tên chức vụ";
            // 
            // cboMaNVQL
            // 
            this.cboMaNVQL.Location = new System.Drawing.Point(693, 78);
            this.cboMaNVQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaNVQL.Name = "cboMaNVQL";
            this.cboMaNVQL.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cboMaNVQL.Properties.Appearance.Options.UseBackColor = true;
            this.cboMaNVQL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaNVQL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMaNVQL.Size = new System.Drawing.Size(245, 22);
            this.cboMaNVQL.TabIndex = 60;
            // 
            // txtTenCV
            // 
            this.txtTenCV.Enabled = false;
            this.txtTenCV.Location = new System.Drawing.Point(202, 79);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTenCV.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenCV.Size = new System.Drawing.Size(245, 22);
            this.txtTenCV.TabIndex = 56;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colTenNV
            // 
            this.colTenNV.Caption = "Tên nhân viên";
            this.colTenNV.FieldName = "TenNV";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 1;
            // 
            // colTenCV
            // 
            this.colTenCV.Caption = "Tên chức vụ";
            this.colTenCV.FieldName = "TenCV";
            this.colTenCV.Name = "colTenCV";
            this.colTenCV.Visible = true;
            this.colTenCV.VisibleIndex = 2;
            // 
            // colMaNVQL
            // 
            this.colMaNVQL.Caption = "Mã nhân viên quản lý";
            this.colMaNVQL.FieldName = "MaNVQuanLi";
            this.colMaNVQL.Name = "colMaNVQL";
            this.colMaNVQL.Visible = true;
            this.colMaNVQL.VisibleIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = global::QuanLyBaoHiem.Properties.Resources.cen1;
            this.btnHuy.Location = new System.Drawing.Point(536, 127);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 32);
            this.btnHuy.TabIndex = 62;
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
            this.btnLuu.Location = new System.Drawing.Point(414, 127);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 32);
            this.btnLuu.TabIndex = 61;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormSetNVQLcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 451);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaNVQL);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtTenCV);
            this.Name = "FormSetNVQLcon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chức vụ ";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaNVQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtTenNV;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.ComboBoxEdit cboMaNVQL;
        private DevExpress.XtraEditors.TextEdit txtTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNVQL;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}