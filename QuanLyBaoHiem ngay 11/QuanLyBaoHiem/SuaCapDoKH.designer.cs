namespace QuanLyBaoHiem
{
    partial class SuaCapDoKH
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuaCapDoKH));
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.capDoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaCD = new DevExpress.XtraEditors.TextEdit();
            this.txtTenCD = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capDoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(232, 49);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(128, 20);
            this.txtMaKH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.capDoesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(422, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 404);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // capDoesBindingSource
            // 
            this.capDoesBindingSource.DataSource = typeof(Models.CapDo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCD,
            this.colTenCD});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaCD
            // 
            this.colMaCD.Caption = "Mã Cấp Độ";
            this.colMaCD.FieldName = "MaCD";
            this.colMaCD.Name = "colMaCD";
            this.colMaCD.OptionsColumn.ReadOnly = true;
            this.colMaCD.Visible = true;
            this.colMaCD.VisibleIndex = 0;
            // 
            // colTenCD
            // 
            this.colTenCD.Caption = "Tên Cấp Độ";
            this.colTenCD.FieldName = "TenCD";
            this.colTenCD.Name = "colTenCD";
            this.colTenCD.OptionsColumn.ReadOnly = true;
            this.colTenCD.Visible = true;
            this.colTenCD.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Cấp Độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Cấp Độ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(232, 103);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(128, 20);
            this.txtTenKH.TabIndex = 6;
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(232, 159);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Properties.ReadOnly = true;
            this.txtMaCD.Size = new System.Drawing.Size(128, 20);
            this.txtMaCD.TabIndex = 7;
            // 
            // txtTenCD
            // 
            this.txtTenCD.Location = new System.Drawing.Point(232, 216);
            this.txtTenCD.Name = "txtTenCD";
            this.txtTenCD.Properties.ReadOnly = true;
            this.txtTenCD.Size = new System.Drawing.Size(128, 20);
            this.txtTenCD.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(119, 298);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(92, 35);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(268, 298);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(92, 35);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // SuaCapDoKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 404);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtTenCD);
            this.Controls.Add(this.txtMaCD);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaKH);
            this.Name = "SuaCapDoKH";
            this.Text = "Sửa Cấp Độ Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capDoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaCD;
        private DevExpress.XtraEditors.TextEdit txtTenCD;
        private System.Windows.Forms.BindingSource capDoesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCD;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCD;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}