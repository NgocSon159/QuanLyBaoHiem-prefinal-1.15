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
using Model.Dao;

namespace QuanLyBaoHiem
{
    public partial class ThemGoiHD : DevExpress.XtraEditors.XtraForm
    {
        ucThongTinChinhSachBaoHiem f;
        public ThemGoiHD()
        {
            InitializeComponent();
        }

        public ThemGoiHD(ucThongTinChinhSachBaoHiem ff)
        {
            InitializeComponent();
            f = ff;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtMaGHD.Text == "" || txtMucPhi.Text == "" || txtGiaTriBaoHiem.Text == "" ||
                        txtThoiHanBaoHiem.Text == "" || txtThoiHanDongPhi.Text == "")
                    XtraMessageBox.Show("Điền đầy đủ thông tin", "Thông báo");
                else
                {

                    GoiHopDongDao ghd = new GoiHopDongDao();
                    if (ghd.checkxemmaGHDtontai(txtMaGHD.Text) == 0)
                    {
                        ghd.ThemGHD(txtMaGHD.Text, Convert.ToDecimal(txtMucPhi.Text), Convert.ToDecimal(txtGiaTriBaoHiem.Text), Convert.ToInt32(txtThoiHanBaoHiem.Text), Convert.ToInt32(txtThoiHanDongPhi.Text));
                        XtraMessageBox.Show("Thêm thành công", "Thông báo");
                        f.refreshdata();
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã nhập vào đã có sẵn!!");
                    }

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

        private void btn_thoat_Click(object sender, EventArgs e)
        {           
                this.Close();
        }
    }
}