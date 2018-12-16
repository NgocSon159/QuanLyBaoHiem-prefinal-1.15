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
using System.Data.SqlClient;
using System.Data.Entity;
using QuanLyBaoHiem.DAO;
using Model.Dao;

namespace QuanLyBaoHiem
{
    public partial class ThemHopDong : DevExpress.XtraEditors.XtraForm
    {
        public string manvhientai = "";
        public ThemHopDong()
        {
            InitializeComponent();
                       
            

            
        }
        ucHopDong f;
        

        public ThemHopDong(string manvhientai1,ucHopDong uc)
        {
            InitializeComponent();
            manvhientai = manvhientai1;

            txtMaNV.Text = manvhientai;
            loadcombo();
            f = uc;
            dtmNgayHL.DateTime = DateTime.Now;
        }

        public void loadcombo()
        {
            GoiHopDongDao ghd = new GoiHopDongDao();
            foreach (var item in ghd.Load())
            {
                cboMaGHD.Properties.Items.Add(item.MaGoiHD);
            }

            HopDongDao hdd = new HopDongDao();
            txtMaHD.Text = hdd.getlasthopdong();

            ChuKyThanhToanDao cktt = new ChuKyThanhToanDao();
            foreach (var item in cktt.Load())
                cboMaCK.Properties.Items.Add(item.MaChuKy);

            KhachHangDao kh = new KhachHangDao();
            foreach (var item in kh.Load())
                cboMaKH.Properties.Items.Add(item.MaKH);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboMaCK.Text==""||cboMaGHD.Text==""||txtMaHD.Text==""||cboMaKH.Text==""||txtMaNV.Text==""||dtmNgayHL.Text=="")
                {
                    XtraMessageBox.Show("Bạn chưa điền đầy đủ thông tin!!");
                }
                else
                {
                    HopDongDao hd = new HopDongDao();
                    hd.ThemHD(txtMaHD.Text, cboMaGHD.Text, cboMaCK.Text, txtMaNV.Text, cboMaKH.Text, dtmNgayHL.Text);
                    XtraMessageBox.Show("Thêm Thành Công");
                    this.Close();
                    f.loaddatabase();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra","Thông báo");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {          
                this.Close();
        }

        private void ThemHopDong_Load(object sender, EventArgs e)
        {

        }
    }
}