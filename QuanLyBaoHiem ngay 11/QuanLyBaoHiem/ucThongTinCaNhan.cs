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
using QuanLyBaoHiem.Models;
using QuanLyBaoHiem.DAO;

namespace QuanLyBaoHiem
{
    public partial class ucThongTinCaNhan : DevExpress.XtraEditors.XtraUserControl
    {
        QLBHContext db = new QLBHContext();
        frmMain f;
        public ucThongTinCaNhan()
        {
            InitializeComponent();
        }
        public ucThongTinCaNhan(string manv,frmMain ff)
        {
            InitializeComponent();
            f = ff;
            loadcomboboxMaCVvacomboboxQuyenhanvacomboboxMaNVQL();
            
            setalltextboxUneditable();
            setdatalentextbox(manv);

        }
        public void setdatalentextbox(string manv)
        {
            QLBHContext moi = new QLBHContext();
            NhanVien nv = moi.NhanViens.Find(manv);

            txtMaNV.Text = nv.MaNV;
            cboMaCV.Text = nv.MaCV;
            txtHoTenNV.Text = nv.TenNV;
            txtDiaChi.Text = nv.DiaChi;
            rdioGioiTinh.SelectedIndex = 1;
            if (nv.GioiTinh == true)
            {
                rdioGioiTinh.SelectedIndex = 0;
            }


            dtngaysinh.DateTime = (DateTime)nv.NgaySinh;
            cboMaNVQL.Text = nv.MaNVQuanLi;
            txtSdt.Text = nv.Sdt;
        }



        public void setalltextboxUneditable()
        {
            
            txtMaNV.BackColor = System.Drawing.SystemColors.Window;
            txtMaNV.ForeColor = Color.Black;

            
            txtHoTenNV.BackColor = System.Drawing.SystemColors.Window;
            txtHoTenNV.ForeColor = Color.Black;

            cboMaCV.BackColor = System.Drawing.SystemColors.Window;
            cboMaCV.ForeColor = Color.Black;

            rdioGioiTinh.ReadOnly = true;
            
            dtngaysinh.BackColor = System.Drawing.SystemColors.Window;
            dtngaysinh.ForeColor = Color.Black;

            cboMaNVQL.BackColor = System.Drawing.SystemColors.Window;
            cboMaNVQL.ForeColor = Color.Black;

            txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            txtDiaChi.ForeColor = Color.Black;

            txtSdt.BackColor = System.Drawing.SystemColors.Window;
            txtSdt.ForeColor = Color.Black;
            
            cboQuyenHan.BackColor = System.Drawing.SystemColors.Window;
            cboQuyenHan.ForeColor = Color.Black;

            //visible 2 button
            btLuu.Visible = false;
            btHuy.Visible = false;

            //disalble những trường cần thiết
            txtHoTenNV.Enabled = false;
            rdioGioiTinh.ReadOnly = false;
            dtngaysinh.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSdt.Enabled = false;

        }
        public void loadcomboboxMaCVvacomboboxQuyenhanvacomboboxMaNVQL()
        {
            var listmacv = db.ChucVus.ToList();
            var listmanvql = db.NhanViens.ToList();
            foreach (var a in listmacv)
            {
                cboMaCV.Properties.Items.Add(a.MaCV);
                cboQuyenHan.Properties.Items.Add(a.TenCV);
            }
            foreach (var a in listmanvql)
            {
                cboMaNVQL.Properties.Items.Add(a.MaNV);
            }
        }

        private void cboMaCV_TextChanged(object sender, EventArgs e)
        {
            int sothutu = cboMaCV.SelectedIndex;
            cboQuyenHan.SelectedIndex = sothutu;
        }

        private void cboQuyenHan_TextChanged(object sender, EventArgs e)
        {
            int sothutu = cboQuyenHan.SelectedIndex;
            cboMaCV.SelectedIndex = sothutu;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btLuu.Visible = true;
            btHuy.Visible = true;
            btSua.Visible = false;

            ////////////////////////////////////
            txtHoTenNV.Enabled = true;
            rdioGioiTinh.ReadOnly = false;
            dtngaysinh.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSdt.Enabled = true;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            
            setdatalentextbox(txtMaNV.Text);
            setalltextboxUneditable();
            btSua.Visible = true;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn thay đổi?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    NhanvienDao nvdao = new NhanvienDao();
                    bool gioitinh = true;
                    if (rdioGioiTinh.SelectedIndex == 1)
                    {
                        gioitinh = false;
                    }
                    nvdao.suathongtincanhan(txtMaNV.Text, txtHoTenNV.Text, txtSdt.Text, gioitinh, txtDiaChi.Text, dtngaysinh.DateTime);

                    XtraMessageBox.Show("Đã sửa thành công!!");
                    //f.tattab();
                    
                    setalltextboxUneditable();
                    
                    btSua.Visible = true;
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
    }
}
