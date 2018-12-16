using DevExpress.XtraEditors;
using Model.Dao;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace QuanLyBaoHiem
{
    public partial class ucQuanLyCapDoKH : DevExpress.XtraEditors.XtraUserControl
    {
        public ucQuanLyCapDoKH()
        {
            InitializeComponent();
            KhachHangDao kh = new KhachHangDao();
            khachHangsBindingSource.DataSource = kh.Load();
            refresh();
            CapDoDao cd = new CapDoDao();
            foreach(var item in cd.GetCapDo())
            {
                cboMaCV.Properties.Items.Add(item);
            }
        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(cboMaCV.Text==""||txtMaKH.Text==""||txtTenCV.Text==""||txtTenKH.Text=="")
                {
                    XtraMessageBox.Show("Chọn Thông Tin Khách Hàng Cần Sửa","Thông Báo");
                }
                else
                {
                    KhachHangDao kh = new KhachHangDao();
                    kh.SuaDoiCapDoKH(txtMaKH.Text, cboMaCV.Text);
                    XtraMessageBox.Show("Sửa Thành Công","Thông Báo");
                    this.refresh();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Mời Chọn Thông Tin Cần Sửa","Thông Báo");
            }
        }
        public void refresh()
        {
            KhachHangDao kh = new KhachHangDao();
            khachHangsBindingSource.DataSource = kh.Load();
        }
        private void labelControl1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            KhachHangDao kh = new KhachHangDao();
            khachHangsBindingSource.DataSource = kh.Load();
        }

        private void gridControl2_Click(object sender, System.EventArgs e)
        {
            cboMaCV.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaCD").ToString();
            txtTenKH.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "TenKH").ToString();
            txtMaKH.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaKH").ToString();
            txtTenCV.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "CapDo.TenCD").ToString();
            cboMaCV.Enabled = true;

            btnHuy.Visible = true;
            btnLuu.Visible = true;
        }

        private void txtTenCV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapDoDao cd = new CapDoDao();
            txtTenCV.Text = cd.TenCD(cboMaCV.Text);
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;

            cboMaCV.Enabled = false;
            cboMaCV.Text = "";
            txtMaKH.Text = "";
            txtTenCV.Text = "";
            txtTenKH.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboMaCV.Text == "" || txtMaKH.Text == "" || txtTenCV.Text == "" || txtTenKH.Text == "")
                {
                    XtraMessageBox.Show("Chọn Thông Tin Khách Hàng Cần Sửa","Thông Báo");
                }
                else
                {
                    KhachHangDao kh = new KhachHangDao();
                    kh.SuaDoiCapDoKH(txtMaKH.Text, cboMaCV.Text);
                    XtraMessageBox.Show("Sửa Thành Công","Thông Báo");
                    this.refresh();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Mời Chọn Thông Tin Cần Sửa","Thông Báo");
            }
        }
    }
}
