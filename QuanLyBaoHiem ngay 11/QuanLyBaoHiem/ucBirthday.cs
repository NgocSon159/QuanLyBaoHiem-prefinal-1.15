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
using QuanLyBaoHiem.MinhTam;
namespace QuanLyBaoHiem
{
    public partial class ucBirthday : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBirthday(Birthday bd)
        {
            InitializeComponent();
            txtMaKH.Text = bd.MaKH;
            txtTenKH.Text = bd.TenKH;
            txtNgaySinh.Text = bd.NgaySinh;
            txtCMND.Text = bd.CMND;
            txtSDT.Text = bd.SDT;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
