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
    public partial class ucThongBaoHopDong : DevExpress.XtraEditors.XtraUserControl
    {
        public ucThongBaoHopDong(ThongBaoHopDong thongBaoHopDong)
        {
            InitializeComponent();
            txtMaKH.Text = thongBaoHopDong.MaKH;
            txtTenKH.Text = thongBaoHopDong.TenKH;
            txtMaGoiHopDong.Text =thongBaoHopDong.MaGoiHD;
            txtMucPhi.Text = thongBaoHopDong.MucPhi.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNgaySinh_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
