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
using QuanLyBaoHiem.Linhtinh;

namespace QuanLyBaoHiem
{
    public partial class FormImportExcel : DevExpress.XtraEditors.XtraForm
    {
        public FormImportExcel()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }


        //Xuất file mẫu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(cboTenBang.SelectedIndex==-1)
            {
                XtraMessageBox.Show("Bạn chưa chọn bảng!!");
                
            }
            else
            {
                if (cboTenBang.SelectedIndex == 0)
                {
                    XuatfileExcelmau xuatfile = new XuatfileExcelmau();
                    xuatfile.xuatexcelmau("NhanVien");
                }
                else
                {
                    if (cboTenBang.SelectedIndex == 1)
                    {
                        XuatfileExcelmau xuatfile = new XuatfileExcelmau();
                        xuatfile.xuatexcelmau("KhachHang");
                    }
                    else
                    {
                        XuatfileExcelmau xuatfile = new XuatfileExcelmau();
                        xuatfile.xuatexcelmau("HopDong");

                    }
                }
            }
            
            
        }


        //Import file
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (cboTenBang.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Bạn chưa chọn bảng!!");

            }
            else
            {
                if (cboTenBang.SelectedIndex == 0)
                {
                    ImportExcel xuatfile = new ImportExcel();
                    xuatfile.importfileExcel("NhanVien");
                }
                else
                {
                    if (cboTenBang.SelectedIndex == 1)
                    {
                        ImportExcel xuatfile = new ImportExcel();
                        xuatfile.importfileExcel("KhachHang");
                    }
                    else
                    {
                        ImportExcel xuatfile = new ImportExcel();
                        xuatfile.importfileExcel("HopDong");

                    }
                }
            }
        }
    }
}