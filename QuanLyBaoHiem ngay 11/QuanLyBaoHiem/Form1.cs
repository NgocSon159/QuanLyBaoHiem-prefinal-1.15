using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBaoHiem;
using DevExpress.XtraTab;
using QuanLyBaoHiem.DAO;
using System.Diagnostics;

namespace QuanLyBaoHiem
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       
        //public static string user;
       

        public string taikhoanhientai = "";
        public string matkhauhientai = "";

        public frmMain()
        {
            InitializeComponent();
            DisEndMenuLogin(true);
            tattab();

        }
        public frmMain(string tentaikhoan,string matkhau)
        {
            InitializeComponent();
            DisEndMenuLogin(true);
            taikhoanhientai = tentaikhoan;
            matkhauhientai = matkhau;
            tattab();
            this.Text += " ["+taikhoanhientai+"]" ;
        }


        //bien IdLogin de sau nay phat trien lam phan quyen;
        public void DisEndMenuLogin(bool e)
        {
            btnLogin.Enabled = e;
            btnChangePass.Enabled = e;
            btnLogout.Enabled = e;
            btnQuanLyCapDoKH.Enabled = e;
            btnQuanLyThongTinNV.Enabled = e;
            btnThongTinKhachHang.Enabled = e;
            btnThongTinNhanVien.Enabled = e;
            btnQuanLyThongTinNV.Enabled = e;
            btnInfor.Enabled = e;
           
        }

        public void phanquyenQuanLy()
        {
            btnLogin.Links[0].Visible = false;

            btnThongTinNhanVien.Links[0].Visible = false;

        }
        public void phanquyenTruongPhong()
        {
            btnLogin.Links[0].Visible = false;
            btnQuanLyThongTinNV.Links[0].Visible = true;
            
            btnQuanLyChucVu.Links[0].Visible = false;
            btnQuanlyCapdo.Links[0].Visible = false;
            btnThongTinGoiHopDong.Links[0].Visible = false;
            btnThongTinChuKyThanhToan.Links[0].Visible = false;
            btnQuanLyCapDoKH.Links[0].Visible = false;
            btnThongTinNhanVien.Links[0].Visible = false;
            ribbonThongke.Visible = false;
            ribbonSaoluu.Visible = false;
        }
        public void phanquyenNhanVien()
        {

            btnLogin.Links[0].Visible = false;
            btnQuanLyThongTinNV.Links[0].Visible = false;
            btnThongTinGoiHopDong.Links[0].Visible = false;
            btnThongTinChuKyThanhToan.Links[0].Visible = false;

            btnQuanLyChucVu.Links[0].Visible = false;
            btnQuanlyCapdo.Links[0].Visible = false;
            btnQuanLyCapDoKH.Links[0].Visible = false;

            ribbonPage2.Visible = false;    //tab Nhân viên
            ribbonThongke.Visible = false;
            ribbonSaoluu.Visible = false;
            ribbonPageGroup2.Visible = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            skins();
            // frmLogin frmLogin = new frmLogin();
            // frmLogin.ShowDialog();// show cùng lúc 2 Form
        }


        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Foggy";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("QuanLyBaoHiem"))
                {
                    process.Kill();
                }
            }
        }
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = null;
        Check_Login:
            if (login == null || login.IsDisposed)
                login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtUser.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập UserName !");
                    goto Check_Login;
                }
                if (login.txtPass.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng nhập Password !");
                    goto Check_Login;
                }

            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisEndMenuLogin(true);
                btnLogin_ItemClick(sender, e);
            }
        }

        private void btnLogout_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            taikhoanhientai = "";
            matkhauhientai = "";
            this.Text = "Quản Lý Bảo Hiểm";
            frmLogin frmLogin = new frmLogin();
            this.Hide(); //ẩn formMain
            frmLogin.Show(); //sử dụng Show thôi
        }

        private void tabMain_CloseButtonClick(object sender, EventArgs e)
        {
            tabMain.TabPages.RemoveAt(tabMain.SelectedTabPageIndex);
            tabMain.SelectedTabPageIndex = tabMain.TabPages.Count - 1;
        }

        private void tabMain_ControlAdded(object sender, ControlEventArgs e)
        {
            tabMain.SelectedTabPageIndex = tabMain.TabPages.Count - 1; 
        }

        private void AddTabControl(UserControl userControl, string itemTabName, string icon)
        {
            bool isExist = false;
            int soluong = tabMain.TabPages.Count;
            if(soluong!=0)
            {
                tabMain.TabPages.RemoveAt(soluong - 1);
            }
            
            if (isExist == false)
            {
                AddTab addTab = new AddTab();
                addTab.AddTabControl(tabMain, itemTabName, icon, userControl);
            }
            
            
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucDoiMatKhau ucDoiMatKhau = new ucDoiMatKhau(taikhoanhientai,matkhauhientai,this);
            AddTabControl(ucDoiMatKhau, "Đổi mật khẩu", "");
        }

        private void btnQuanLyThongTinNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucQuanLyThongTinNhanVien ucKhachHang = new ucQuanLyThongTinNhanVien(taikhoanhientai);
            AddTabControl(ucKhachHang, "Quản Lý Nhân Viên", "");
        }

        private void btnThongTinKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucThongBaoSinhNhat ucThongBaoSinhNhat = new ucThongBaoSinhNhat();
            AddTabControl(ucThongBaoSinhNhat, "Thông Báo Sinh Nhật", "");
        }

        private void btnThongTinNguoiThan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucThongBaoDongHoaDon uc = new ucThongBaoDongHoaDon();
            AddTabControl(uc, "Thông Báo Đóng Hóa Đơn", "");
        }

        private void btnCaNhanNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnInfor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucThongTinCaNhan ucThongTinCaNhan = new ucThongTinCaNhan(taikhoanhientai,this);
            AddTabControl(ucThongTinCaNhan, "Thông tin cá nhân", "");
        }

        private void btnQuanLyKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucQuanLyThongTinKhachHang ucQuanLyThongTinKhachHang= new ucQuanLyThongTinKhachHang(taikhoanhientai);
            AddTabControl(ucQuanLyThongTinKhachHang, "Quản lý thông tin khách hàng", "");
        }

        private void btnHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucHopDong ucHopDongg = new ucHopDong(taikhoanhientai);
            AddTabControl(ucHopDongg, "Hợp đồng", "");
        }

        private void btnThongTinChinhSachBaoHiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucThongTinChinhSachBaoHiem ucThongTinChinhSachBaoHiem = new ucThongTinChinhSachBaoHiem();
            AddTabControl(ucThongTinChinhSachBaoHiem, "Thông tin bảo hiểm", "");
        }

        private void btnThongTinGoiHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucThongTinChinhSachBaoHiem ucThongTinChinhSachBaoHiem = new ucThongTinChinhSachBaoHiem();
            AddTabControl(ucThongTinChinhSachBaoHiem, "Thông tin gói hợp đồng", "");
        }

        private void btnThongTinChuKyThanhToan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucThongTinChuKyThanhToan ucThongTinChuKyThanhToan = new ucThongTinChuKyThanhToan();
            AddTabControl(ucThongTinChuKyThanhToan, "Thông tin chu kỳ thanh toán", "");
        }

        private void btnTimKiemHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnTimKiemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnThongTinNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNguoiThanKhachHang uc = new ucNguoiThanKhachHang();
            AddTabControl(uc, "Thông Tin Người Thân", "");
        }

        private void btnQuanLyChucVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucQuanLyChucVuNV ucQuanLyChucVuNV = new ucQuanLyChucVuNV();
            AddTabControl(ucQuanLyChucVuNV, "Quản lý chức vụ NV", "");
        }

        private void btnQuanLyCapDoKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucQuanLyCapDoKH ucQuanLyCapDoKH = new ucQuanLyCapDoKH();
            AddTabControl(ucQuanLyCapDoKH, "Phân cấp khách hàng", "");            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tattab()
        {
            int soluong = tabMain.TabPages.Count;
            if (soluong != 0)
            {
                tabMain.TabPages.RemoveAt(soluong - 1);
            }
        }

        private void btDoanhthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDoanhthutest doanhthu = new FormDoanhthutest();
            doanhthu.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucQuanlyCapdo ucQuanlyCapdo = new ucQuanlyCapdo();
            AddTabControl(ucQuanlyCapdo, "Quản lý cấp độ", "");
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormImportExcel f = new FormImportExcel(taikhoanhientai);
            f.ShowDialog();
        }


        //Sao lưu
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BackupvaRestoreDao backupvaRestore = new BackupvaRestoreDao();
            backupvaRestore.backup();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BackupvaRestoreDao backupvaRestore = new BackupvaRestoreDao();
            backupvaRestore.restore();
        }
    }
}


