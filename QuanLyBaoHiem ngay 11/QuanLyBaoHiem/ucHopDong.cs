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
using System.Data.SqlClient;
using System.Data.Entity;
using QuanLyBaoHiem.DAO;
using Model.Dao;
using System.IO;

namespace QuanLyBaoHiem
{
    public partial class ucHopDong : DevExpress.XtraEditors.XtraUserControl
    {
        public string manvhientai = "";
        public ucHopDong()
        {
            InitializeComponent();
            HopDongDao hd = new HopDongDao();
            hopDongsBindingSource.DataSource = hd.Load();
            
            GoiHopDongDao ghd = new GoiHopDongDao();
            foreach( var item in ghd.Load() )
            {
                cboMaGoiHD.Properties.Items.Add(item.MaGoiHD);
            }

            ChuKyThanhToanDao cktt = new ChuKyThanhToanDao();
            foreach ( var item in cktt.Load() )
                cboMaChuKy.Properties.Items.Add(item.MaChuKy);

            KhachHangDao kh = new KhachHangDao();
            foreach (var item in kh.Load())
                cboMaKH.Properties.Items.Add(item.MaKH);

                
        }
        
        
        public ucHopDong(string manvhientai1)
        {
            InitializeComponent();
            manvhientai = manvhientai1;

            loadcombo();
            checkxemaidangsudung(manvhientai);
            
        }

        public void loaddatabase()
        {
            HopDongDao hd = new HopDongDao();
            NhanvienDao nvd = new NhanvienDao();

            hopDongsBindingSource.DataSource = hd.loadtheoyeucau(nvd.getchucvutunhanvien(manvhientai), manvhientai);
        }

        public void loadcombo()
        {

            loaddatabase();
;
            GoiHopDongDao ghd = new GoiHopDongDao();
            foreach (var item in ghd.Load())
            {
                cboMaGoiHD.Properties.Items.Add(item.MaGoiHD);
            }

            ChuKyThanhToanDao cktt = new ChuKyThanhToanDao();
            foreach (var item in cktt.Load())
                cboMaChuKy.Properties.Items.Add(item.MaChuKy);

            KhachHangDao kh = new KhachHangDao();
            foreach (var item in kh.Load())
                cboMaKH.Properties.Items.Add(item.MaKH);
        }

        public void checkxemaidangsudung(string manvhientai2)
        {
            NhanvienDao nvdao = new NhanvienDao();
            if(nvdao.getchucvutunhanvien(manvhientai)=="QL" || nvdao.getchucvutunhanvien(manvhientai) == "TP")
            {
                btnThemHD.Enabled = false;
                btnUpdate.Enabled = false;
                btnXoa.Enabled = false;
                btnExport.Enabled = true;
                settextboxchoadminvatruongphong();
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            if(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD")==null)
            {
                txtMaHD.Text = "";
            }
            else
            {
                txtMaHD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaGoiHD") == null)
            {
                cboMaGoiHD.Text = "";
            }
            else
            {
                cboMaGoiHD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaGoiHD").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaChuKy") == null)
            {
                cboMaChuKy.Text = "";
            }
            else
            {
                cboMaChuKy.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaChuKy").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV") == null)
            {
                txtMaNV.Text = "";
            }
            else
            {
                txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKHChinh") == null)
            {
                cboMaKH.Text = "";
            }
            else
            {
                cboMaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKHChinh").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayHieuLuc") == null)
            {
                dtmNgayHieuLuc.Text="";
            }
            else
            {
                string ngayhieuluc = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayHieuLuc").ToString();
                DateTime ngaysinhnhat = DateTime.Parse(ngayhieuluc);
                dtmNgayHieuLuc.DateTime = ngaysinhnhat;

                
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GoiHopDong.MucPhi") == null)
            {
                txtMucPhi.Text = "";
            }
            else
            {
                txtMucPhi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GoiHopDong.MucPhi").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GoiHopDong.GiaTriBaoHiem") == null)
            {
                txtGiaTriBaoHiem.Text = "";
            }
            else
            {
                txtGiaTriBaoHiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GoiHopDong.GiaTriBaoHiem").ToString();
            }

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GoiHopDong.ThoiHanBaoHiem") == null)
            {
                txtThoiHanBaoHiem.Text = "";
            }
            else
            {
                txtThoiHanBaoHiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GoiHopDong.ThoiHanBaoHiem").ToString();
            }

            
            NhanvienDao nvdao = new NhanvienDao();
            if (nvdao.getchucvutunhanvien(manvhientai) == "QL" || nvdao.getchucvutunhanvien(manvhientai) == "TP" || gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD") == null)
            {
                btnSua.Visible = false;
                btnHuy.Visible = false;
            }
            else
            {
                dtmNgayHieuLuc.Enabled = true;
                cboMaChuKy.Enabled = true;
                cboMaGoiHD.Enabled = true;
                cboMaKH.Enabled = true;



                btnSua.Visible = true;
                btnHuy.Visible = true;
            }
            
        }
        
        public void settextboxchoadminvatruongphong()
        {
            btnSua.Visible = false;
            btnHuy.Visible = false;

            txtMaHD.ReadOnly = true;
            cboMaGoiHD.ReadOnly = true;
            cboMaChuKy.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            cboMaKH.ReadOnly = true;


            dtmNgayHieuLuc.ReadOnly= true;

            txtMucPhi.ReadOnly = true;
            txtGiaTriBaoHiem.ReadOnly = true;
            txtThoiHanBaoHiem.ReadOnly = true;
        }

        

        

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHD.Text == "" || cboMaGoiHD.Text == "" || cboMaChuKy.Text == "" || cboMaKH.Text == "" || txtMaNV.Text == "" || dtmNgayHieuLuc.Text == "")
                {
                    XtraMessageBox.Show("Điền Đầy Đủ Thông Tin","Thông báo");
                }
                else
                {
                    HopDongDao hd = new HopDongDao();
                    NhanvienDao nvd = new NhanvienDao();
                    hd.SuaHD(txtMaHD.Text, cboMaGoiHD.Text, cboMaChuKy.Text, txtMaNV.Text, cboMaKH.Text, dtmNgayHieuLuc.DateTime);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo");
                    hopDongsBindingSource.DataSource = hd.loadtheoyeucau(nvd.getchucvutunhanvien(manvhientai), manvhientai);
                    txtGiaTriBaoHiem.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GoiHopDong.GiaTriBaoHiem").ToString();

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng!!");
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HopDongDao hd = new HopDongDao();
                    NhanvienDao nvd = new NhanvienDao();
                    hd.XoaHD(txtMaHD.Text);
                    XtraMessageBox.Show("Đã xóa thành công!!");
                    hopDongsBindingSource.DataSource = hd.loadtheoyeucau(nvd.getchucvutunhanvien(manvhientai), manvhientai);
                    reset();


                }
            }
        }

        

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }

        

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            HopDongDao hd = new HopDongDao();
            hopDongsBindingSource.DataSource = hd.Load();          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            txtMaHD.Text = "";
            cboMaGoiHD.Text = "";
            cboMaChuKy.Text = "";
            txtMaNV.Text = "";
            cboMaKH.Text = "";
            dtmNgayHieuLuc.Text = "";
            txtMucPhi.Text = "";
            txtGiaTriBaoHiem.Text = "";
            txtThoiHanBaoHiem.Text = "";



            dtmNgayHieuLuc.Enabled = false;
            cboMaChuKy.Enabled = false;
            cboMaGoiHD.Enabled = false;
            cboMaKH.Enabled = false;
            btnSua.Visible = false;
            btnHuy.Visible = false;
        }

        //Thêm mới hợp đồng
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ThemHopDong thd = new ThemHopDong(manvhientai,this);
            thd.ShowDialog();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            loaddatabase();
            reset();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng!!");
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    HopDongDao hd = new HopDongDao();
                    hd.XoaHD(txtMaHD.Text);
                    
                    XtraMessageBox.Show("Đã xóa thành công!!");
                    loaddatabase();
                    reset();

                }
            }

            
            
        }

        

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(gridView1.RowCount>0)
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
                else
                {
                    XtraMessageBox.Show("Không có gì để export!!!");
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
