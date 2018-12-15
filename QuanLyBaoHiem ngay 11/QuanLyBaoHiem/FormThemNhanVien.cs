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
using QuanLyBaoHiem.DAO;
using QuanLyBaoHiem.Models;
using STSShop.Common;

namespace QuanLyBaoHiem
{
    public partial class FormThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        QLBHContext db = new QLBHContext();
        List<ChucVu> listchucvu = new List<ChucVu>();
        ucQuanLyThongTinNhanVien f = new ucQuanLyThongTinNhanVien();
        public FormThemNhanVien()
        {
            InitializeComponent();
            
        }
        public FormThemNhanVien(ucQuanLyThongTinNhanVien ff)
        {
            InitializeComponent();
            
            f = ff;
        }



        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            loadcomboboxMaCVvacomboboxQuyenhanvacomboboxMaNVQL();
            NhanvienDao nvdao = new NhanvienDao();
            txtMaNV.Text = nvdao.getlastnhanvien();
        }
        public void loadcomboboxMaCVvacomboboxQuyenhanvacomboboxMaNVQL()
        {
            var listmacv = db.ChucVus.ToList();
            listchucvu = listmacv;
            
            foreach (var a in listmacv)
            {
                
                cboQuyenHan.Properties.Items.Add(a.TenCV);
            }
            string macv= db.NhanViens.Where(p => p.MaNV == f.manvhientai).Select(l => l.MaCV).SingleOrDefault();
            if(macv=="QL")
            {
                cboQuyenHan.SelectedIndex = 2;
            }
            else
            {
                cboQuyenHan.SelectedIndex = 0;
            }
            txtMaNVQL.Text = f.manvhientai;

        }

        private void cboMaCV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboQuyenHan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtHoTenNV.Text == "" || txtemail.Text == "" || txtDiaChi.Text == "" || txtSdt.Text == "" || dtngaysinh.Text == "")
                {
                    XtraMessageBox.Show("Hãy điền đầy đủ thông tin!");
                }
                else
                {
                    NhanVien nv = new NhanVien();
                    NhanvienDao nvdao = new NhanvienDao();
                    nv.MaNV = txtMaNV.Text;

                    string macv = db.ChucVus.Where(p => p.TenCV == cboQuyenHan.Text).Select(l => l.MaCV).SingleOrDefault();
                    nv.MaCV = macv;
                    nv.TenNV = txtHoTenNV.Text;
                    bool gioitinh = true;
                    if (cboGioiTinh.Text != "Nam")
                    {
                        gioitinh = false;
                    }
                    nv.GioiTinh = gioitinh;
                    nv.NgaySinh = dtngaysinh.DateTime; ;
                    nv.MaNVQuanLi = txtMaNVQL.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.Sdt = txtSdt.Text; ;
                    nv.MatKhau = MahoaMD5.getMd5Hash("123456");
                    nv.Email = txtemail.Text;
                    nv.Status = true;
                    nvdao.themnhanvien(nv);
                    XtraMessageBox.Show("Thêm thành công");
                    f.loadlaigridview();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string loi = ex.InnerException.ToString();
                string[] loichia = loi.Split('\n');
                string[] loichinh = loichia[0].Split(':');
                XtraMessageBox.Show(loichinh[2]);
            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}