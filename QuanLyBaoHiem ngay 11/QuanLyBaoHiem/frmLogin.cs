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
using QuanLyBaoHiem.Models;
using QuanLyBaoHiem.DAO;
using System.IO;
using STSShop.Common;
using System.Diagnostics;

namespace QuanLyBaoHiem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        String dirPath = @"C:\temp";
        public frmLogin()
        {
            InitializeComponent();
        }
        QLBHContext db = new QLBHContext();
        DangnhapDao dangnhapdaoo = new DangnhapDao();

        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPass.Properties.PasswordChar = '*';
            loadtaikhoanmatkhaudanho();
            taothumuctemp();
        }

        public void taothumuctemp()
        {
            bool exist = Directory.Exists(dirPath);
            if (!exist)
            {
               

                // Tạo thư mục.
                Directory.CreateDirectory(dirPath);
            }
        }

        public void loadtaikhoanmatkhaudanho()
        {
            string path = "C:\\temp\\remember.ini";
            if(File.Exists(path)==true)
            {
                string[] lines = File.ReadAllLines(@"C:\temp\remember.ini");
                int sl = lines.Count();
                if(sl!=0)
                txtUser.Text = lines[0];
            }
            
        }

        public void ghinhotaikhoanvapass()
        {
            String filepath = "C:\\temp\\remember.ini";
            if (checkEdit1.Checked==true)
            {
                if (File.Exists(filepath) == true)
                {
                    File.SetAttributes(filepath, FileAttributes.Normal);
                }
                FileStream fs = new FileStream(filepath, FileMode.Create);//Tạo file mới tên là test.txt    
                File.SetAttributes(filepath, FileAttributes.Hidden);
                StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);//fs là 1 FileStream 
                sWriter.Write(txtUser.Text);
                
                sWriter.Flush();
                fs.Close();
            }
            else
            {
                File.SetAttributes(filepath, FileAttributes.Normal);
                File.WriteAllText(filepath, String.Empty);
                File.SetAttributes(filepath, FileAttributes.Hidden);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 0)
            {
                XtraMessageBox.Show("Vui lòng nhập tên tài khoản");
            }
            else
            {
                if (txtPass.Text.Length == 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập mật khẩu");
                }
                else
                {
                    if (dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("TP"))
                    {
                        ghinhotaikhoanvapass();
                        frmMain frmMain = new frmMain(txtUser.Text,MahoaMD5.getMd5Hash(txtPass.Text));
                        frmMain.phanquyenTruongPhong();             //phan quyen admin, trưởng phòng
                        frmMain.Show();
                        this.Hide();
                    }
                    if (dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("QL"))
                    {
                        ghinhotaikhoanvapass();
                        frmMain frmMain = new frmMain(txtUser.Text, MahoaMD5.getMd5Hash(txtPass.Text));
                        frmMain.phanquyenQuanLy();             //phan quyen quản lý
                        frmMain.Show();
                        this.Hide();
                    }
                    if (dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("NV"))
                    {
                        ghinhotaikhoanvapass();
                        frmMain frmMain = new frmMain(txtUser.Text, MahoaMD5.getMd5Hash(txtPass.Text));
                        frmMain.phanquyenNhanVien();             //phan quyen nhân viên
                        frmMain.Show();
                        this.Hide();
                    }
                    if(dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("no"))
                    {
                        XtraMessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu");
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            foreach (var process in Process.GetProcessesByName("QuanLyBaoHiem"))
            {
                process.Kill();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                if (txtUser.Text.Length == 0)
                {
                    XtraMessageBox.Show("Vui lòng nhập tên tài khoản");
                }
                else
                {
                    if (txtPass.Text.Length == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập mật khẩu");
                    }
                    else
                    {
                        if (dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("TP"))
                        {
                            ghinhotaikhoanvapass();
                            frmMain frmMain = new frmMain(txtUser.Text, MahoaMD5.getMd5Hash(txtPass.Text));
                            frmMain.phanquyenTruongPhong();             //phan quyen admin
                            frmMain.Show();
                            this.Hide();
                        }
                        if (dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("QL"))
                        {
                            ghinhotaikhoanvapass();
                            frmMain frmMain = new frmMain(txtUser.Text, MahoaMD5.getMd5Hash(txtPass.Text));
                            frmMain.phanquyenQuanLy();             //phan quyen quản lý
                            frmMain.Show();
                            this.Hide();
                        }
                        if (dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("NV"))
                        {
                            ghinhotaikhoanvapass();
                            frmMain frmMain = new frmMain(txtUser.Text, MahoaMD5.getMd5Hash(txtPass.Text));
                            frmMain.phanquyenNhanVien();             //phan quyen user
                            frmMain.Show();
                            this.Hide();
                        }
                        if (dangnhapdaoo.dangnhap(txtUser.Text, txtPass.Text).Equals("no"))
                        {
                            XtraMessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu");
                        }
                    }
                }
            }
                 
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            FormQuenMatKhau f = new FormQuenMatKhau();
            f.ShowDialog();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("QuanLyBaoHiem"))
            {
                process.Kill();
            }



        }
    }
}