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
using QuanLyBaoHiem.DAO;

namespace QuanLyBaoHiem
{
    public partial class FormImportExcel : DevExpress.XtraEditors.XtraForm
    {
        string manvhientai = "";
        public FormImportExcel(string manv)
        {
            InitializeComponent();
            thembangtuongung(manv);
            manvhientai = manv;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        public void thembangtuongung(string manv)
        {
            NhanvienDao nvdao = new NhanvienDao();
            string macv=nvdao.getchucvutunhanvien(manv);
            if(macv=="QL")
            {
                cboTenBang.Properties.Items.Add("Nhân viên");
            }
            else
            {
                if(macv=="TP")
                {
                    cboTenBang.Properties.Items.Add("Nhân viên");
                }
                else
                {
                    
                    cboTenBang.Properties.Items.Add("Khách hàng");
                    cboTenBang.Properties.Items.Add("Hợp đồng");

                }
            }
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
                    xuatfile.importfileExcel("NhanVien",manvhientai);
                }
                else
                {
                    if (cboTenBang.SelectedIndex == 1)
                    {
                        ImportExcel xuatfile = new ImportExcel();
                        xuatfile.importfileExcel("KhachHang","");
                    }
                    else
                    {
                        ImportExcel xuatfile = new ImportExcel();
                        xuatfile.importfileExcel("HopDong","");

                    }
                }
            }
        }
    }
}