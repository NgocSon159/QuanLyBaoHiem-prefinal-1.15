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
using System.Data.Entity;
using Model.Dao;
namespace QuanLyBaoHiem
{
    public partial class SuaCapDoKH : DevExpress.XtraEditors.XtraForm
    {
        public ucQuanLyCapDoKH f;
        public SuaCapDoKH(string MaKH,string TenKH,string MaCD,string TenCD,ucQuanLyCapDoKH ff)
        {
            InitializeComponent();
            CapDoDao cd = new CapDoDao();
            capDoesBindingSource.DataSource = cd.Load();
            txtMaKH.Text = MaKH;
            txtTenKH.Text = TenKH;
            txtMaCD.Text = MaCD;
            txtTenCD.Text = TenCD;
            f = ff;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            txtMaCD.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaCD").ToString();
            txtTenCD.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenCD").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KhachHangDao kh = new KhachHangDao();
            kh.SuaDoiCapDoKH(txtMaKH.Text, txtMaCD.Text);
            f.refresh();
            this.Close();
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}