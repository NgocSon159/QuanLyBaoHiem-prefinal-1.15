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
using Model.Dao;

namespace QuanLyBaoHiem
{
    public partial class ThemCapDo : DevExpress.XtraEditors.XtraForm
    {
        public ThemCapDo()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CapDoDao cdd = new CapDoDao();
            try
            {
                if (txtMaCD.Text == "" || txtTenCD.Text == "" )
                    XtraMessageBox.Show("Điền đầy đủ thông tin", "Thông báo");
                else
                {
                    if(cdd.kiemtratontai(txtMaCD.Text)==0)
                    {
                        CapDoDao cd = new CapDoDao();
                        cd.ThemCD(txtMaCD.Text, txtTenCD.Text);
                        XtraMessageBox.Show("Thêm thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Mã bạn nhập đã có sẵn!");
                    }
                    
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}