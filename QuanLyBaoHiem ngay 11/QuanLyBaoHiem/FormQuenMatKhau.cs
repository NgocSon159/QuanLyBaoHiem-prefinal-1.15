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
using QuanLyBaoHiem.Linhtinh;

namespace QuanLyBaoHiem
{
    public partial class FormQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txtTaikhoan.Text=="")
            {
                XtraMessageBox.Show("Vui lòng nhập đủ thông tin");

            }
            else
            {
                NhanvienDao nvdao = new NhanvienDao();
                if(nvdao.kiemtrataikhoantontai(txtTaikhoan.Text)==false)
                {
                    XtraMessageBox.Show("Tên tài khoản không tồn tại!!");
                }
                else
                {
                    EmailSupport emailsp = new EmailSupport();
                    emailsp.guiemail(txtTaikhoan.Text);
                    this.Close();
                }
            }
        }

        
    }
}