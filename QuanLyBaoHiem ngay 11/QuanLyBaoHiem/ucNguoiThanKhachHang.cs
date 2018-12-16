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
            txtTenKH.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNT").ToString();
            txtCMND.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txtTenKHNT.Text = result.TenKH;
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

            enabletextbox();

            btnHuy.Visible = true;
            btnLuu.Visible = true;
            
        }

        public void enabletextbox()
        {
            txtDiaChi.Enabled = true;

            txtMaKHNT.Enabled = true;
            txtMaKH.Enabled = true;

            txtTenKH.Enabled = true;
            txtCMND.Enabled = true;
            txtTenKHNT.Enabled = true;

            txtNgaySinh.Enabled = true;
            cboGioitinh.Enabled = true;
            txtSDT.Enabled = true;
        }

        public void disabletextbox()
        {
            txtDiaChi.Enabled = false ;

            txtMaKHNT.Enabled = false ;
            txtMaKH.Enabled = false ;

            txtTenKH.Enabled = false ;
            txtCMND.Enabled = false ;
            txtTenKHNT.Enabled = false ;

            txtNgaySinh.Enabled = false ;
            cboGioitinh.Enabled = false ;
            txtSDT.Enabled = false ;
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
                if (txtMaNT.Text == "" || txtMaKHNT.Text == "" || cboGioitinh.Text=="" || txtDiaChi.Text == "" || txtCMND.Text == "" || txtNgaySinh.Text == "" || txtTenKHNT.Text == "" || txtTenKH.Text == "")
                {
                    MessageBox.Show("Chọn Thông Tin Cần Sửa");
                }
                else
                {
                    var s = "";
                    s = cboGioitinh.Text;
                    NguoiThanDao ng = new NguoiThanDao();
                    if(txtMaKH.Text!=" ")
                    {
                        KhachHangDao kh = new KhachHangDao();
                        var model=kh.getKH(txtMaKH.Text);
                        Boolean gioitinh;
                        if (cboGioitinh.Text == "Nam")
                        {
                            gioitinh = true;
                        }
                        else gioitinh = false;
                        if(model.TenKH!=txtTenKH.Text||model.CMND!=txtCMND.Text||model.DiaChi!=txtDiaChi.Text||model.GioiTinh!=gioitinh||model.NgaySinh!=txtNgaySinh.DateTime||model.Sdt!=txtSDT.Text)
                        {
                            XtraMessageBox.Show("Thông tin người thân tồn tại khác với khách hàng đã có","Thông Báo");
                        }
                        else
                        {
                            ng.suakhachhang(txtMaNT.Text, txtMaKHNT.Text, txtTenKH.Text, txtNgaySinh.DateTime, s, txtDiaChi.Text, txtCMND.Text, txtMaKH.Text, txtSDT.Text);
                            XtraMessageBox.Show("Sửa Thành Công","Thông Báo");
                            this.refresh();
                        }
                    }
                    else
                    {
                        ng.suakhachhang(txtMaNT.Text, txtMaKHNT.Text, txtTenKH.Text, txtNgaySinh.DateTime, s, txtDiaChi.Text, txtCMND.Text, txtMaKH.Text, txtSDT.Text);
                        MessageBox.Show("Sửa Thành Công");
                        this.refresh();
                    }
                    
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
                XtraMessageBox.Show("Bạn chưa chọn dòng!!","Thông Báo");
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NguoiThanDao ng = new NguoiThanDao();
                    ng.xoanguothan(txtMaNT.Text);
                    XtraMessageBox.Show("Đã xóa thành công!!","Thông Báo");
                    this.refresh();

                    resettext();


                }
            }
            
        }
        internal void popup(string txt)
        {
            txtTenKHNT.Text = txt;
        }
        

        private void txtMaKHNT_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KhachHangDao kh = new KhachHangDao();
                var result = kh.getKH(txtMaKHNT.Text);
                if (result == null)
                {
                    XtraMessageBox.Show("Mã Khách Hàng Không Tồn Tại","Thông Báo");
                    NguoiThanDao ng = new NguoiThanDao();
                    var model = ng.getNT(txtMaNT.Text);
                    txtMaKHNT.Text = model.MaKH;
                    txtTenKHNT.Text = kh.TenKH(model.MaKH);
                    txtMaKH.Text = model.MaKHRieng;
                    txtTenKH.Text = model.TenNT;
                    txtCMND.Text = model.CMND;
                    if(model.GioiTinh==true)
                    {
                        cboGioitinh.Text = "Nam";
                    }
                    else
                    {
                        cboGioitinh.Text = "Nữ";
                    }
                    txtDiaChi.Text = model.DiaChi;
                    txtSDT.Text = model.SDT;
                    txtNgaySinh.DateTime = Convert.ToDateTime(model.NgaySinh);
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
                    XtraMessageBox.Show("Mã Khách Hàng Không Tồn Tại","Thông Báo");
                    NguoiThanDao ng = new NguoiThanDao();
                    var model = ng.getNT(txtMaNT.Text);
                    txtMaKHNT.Text = model.MaKH;
                    txtTenKHNT.Text = kh.TenKH(model.MaKH);
                    txtMaKH.Text = model.MaKHRieng;
                    txtTenKH.Text = model.TenNT;
                    txtCMND.Text = model.CMND;
                    if (model.GioiTinh == true)
                    {
                        cboGioitinh.Text = "Nam";
                    }
                    else
                    {
                        cboGioitinh.Text = "Nữ";
                    }
                    txtDiaChi.Text = model.DiaChi;
                    txtSDT.Text = model.SDT;
                    txtNgaySinh.DateTime = Convert.ToDateTime(model.NgaySinh);
                }
                else
                {
                    txtTenKH.Text = result.TenKH;
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
                if (txtSDT.Text==""||txtMaNT.Text == "" || txtMaKHNT.Text == "" || cboGioitinh.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == "" || txtNgaySinh.Text == "" || txtTenKHNT.Text == "" || txtTenKH.Text == "")
                {
                    XtraMessageBox.Show("Chọn Thông Tin Cần Sửa","Thông Báo");
                }
                else
                {
                    var s = "";
                    s = cboGioitinh.Text;
                    NguoiThanDao ng = new NguoiThanDao();
                    if (txtMaKH.Text != "")
                    {
                        KhachHangDao kh = new KhachHangDao();
                        var model = kh.getKH(txtMaKH.Text);
                        Boolean gioitinh;
                        if (cboGioitinh.Text == "Nam")
                        {
                            gioitinh = true;
                        }
                        else gioitinh = false;
                        if (model != null)
                        {
                            DateTime dateTime = Convert.ToDateTime(model.NgaySinh);
                            if (model.TenKH != txtTenKH.Text || model.CMND != txtCMND.Text || model.DiaChi != txtDiaChi.Text || model.GioiTinh != gioitinh || dateTime != txtNgaySinh.DateTime || model.Sdt != txtSDT.Text)
                            {
                                XtraMessageBox.Show("Thông tin người thân tồn tại khác với khách hàng đã có", "Thông Báo");
                            }
                            else
                            {
                                ng.suakhachhang(txtMaNT.Text, txtMaKHNT.Text, txtTenKH.Text, txtNgaySinh.DateTime, s, txtDiaChi.Text, txtCMND.Text, txtMaKH.Text, txtSDT.Text);
                                XtraMessageBox.Show("Sửa Thành Công", "Thông Báo");
                                this.refresh();
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Khách Hàng Không Tồn Tại","Thông Báo");
                            var model2 = ng.getNT(txtMaNT.Text);
                            txtMaKHNT.Text = model2.MaKH;
                            txtTenKHNT.Text = kh.TenKH(model2.MaKH);
                            txtMaKH.Text = model2.MaKHRieng;
                            txtTenKH.Text = model2.TenNT;
                            txtCMND.Text = model2.CMND;
                            if (model2.GioiTinh == true)
                            {
                                cboGioitinh.Text = "Nam";
                            }
                            else
                            {
                                cboGioitinh.Text = "Nữ";
                            }
                            txtDiaChi.Text = model2.DiaChi;
                            txtSDT.Text = model2.SDT;
                            txtNgaySinh.DateTime = Convert.ToDateTime(model2.NgaySinh);
                        }
                    }
                    else
                    {
                        ng.suakhachhang(txtMaNT.Text, txtMaKHNT.Text, txtTenKH.Text, txtNgaySinh.DateTime, s, txtDiaChi.Text, txtCMND.Text, txtMaKH.Text, txtSDT.Text);
                        XtraMessageBox.Show("Sửa Thành Công","Thông Báo");
                        this.refresh();
                    }
                }
                //KhachHangDao kh = new KhachHangDao();
                //SuaKH f = new SuaKH(txtMaNT.Text, txtMaKH.Text, kh.GetCapDo(txtMaNT.Text), txtNgaySinh.Text, txtGioiTinh.Text, txtCMND.Text, txtDiaChi.Text, txtSdt.Text);
                //f.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Chọn Khách Hàng Cần Sửa","Thông Báo");
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

            txtTenKH.Text = "";
            txtCMND.Text = "";
            txtTenKHNT.Text = "";

            txtNgaySinh.Text = "";
            cboGioitinh.Text = "";
            txtSDT.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;
            disabletextbox();
            txtDiaChi.Text = "";
            txtMaNT.Text = "";
            txtMaKHNT.Text = "";
            txtMaKH.Text = "";
            
            txtTenKH.Text = "";
            txtCMND.Text = "";
            txtTenKHNT.Text = "";

            txtNgaySinh.Text = "";
            cboGioitinh.Text = "";
            txtSDT.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.refresh();
            disabletextbox();
            resettext();
        }
    }
}
