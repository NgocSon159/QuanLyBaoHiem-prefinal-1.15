using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model.Dao;
using QuanLyBaoHiem.Models;

namespace QuanLyBaoHiem
{
    public partial class ThemNT : DevExpress.XtraEditors.XtraForm
    {
        public ucNguoiThanKhachHang f;
        QLBHContext db = new QLBHContext();
        public ThemNT(ucNguoiThanKhachHang ff)
        {
            InitializeComponent();
            f = ff;
            NguoiThanDao ng = new NguoiThanDao();
            txtMaNT.Text = ng.getlastnguoithan();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                txtMaKHRieng.Text = fileToOpen;
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.Text==""||txtCMND.Text == "" || txtDiaChi.Text == "" || txtGioiTinh.Text == ""  || txtMaNT.Text == "" || txtNgaySinh.Text == ""  || cboMaKH.Text == ""||txtTenNT.Text=="" )
                {
                    XtraMessageBox.Show("Mời Nhập Đủ Thông Tin","Thông Báo");
                }
                else
                {
                    if (cboMaKH.Text == txtMaKHRieng.Text)
                    {
                        MessageBox.Show("Nhập Lỗi Hai Mã Khách Hàng","Thông Báo");
                    }
                    else
                    {
                        if(txtMaKHRieng.Text=="")
                        {
                            NguoiThanDao ng = new NguoiThanDao();
                            ng.ThemNT(txtMaNT.Text, cboMaKH.Text, txtTenNT.Text, txtNgaySinh.DateTime, txtGioiTinh.Text, txtDiaChi.Text, txtCMND.Text, txtMaKHRieng.Text, txtSDT.Text);
                            XtraMessageBox.Show("Thêm Thành Công","Thông Báo");
                            this.Close();
                        }
                        else
                        {
                            KhachHangDao kh = new KhachHangDao();
                            var model=kh.getKH(txtMaKHRieng.Text);
                            string gioitinh;
                            if (model.GioiTinh == true)
                            {
                                gioitinh = "Nam";
                            }
                            else gioitinh = "Nữ";
                            DateTime dateTime = Convert.ToDateTime(model.NgaySinh);
                            if(model.TenKH!=txtTenNT.Text||dateTime!=txtNgaySinh.DateTime||model.Sdt!=txtSDT.Text||model.DiaChi!=txtDiaChi.Text||gioitinh!=txtGioiTinh.Text||model.CMND!=txtCMND.Text)
                            {
                                XtraMessageBox.Show("Thông Tin Người Thân Bị Sai", "Thông Báo");
                                laythongtin();
                            }
                            else
                            {
                                NguoiThanDao ng = new NguoiThanDao();
                                ng.ThemNT(txtMaNT.Text, cboMaKH.Text, txtTenNT.Text, txtNgaySinh.DateTime, txtGioiTinh.Text, txtDiaChi.Text, txtCMND.Text, txtMaKHRieng.Text, txtSDT.Text);
                                XtraMessageBox.Show("Thêm Thành Công","Thông Báo");
                                this.Close();
                            }
                        }
                        
                    }
                }
                f.refresh();
            }
            catch (Exception ex)
            {
                string loi = ex.InnerException.ToString();
                string[] loichia = loi.Split('\n');
                string[] loichinh = loichia[0].Split(':');
                XtraMessageBox.Show(loichinh[2]);
            }
        }
        private void laythongtin()
        {
            KhachHangDao kh = new KhachHangDao();
            var model = kh.getKH(txtMaKHRieng.Text);
            txtTenNT.Text = model.TenKH;
            txtNgaySinh.DateTime = Convert.ToDateTime(model.NgaySinh);
            txtSDT.Text = model.Sdt;
            txtDiaChi.Text = model.DiaChi;
            if (model.GioiTinh == true)
            {
                txtGioiTinh.Text = "Nam";
            }
            else
            {
                txtGioiTinh.Text = "Nữ";
            }
            txtCMND.Text = model.CMND;
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void themcombobox()
        {
            List<string> listmakh = new List<string>();
            listmakh = db.KhachHangs.Where(p => p.Status == true).Select(l => l.MaKH).ToList();
            foreach (var item in listmakh)
            {
                cboMaKH.Properties.Items.Add(item);
                txtMaKHRieng.Properties.Items.Add(item);
            }
            
            
        }
        private void ThemNT_Load(object sender, EventArgs e)
        {
            themcombobox();
        }

        private void txtDiaChi_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void clear(ComboBoxEdit comboBoxEdit)
        {
            comboBoxEdit.Properties.Items.Clear();
        }
        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = cboMaKH.Text;
            clear(txtMaKHRieng);
            List<string> listmakh = new List<string>();
            listmakh = db.KhachHangs.Where(p => p.Status == true).Select(l => l.MaKH).ToList();
            foreach(var item in listmakh)
            {
                if(item!=temp)
                {
                    txtMaKHRieng.Properties.Items.Add(item);
                }
            }
        }

        private void txtMaKHRieng_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKHRieng_SelectedIndexChanged(object sender, EventArgs e)
        {
            var temp = txtMaKHRieng.Text;
            clear(cboMaKH);
            List<string> listmakh = new List<string>();
            listmakh = db.KhachHangs.Where(p => p.Status == true).Select(l => l.MaKH).ToList();
            foreach (var item in listmakh)
            {
                if (item != temp)
                {
                    cboMaKH.Properties.Items.Add(item);
                }
            }
            KhachHangDao kh = new KhachHangDao();
            var model=kh.getKH(txtMaKHRieng.Text);
            txtTenNT.Text = model.TenKH;
            txtNgaySinh.DateTime = Convert.ToDateTime(model.NgaySinh);
            txtSDT.Text = model.Sdt;
            txtDiaChi.Text = model.DiaChi;
            if(model.GioiTinh==true)
            {
                txtGioiTinh.Text = "Nam";
            }
            else
            {
                txtGioiTinh.Text = "Nữ";
            }
            txtCMND.Text = model.CMND;
        }
    }
}