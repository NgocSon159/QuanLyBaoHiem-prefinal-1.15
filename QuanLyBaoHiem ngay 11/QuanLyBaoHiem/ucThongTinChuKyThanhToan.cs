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
using Model.Dao;
namespace QuanLyBaoHiem
{
    public partial class ucThongTinChuKyThanhToan : DevExpress.XtraEditors.XtraUserControl
    {
        List<string> list = new List<string>();
        public ucThongTinChuKyThanhToan()
        {
            InitializeComponent();
            ChuKyThanhToanDao ck = new ChuKyThanhToanDao();
            chuKyThanhToansBindingSource.DataSource = ck.Load();
           
            loaddata();
        }

        public void loaddata()
        {
            for (int i = 1; i <= 12; i++)
            {
                list.Add(i.ToString());
            }
            

            foreach (var item in list)
            {
                cboSothang.Properties.Items.Add(item);
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            btnLuu.Visible = true;
            btnHuy.Visible = true;

            txtMaChuKy.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MaChuKy").ToString();
            string text= gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ChuKyDong").ToString();
            string[] textchia = text.Split(' ');
            cboSothang.Text = textchia[0];
            cboSothang.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaChuKy.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa chọn dòng!!");
            }
            else
            {
                DialogResult dialogResult = XtraMessageBox.Show("Xác nhận", "Bạn thực sự muốn xóa?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ChuKyThanhToanDao ck = new ChuKyThanhToanDao();
                    ck.xoaCKTT(txtMaChuKy.Text);
                    
                    XtraMessageBox.Show("Đã xóa thành công!!");
                    this.refresh();
                    reset();


                }
            }


            
        }
        public void refresh()
        {
            ChuKyThanhToanDao ck = new ChuKyThanhToanDao();
            chuKyThanhToansBindingSource.DataSource = ck.Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCKTT f = new ThemCKTT(this);
            f.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMaChuKy_EditValueChanged(object sender, EventArgs e)
        {

        }


        public void reset()
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;

            txtMaChuKy.Text = "";
            cboSothang.Text = "";
            cboSothang.Enabled = false;
            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            btnLuu.Visible = false;

            cboSothang.Enabled = false;
            txtMaChuKy.Text = "";
            cboSothang.Text = "";
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaChuKy.Text==""||cboSothang.Text=="")
                {
                    XtraMessageBox.Show("Mời Chọn Mục Cần Sửa");
                }
                else
                {
                    ChuKyThanhToanDao chuKy = new ChuKyThanhToanDao();
                    string chuky = cboSothang.Text + " " + "tháng"; 
                    chuKy.SuaCKTT(txtMaChuKy.Text, chuky);
                    XtraMessageBox.Show("Sửa Thành Công");
                    this.refresh();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Chọn Mục Cần Sửa");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.refresh();
            reset();
        }
    }
}
