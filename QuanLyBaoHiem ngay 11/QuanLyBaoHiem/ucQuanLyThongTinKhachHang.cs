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
using System.IO;
using QuanLyBaoHiem.DAO;

namespace QuanLyBaoHiem
{
    public partial class ucQuanLyThongTinKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        public string imaloc = "";
        public byte[] ima;
        public string manvhientai = "";
        public ucQuanLyThongTinKhachHang(string manvhientai1)
        {
            InitializeComponent();
            KhachHangDao kh = new KhachHangDao();
            khachHangsBindingSource.DataSource = kh.Load();
            manvhientai = manvhientai1;
            CapDoDao cd = new CapDoDao();
            foreach(var item in cd.GetTenCD())
            {
                cboTenCD.Properties.Items.Add(item);
            }
            checkxemaidangsudung(manvhientai);
        }

        public void checkxemaidangsudung(string manvhientai2)
        {
            NhanvienDao nvdao = new NhanvienDao();
            if (nvdao.getchucvutunhanvien(manvhientai) == "QL" || nvdao.getchucvutunhanvien(manvhientai) == "TP")
            {
                btnThemKH.Enabled = false;
                btnUpdate.Enabled = false;
                btnXoa.Enabled = false;
                btnExport.Enabled = true;
                settextboxchoadminvatruongphong();
            }
        }

        private void settextboxchoadminvatruongphong()
        {
            txtMaKH.ReadOnly = true;
            txtCMND.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtTenKH.ReadOnly = true;
            cboTenCD.ReadOnly = true;
            cboGioiTinh.ReadOnly = true;
            dtmNgaySinh.ReadOnly = true;
        }

        public void refresh()
        {
            KhachHangDao kh = new KhachHangDao();
            khachHangsBindingSource.DataSource = kh.Load();
        }
        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                NhanvienDao nvdao = new NhanvienDao();
                if (nvdao.getchucvutunhanvien(manvhientai) == "QL" || nvdao.getchucvutunhanvien(manvhientai) == "TP")
                {
                    btnLuu.Visible = false;
                    btnHuy.Visible = false;
                }
                else
                {
                    enabletextbox();
                    btnLuu.Visible = true;
                    btnHuy.Visible = true;
                }

                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").Equals(true))
                {
                    cboGioiTinh.Text = "Nam";
                }
                else
                {
                    cboGioiTinh.Text = "Nữ";
                }
                txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
                txtMaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
                txtTenKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH").ToString();
                cboTenCD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CapDo.TenCD").ToString();
                txtCMND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
                txtSdt.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sdt").ToString();
                var ngaysinh= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString();
                DateTime dateTime = DateTime.Parse(ngaysinh);
                dtmNgaySinh.Text = dateTime.ToString("dd/MM/yyyy");
                KhachHangDao kh = new KhachHangDao();
                var result = kh.getKH(txtMaKH.Text);
                if (result.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(result.HinhAnh);
                    imagebox.Image = Image.FromStream(ms);
                    ima = result.HinhAnh;
                }
                else imagebox.Image = null;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Đã Có Lỗi Xảy Ra","Thông Báo");
            }
            
        }

        public void enabletextbox()
        {
            txtDiaChi.Enabled = true;
            
            txtTenKH.Enabled = true;
            
            txtCMND.Enabled = true;
            txtSdt.Enabled = true;
            cboGioiTinh.Enabled = true;
            dtmNgaySinh.Enabled = true;
            btnDuyetAnh.Enabled = true;

        }

        public void disabletextbox()
        {
            txtDiaChi.Enabled = false;

            txtTenKH.Enabled = false;

            txtCMND.Enabled = false;
            txtSdt.Enabled = false;
            cboGioiTinh.Enabled = false;
            dtmNgaySinh.Enabled = false;
            btnDuyetAnh.Enabled = false;
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemKH f = new ThemKH(this);
            f.Show();
        }

        

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng!!","Thông Báo");
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    KhachHangDao kh = new KhachHangDao();
                    kh.xoakhachhang(txtMaKH.Text);
                    
                    XtraMessageBox.Show("Đã xóa thành công!!", "Thông Báo");
                    this.refresh();
                    resettextbox();


                }
            }

            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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
                    xulychuoibinary();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        internal void xulychuoibinary()
        {
            try
            {
                ima = null;
                FileStream fs = new FileStream(imaloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                ima = br.ReadBytes((int)fs.Length);
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Thông Báo");
            }
        }

        public void resettextbox()
        {
            btnLuu.Visible = false;
            btnHuy.Visible = false;

            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cboTenCD.Text = "";
            txtCMND.Text = "";
            txtSdt.Text = "";
            cboGioiTinh.Text = "";
            dtmNgaySinh.Text = "";
            imagebox.Image = null;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            disabletextbox();
            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cboTenCD.Text = "";
            txtCMND.Text = "";
            txtSdt.Text = "";
            cboGioiTinh.Text = "";
            dtmNgaySinh.Text = "";
            imagebox.Image = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "" || txtCMND.Text == "" || txtDiaChi.Text == "" || cboGioiTinh.Text == "" || dtmNgaySinh.Text == "" || txtSdt.Text == "" || cboTenCD.Text == "" || txtTenKH.Text == "")
                {
                    XtraMessageBox.Show("Mời Nhập Đủ Thông Tin", "Thông Báo");
                }
                else
                {
                    string MaCD;
                    KhachHangDao kh = new KhachHangDao();
                    CapDoDao cd = new CapDoDao();
                    MaCD = cd.MaCD(cboTenCD.Text);
                    kh.suakhachhang(txtMaKH.Text, txtTenKH.Text, MaCD, dtmNgaySinh.DateTime, cboGioiTinh.Text, txtDiaChi.Text, txtSdt.Text, txtCMND.Text, ima);
                    XtraMessageBox.Show("Sửa Thành Công", "Thông Báo");
                    this.refresh();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.refresh();
            disabletextbox();
            resettextbox();
        }

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx ";
                    if (saveDialog.ShowDialog() != DialogResult.Cancel)
                    {
                        string exportFilePath = saveDialog.FileName;
                        string fileExtenstion = new FileInfo(exportFilePath).Extension;

                        switch (fileExtenstion)
                        {
                            case ".xls":
                                gridView1.ExportToXls(exportFilePath);
                                break;
                            case ".xlsx":
                                gridView1.ExportToXlsx(exportFilePath);
                                break;

                            default:
                                break;
                        }

                        if (File.Exists(exportFilePath))
                        {
                            try
                            {
                                //Thử mở file và để chương trình chọn cách để export.
                                System.Diagnostics.Process.Start(exportFilePath);
                            }
                            catch
                            {
                                String msg = "Không thể mở file." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                                MessageBox.Show(msg, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            String msg = "File không thể lưu." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi" + ex.Message);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = "";
        }
    }
}
