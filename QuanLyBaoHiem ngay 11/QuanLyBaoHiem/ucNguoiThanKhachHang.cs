using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using QuanLyBaoHiem.Models;
using Model.Dao;
namespace QuanLyBaoHiem
{
    public partial class ucNguoiThanKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNguoiThanKhachHang()
        {
            InitializeComponent();
            NguoiThanDao ng = new NguoiThanDao();
            nguoiThansBindingSource.DataSource = ng.Load();
            

        }
        public void refresh()
        {
            NguoiThanDao ng = new NguoiThanDao();
            nguoiThansBindingSource.DataSource = ng.Load();
        }
        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            KhachHangDao kh = new KhachHangDao();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").Equals(true))
            {
                cboGioitinh.Text = "Nam";
            }
            else
            {
                cboGioitinh.Text = "Nữ";
            }
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"DiaChi").ToString();
            txtMaNT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNT").ToString();
            txtMaKHNT.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
            var result = kh.getKH(txtMaKHNT.Text);
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKHRieng")!=null)
            {
                txtMaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKHRieng").ToString();
            }
            else
            {
                txtMaKH.Text = "";
            }
            txtTenNTKH.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNT").ToString();
            txtCMND.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txtTenKH.Text = result.TenKH;
            if(gridView1.GetFocusedRowCellValue(colSDT)!=null)
            {
                txtSDT.Text = gridView1.GetFocusedRowCellValue(colSDT).ToString();
            }
            else
            {
                txtSDT.Text = "";
            }
            
            string ngaysinh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString();
            DateTime dateTime = DateTime.Parse(ngaysinh);
            txtNgaySinh.DateTime = dateTime;

            btnHuy.Visible = true;
            btnLuu.Visible = true;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemNT f = new ThemNT(this);
            f.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNT.Text == "" || txtMaKHNT.Text == "" || cboGioitinh.Text=="" || txtDiaChi.Text == "" || txtCMND.Text == "" || txtNgaySinh.Text == "" || txtTenKH.Text == "" || txtTenNTKH.Text == "")
                {
                    MessageBox.Show("Chọn Thông Tin Cần Sửa");
                }
                else
                {
                    var s = "";
                    s = cboGioitinh.Text;
                    
                    NguoiThanDao ng = new NguoiThanDao();
                    ng.suakhachhang(txtMaNT.Text, txtMaKHNT.Text, txtTenNTKH.Text, txtNgaySinh.DateTime, s, txtDiaChi.Text, txtCMND.Text, txtMaKH.Text,txtSDT.Text);
                    MessageBox.Show("Sửa Thành Công");
                    this.refresh();
                }
                //KhachHangDao kh = new KhachHangDao();
                //SuaKH f = new SuaKH(txtMaNT.Text, txtMaKH.Text, kh.GetCapDo(txtMaNT.Text), txtNgaySinh.Text, txtGioiTinh.Text, txtCMND.Text, txtDiaChi.Text, txtSdt.Text);
                //f.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chọn Khách Hàng Cần Sửa");
            }
            

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txtMaNT.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng!!");
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NguoiThanDao ng = new NguoiThanDao();
                    ng.xoanguothan(txtMaNT.Text);
                    XtraMessageBox.Show("Đã xóa thành công!!");
                    this.refresh();

                    resettext();


                }
            }
            
        }
        internal void popup(string txt)
        {
            txtTenKH.Text = txt;
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaKHNT_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaKHNT_Enter(object sender, EventArgs e)
        {

            
        }

        private void txtMaKH_Enter(object sender, EventArgs e)
        {
                
        }

        private void txtMaKH_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        private void txtMaKHNT_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMaKHNT_Properties_DragEnter(object sender, DragEventArgs e)
        {

           
        }

        private void txtMaKHNT_Properties_Enter(object sender, EventArgs e)
        {

           
        }

        private void txtMaKHNT_Properties_EditValueChanged(object sender, EventArgs e)
        {

           
        }

        private void txtMaKHNT_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KhachHangDao kh = new KhachHangDao();
                var result = kh.getKH(txtMaKHNT.Text);
                if (result == null)
                {
                    MessageBox.Show("Mã Khách Hàng Không Tồn Tại");
                    txtMaKHNT.Text = "";
                }
                else
                {
                    popup(result.TenKH);
                }
            }
        }

        private void txtMaKH_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KhachHangDao kh = new KhachHangDao();
                var result = kh.getKH(txtMaKH.Text);
                if (result == null)
                {
                    MessageBox.Show("Mã Khách Hàng Không Tồn Tại");
                    txtMaKH.Text = "";
                }
                else
                {
                    txtTenNTKH.Text = result.TenKH;
                    txtCMND.Text = result.CMND;
                    txtDiaChi.Text = result.DiaChi;
                    if (result.GioiTinh == true)
                    {
                        cboGioitinh.Text = "Nam";
                    }
                    else
                    {
                        cboGioitinh.Text = "Nữ";
                    }
                    DateTime dateTime = Convert.ToDateTime(result.NgaySinh);
                    txtNgaySinh.Text = dateTime.ToString("dd/MM/yyyy");
                }
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.Text==""||txtMaNT.Text == "" || txtMaKHNT.Text == "" || cboGioitinh.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == "" || txtNgaySinh.Text == "" || txtTenKH.Text == "" || txtTenNTKH.Text == "")
                {
                    MessageBox.Show("Chọn Thông Tin Cần Sửa");
                }
                else
                {
                    var s = "";
                    s = cboGioitinh.Text;

                    NguoiThanDao ng = new NguoiThanDao();
                    ng.suakhachhang(txtMaNT.Text, txtMaKHNT.Text, txtTenNTKH.Text, txtNgaySinh.DateTime, s, txtDiaChi.Text, txtCMND.Text, txtMaKH.Text,txtSDT.Text);
                    MessageBox.Show("Sửa Thành Công");
                    this.refresh();
                }
                //KhachHangDao kh = new KhachHangDao();
                //SuaKH f = new SuaKH(txtMaNT.Text, txtMaKH.Text, kh.GetCapDo(txtMaNT.Text), txtNgaySinh.Text, txtGioiTinh.Text, txtCMND.Text, txtDiaChi.Text, txtSdt.Text);
                //f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chọn Khách Hàng Cần Sửa");
            }
        }

        public void resettext()
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;

            txtDiaChi.Text = "";
            txtMaNT.Text = "";
            txtMaKHNT.Text = "";
            txtMaKH.Text = "";

            txtTenNTKH.Text = "";
            txtCMND.Text = "";
            txtTenKH.Text = "";

            txtNgaySinh.Text = "";
            cboGioitinh.Text = "";
            txtSDT.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;

            txtDiaChi.Text = "";
            txtMaNT.Text = "";
            txtMaKHNT.Text = "";
            txtMaKH.Text = "";
            
            txtTenNTKH.Text = "";
            txtCMND.Text = "";
            txtTenKH.Text = "";

            txtNgaySinh.Text = "";
            cboGioitinh.Text = "";
            txtSDT.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.refresh();
        }
    }
}
