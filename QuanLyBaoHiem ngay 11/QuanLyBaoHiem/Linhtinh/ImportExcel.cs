using DevExpress.XtraEditors;
using Excel;

using Model.Dao;
using QuanLyBaoHiem.DAO;
using QuanLyBaoHiem.Models;
using STSShop.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHiem.Linhtinh
{
    class ImportExcel
    {
        QLBHContext db = new QLBHContext();
        public void importfileExcel(string tenbang)
        {
            
            ExcelSuport exsp = new ExcelSuport();
            List<string> tencot = exsp.LayTenCot(tenbang);
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Chọn file Excel |*.xls; *.xlsx; *.xlsm";
                if (open.ShowDialog() == DialogResult.Cancel)
                    return;

                FileStream stream = new FileStream(open.FileName, FileMode.Open);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet result = excelReader.AsDataSet();



                string celldautien = "";
                foreach (DataTable table in result.Tables)
                {
                    if(table.Columns.Count!=tencot.Count)
                    {
                        XtraMessageBox.Show("File không hợp lệ! Vui lòng kiểm tra lại!!");
                        break;
                    }
                    else
                    {
                        foreach (DataRow dr in table.Rows)

                        {
                            if (table.Rows.IndexOf(dr) == 0)
                            {
                                celldautien = dr[0].ToString();
                                continue;
                            }
                            else
                            {
                                if(celldautien== "Mã NV")
                                {
                                    NhanvienDao nvd = new NhanvienDao();
                                    if (nvd.checkmanvtontai(dr[0].ToString()) == 0)
                                    {
                                        this.ImportNV(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(),
                                            dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), Convert.ToDateTime(dr[8]));
                                        excelReader.Close();
                                        stream.Close();

                                        XtraMessageBox.Show("Import file thành công", "Thông báo");
                                    }
                                    else
                                    {
                                        XtraMessageBox.Show("Mã nhân viên " + dr[0].ToString() + "đã có sẵn!!");
                                    }
                                }
                                else
                                {
                                    if(celldautien == "MaKH")
                                    {
                                        KhachHangDao khd = new KhachHangDao();
                                        if(khd.checkmakhtontai(dr[0].ToString())==0)
                                        {
                                            this.ImportKH(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToDateTime(dr[3]), dr[4].ToString(),
                                            dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                                            excelReader.Close();
                                            stream.Close();

                                            XtraMessageBox.Show("Import file thành công", "Thông báo");
                                        }
                                        else
                                        {
                                            XtraMessageBox.Show("Mã khách hàng " + dr[0].ToString() + "đã có sẵn!!");
                                        }
                                    }
                                    else
                                    {
                                        HopDongDao hdd = new HopDongDao();
                                        if (hdd.checkmahdtontai(dr[0].ToString()) == 0)
                                        {


                                            this.ImportHD(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), Convert.ToDateTime(dr[5]));
                                            excelReader.Close();
                                            stream.Close();

                                            XtraMessageBox.Show("Import file thành công", "Thông báo");
                                        }
                                        else
                                        {
                                            XtraMessageBox.Show("Mã hợp đồng " + dr[0].ToString() + "đã có sẵn!!");
                                        }
                                    }
                                }
                                
                            }

                        }
                    }
                    
                }

                
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Có lỗi xảy ra, xin chọn lại!", "Thông báo");
            }
        }



        public void ImportNV(string manv, string macv, string tennv,string email, string sdt, string gioitinh, string diachi, string manvquanli, DateTime ngaysinh)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = manv;
            nv.MaCV = macv;
            nv.TenNV = tennv;
            nv.Email = email;
            nv.Sdt = sdt;
            bool gioitinhbool = true;
            if(gioitinh=="Nữ")
            {
                gioitinhbool = false;
            }
            nv.GioiTinh = gioitinhbool;
            nv.DiaChi = diachi;
            nv.MaNVQuanLi = manvquanli;
            nv.MatKhau = MahoaMD5.getMd5Hash("123456");
            nv.NgaySinh = ngaysinh;
            nv.Status = true;
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        public void ImportKH(string MaKH, string MaCD, string TenKH, DateTime ngaysinh, string gioitinh, string Diachi, string sdt, string cmnd)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;
            kh.MaCD = MaCD;
            kh.TenKH = TenKH;
            kh.NgaySinh = ngaysinh;

            bool gioitinhbool = true;
            if (gioitinh == "Nữ")
            {
                gioitinhbool = false;
            }
            kh.GioiTinh = gioitinhbool;
            kh.DiaChi = Diachi;
            kh.Sdt = sdt;
            kh.CMND = cmnd;
            
            kh.Status = true;
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }

        public void ImportHD(string MaHD, string MaGHD, string MaCK, string MaNV, string MaKH, DateTime NgayHL)
        {
            HopDong hd = new HopDong();
            hd.MaHD = MaHD;
            hd.MaGoiHD = MaGHD;
            hd.MaChuKy = MaCK;
            hd.MaNV = MaNV;
            hd.MaKHChinh = MaKH;
            hd.NgayHieuLuc = NgayHL;
            hd.Status = true;
            db.HopDongs.Add(hd);
            db.SaveChanges();
        }

    }
}
