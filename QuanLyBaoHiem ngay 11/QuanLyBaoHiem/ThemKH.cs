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
namespace QuanLyBaoHiem
{
    public partial class ThemKH : DevExpress.XtraEditors.XtraForm
    {
        public string imaloc;
        public ucQuanLyThongTinKhachHang f;
        public ThemKH(ucQuanLyThongTinKhachHang ff)
        {
            InitializeComponent();
            CapDoDao cd = new CapDoDao();
            foreach(var item in cd.GetCapDo())
            {
                comboBoxEdit1.Properties.Items.Add(item);
            }
            f = ff;
            KhachHangDao kh = new KhachHangDao();
            txtMaKH.Text = kh.getlastkhachhang();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|BMP Files (*.bmp)|*.bmp";
                dlg.Title = "Chọn hình ảnh";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imaloc = dlg.FileName.ToString();
                    imagebox.ImageLocation = imaloc;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
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
                if (txtCMND.Text == "" || txtDiaChi.Text == "" || cboGioiTinh.Text == ""  || txtMaKH.Text == "" || txtNgaySinh.Text == "" || txtSdt.Text == "" || txtTenKH.Text == "" || comboBoxEdit1.Text == "")
                {
                    XtraMessageBox.Show("Mời Nhập Đủ Thông Tin","Thông Báo");
                }
                else
                {
                    KhachHangDao kh = new KhachHangDao();
                    kh.ThemKH(txtMaKH.Text, txtTenKH.Text, comboBoxEdit1.Text, txtNgaySinh.Text, cboGioiTinh.Text, txtDiaChi.Text, txtSdt.Text, txtCMND.Text, imaloc);
                    XtraMessageBox.Show("Thêm Thành Công","Thông Báo");
                    f.refresh();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Đã có lỗi xảy ra","Thông Báo");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}