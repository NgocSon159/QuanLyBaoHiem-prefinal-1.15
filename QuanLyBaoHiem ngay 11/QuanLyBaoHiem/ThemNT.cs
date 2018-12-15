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
                    MessageBox.Show("Mời Nhập Đủ Thông Tin");
                }
                else
                {
                    if (cboMaKH.Text == txtMaKHRieng.Text)
                    {
                        MessageBox.Show("Nhập Lỗi Hai Mã Khách Hàng");
                    }
                    else
                    {
                        NguoiThanDao ng = new NguoiThanDao();
                        ng.ThemNT(txtMaNT.Text, cboMaKH.Text, txtTenNT.Text, txtNgaySinh.DateTime, txtGioiTinh.Text, txtDiaChi.Text, txtCMND.Text, txtMaKHRieng.Text,txtSDT.Text);
                        MessageBox.Show("Thêm Thành Công");
                        this.Close();
                    }
                }
                f.refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
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
            }
        }
        private void ThemNT_Load(object sender, EventArgs e)
        {
            themcombobox();
        }
    }
}