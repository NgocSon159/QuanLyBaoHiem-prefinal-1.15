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
using System.Data.Entity;
using QuanLyBaoHiem.Models;
using QuanLyBaoHiem.DAO;

namespace QuanLyBaoHiem
{
    public partial class FormSetNVQLcon : DevExpress.XtraEditors.XtraForm
    {
        List<string> listmanvcohucvuTP = new List<string>();
        QLBHContext db = new QLBHContext();
        string manvqlhientai = "";
        List<NhanVien> dsnhanviencanchuyenTP = new List<NhanVien>();
        ucQuanLyChucVuNV f;
        public FormSetNVQLcon(string manvql,ucQuanLyChucVuNV ff)
        {
            InitializeComponent();
            manvqlhientai = manvql;
            loaddatabase(manvql);
            loadcombo(manvql);
            loaddanhsach(manvql);
            f = ff;

        }

        public void loaddanhsach(string manvql)
        {
            NhanvienDao nvdao = new NhanvienDao();
            dsnhanviencanchuyenTP = nvdao.danhsachnhanviencuaTP(manvql);
        }

        public void loaddatabase(string manvql)
        {
            QuanLyBaoHiem.Models.QLBHContext dbContext = new QuanLyBaoHiem.Models.QLBHContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NhanViens.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = (from a in dbContext.NhanViens
                                         join b in dbContext.ChucVus
                                         on a.MaCV equals b.MaCV
                                         where a.Status == true && a.MaNVQuanLi==manvql

                                         select new
                                         {
                                             a.MaNV,
                                             a.TenNV,
                                             b.TenCV,
                                             a.MaCV,
                                             a.MaNVQuanLi
                                         }).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void refreshgridview()
        {
            QuanLyBaoHiem.Models.QLBHContext dbContext = new QuanLyBaoHiem.Models.QLBHContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NhanViens.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = (from a in dbContext.NhanViens
                                           join b in dbContext.ChucVus
                                           on a.MaCV equals b.MaCV
                                           where a.Status == true && a.MaNVQuanLi == manvqlhientai

                                           select new
                                           {
                                               a.MaNV,
                                               a.TenNV,
                                               b.TenCV,
                                               a.MaCV,
                                               a.MaNVQuanLi
                                           }).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void loadcombo(string manvql)
        {
            listmanvcohucvuTP = db.NhanViens.Where(p => p.Status == true).Where(p => p.MaCV == "TP")
                .Where(p=>p.MaNV!=manvql).Select(l=>l.MaNV).ToList();
            foreach (var item in listmanvcohucvuTP)
            {
                cboMaNVQL.Properties.Items.Add(item);
            }

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = gridView1.GetFocusedRowCellValue(colMaNV).ToString();
            txtTenNV.Text = gridView1.GetFocusedRowCellValue(colTenNV).ToString();
            txtTenCV.Text = gridView1.GetFocusedRowCellValue(colTenCV).ToString();
            cboMaNVQL.SelectedIndex = 0;

            btnHuy.Visible = true;
            btnLuu.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(dsnhanviencanchuyenTP.Count!=0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Nhân viên chưa được chuyển hết! Bạn có chắc chắn muốn thoát?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            NhanvienDao nvdao = new NhanvienDao();
            nvdao.suaMaNVQLCustom(txtMaNV.Text, cboMaNVQL.Text);
            XtraMessageBox.Show("Thay đổi thành công");
            refreshgridview();
            
            loaddanhsach(manvqlhientai);
            if(dsnhanviencanchuyenTP.Count==0)
            {
                DialogResult dialogResult = XtraMessageBox.Show("Bạn đã có thể chuyển chức vụ cho nhân viên " + manvqlhientai,"Thông báo", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    f.loaddatabse();
                    
                    this.Close();
                }
            }
        }
    }
}