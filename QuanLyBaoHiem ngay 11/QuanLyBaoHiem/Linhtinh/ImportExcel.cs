using DevExpress.XtraEditors;
using Excel;

using Model.Dao;
using QuanLyBaoHiem.DAO;
using QuanLyBaoHiem.Models;
using STSShop.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        string manvhientai = "";
        public void importfileExcel(string tenbang,string manv)
        {
            manvhientai = manv;
            ExcelSuport exsp = new ExcelSuport();
            List<string> tencot = exsp.LayTenCot(tenbang);
            try
            {
                foreach (var process in Process.GetProcessesByName("EXCEL"))
                {
                    process.Kill();
                }
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
                                if(celldautien== "TenNV")
                                {
                                    this.ImportNV(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                                            dr[4].ToString(), Convert.ToDateTime(dr[5]));
                                    excelReader.Close();
                                    stream.Close();

                                    XtraMessageBox.Show("Import file thành công", "Thông báo");
                                }
                                else
                                {
                                    if(celldautien == "MaCD")
                                    {
                                        this.ImportKH(dr[0].ToString(), dr[1].ToString(), Convert.ToDateTime(dr[2]), dr[3].ToString(),
                                            dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
                                        excelReader.Close();
                                        stream.Close();

                                        XtraMessageBox.Show("Import file thành công", "Thông báo");



                                    }
                                    else
                                    {
                                        this.ImportHD(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDateTime(dr[4]));
                                        excelReader.Close();
                                        stream.Close();

                                        XtraMessageBox.Show("Import file thành công", "Thông báo");




                                    }
                                }
                                
                            }

                        }
                    }
                    
                }

                
                
            }
            catch (Exception ex)
            {
                if (ex.InnerException!=null)
                {
                    string loi = ex.InnerException.ToString();
                    string[] loichia = loi.Split('\n');
                    string[] loichinh = loichia[0].Split(':');
                    XtraMessageBox.Show(loichinh[2]);
                }
                else
                {
                    XtraMessageBox.Show("File không hợp lệ hoặc sai định dạng!!");
                }
                
            }
        }



        public void ImportNV( string tennv,string email, string sdt, string gioitinh, string diachi, DateTime ngaysinh)
        {
            NhanvienDao nvdao = new NhanvienDao();
            NhanVien nv = new NhanVien();
            nv.MaNV = nvdao.getlastnhanvien();
            if(nvdao.getchucvutunhanvien(manvhientai)=="QL")
            {
                nv.MaCV = "TP";
            }
            else
            {
                nv.MaCV = "NV";
            }
            
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
            nv.MaNVQuanLi = manvhientai;
            nv.MatKhau = MahoaMD5.getMd5Hash("123456");
            nv.NgaySinh = ngaysinh;
            nv.Status = true;
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        public void ImportKH( string MaCD, string TenKH, DateTime ngaysinh, string gioitinh, string Diachi, string sdt, string cmnd)
        {
            KhachHangDao khdao = new KhachHangDao();
            KhachHang kh = new KhachHang();
            kh.MaKH = khdao.getlastkhachhang();
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

        public void ImportHD( string MaGHD, string MaCK, string MaNV, string MaKH, DateTime NgayHL)
        {
            HopDongDao hddao = new HopDongDao();

            HopDong hd = new HopDong();
            hd.MaHD = hddao.getlasthopdong();
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
