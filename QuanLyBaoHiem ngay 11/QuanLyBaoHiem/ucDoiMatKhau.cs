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
using QuanLyBaoHiem.DAO;
using STSShop.Common;

namespace QuanLyBaoHiem
{
    public partial class ucDoiMatKhau : DevExpress.XtraEditors.XtraUserControl
    {
        private string taikhoanhientai = "";
        private string matkhaudangnhap = "";

        public frmMain f;

        DangnhapDao dndao = new DangnhapDao();

        public ucDoiMatKhau()
        {
            InitializeComponent();
        }
        public ucDoiMatKhau(string taikhoan,string matkhau,frmMain ff)
        {
            InitializeComponent();
            taikhoanhientai = taikhoan;
            matkhaudangnhap = matkhau;
            f = ff;
            txtOldPass.Properties.PasswordChar = '*';
            txtNewPass.Properties.PasswordChar = '*';
            txtReNewPass.Properties.PasswordChar = '*';
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if(txtOldPass.Text.Length==0)
            {
                XtraMessageBox.Show("Vui lòng nhập mật khẩu cũ");
            }
            else
            {
                if(txtNewPass.Text.Length==0)
                {
                    XtraMessageBox.Show("Vui lòng nhập mật khẩu mới");
                }
                else
                {
                    if (txtReNewPass.Text.Length == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập lại mật khẩu mới");
                    }
                    else
                    {
                        
                        if(txtNewPass.Text!=txtReNewPass.Text)
                        {
                            XtraMessageBox.Show("2 mật khẩu mới không khớp");
                        }
                        else
                        {
                            if(MahoaMD5.getMd5Hash(txtOldPass.Text)!=matkhaudangnhap)
                            {
                                XtraMessageBox.Show("Mật khẩu cũ không đúng!!");
                            }
                            else
                            {
                                if(txtOldPass.Text==txtNewPass.Text)
                                {
                                    XtraMessageBox.Show("Mật khẩu mới và mật khẩu cũ không được giống nhau!!!");
                                }
                                else
                                {
                                    if (txtNewPass.Text.Length < 6 || txtNewPass.Text.Length < 6)
                                    {
                                        XtraMessageBox.Show("Mật khẩu không được dưới 6 ký tự!!!");
                                    }
                                    else
                                    {
                                        dndao.doimatkhau(taikhoanhientai, matkhaudangnhap, txtNewPass.Text);

                                        f.tattab();
                                        f.matkhauhientai = MahoaMD5.getMd5Hash(txtNewPass.Text);
                                    }
                                    
                                }
                                
                            }
                            
                        }
                    }
                }
                
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            f.tattab();
        }
    }
}
