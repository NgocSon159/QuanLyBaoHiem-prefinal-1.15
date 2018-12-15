namespace QuanLyBaoHiem
{
    partial class ucThongBaoHopDong
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
            this.txtMaKH = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKH = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGoiHopDong = new DevExpress.XtraEditors.TextEdit();
            this.txtMucPhi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGoiHopDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucPhi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(18, 27);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Properties.ReadOnly = true;
            this.txtMaKH.Properties.UseReadOnlyAppearance = false;
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(141, 27);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Properties.ReadOnly = true;
            this.txtTenKH.Properties.UseReadOnlyAppearance = false;
            this.txtTenKH.Size = new System.Drawing.Size(225, 20);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaGoiHopDong
            // 
            this.txtMaGoiHopDong.Location = new System.Drawing.Point(391, 27);
            this.txtMaGoiHopDong.Name = "txtMaGoiHopDong";
            this.txtMaGoiHopDong.Properties.ReadOnly = true;
            this.txtMaGoiHopDong.Properties.UseReadOnlyAppearance = false;
            this.txtMaGoiHopDong.Size = new System.Drawing.Size(139, 20);
            this.txtMaGoiHopDong.TabIndex = 3;
            this.txtMaGoiHopDong.EditValueChanged += new System.EventHandler(this.txtNgaySinh_EditValueChanged);
            // 
            // txtMucPhi
            // 
            this.txtMucPhi.Location = new System.Drawing.Point(549, 27);
            this.txtMucPhi.Name = "txtMucPhi";
            this.txtMucPhi.Properties.ReadOnly = true;
            this.txtMucPhi.Properties.UseReadOnlyAppearance = false;
            this.txtMucPhi.Size = new System.Drawing.Size(100, 20);
            this.txtMucPhi.TabIndex = 4;
            // 
            // ucThongBaoHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMucPhi);
            this.Controls.Add(this.txtMaGoiHopDong);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Name = "ucThongBaoHopDong";
            this.Size = new System.Drawing.Size(793, 76);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGoiHopDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMucPhi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtMaKH;
        private DevExpress.XtraEditors.TextEdit txtTenKH;
        private DevExpress.XtraEditors.TextEdit txtMaGoiHopDong;
        private DevExpress.XtraEditors.TextEdit txtMucPhi;
    }
}
