using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBaoHiem.Models;

namespace Model.Dao
{
    public class NguoiThanDao
    {
        QLBHContext db = null;
        public NguoiThanDao()
        {
            db = new QLBHContext();
        }

        public NguoiThan getNT(string MaNT)
        {
            return db.NguoiThans.FirstOrDefault(x => x.MaNT == MaNT);
        }

        public List<NguoiThan> Load()
        {
            return db.NguoiThans.Where(x => x.Status == true).ToList();
        }
        public void xoanguothan(string MaNT)
        {
            var result = db.NguoiThans.FirstOrDefault(x => x.MaNT == MaNT);
            result.Status = false;
            db.SaveChanges();
        }
        public List<NguoiThan> TimTheoMaKH(string MaKH)
        {
            return db.NguoiThans.Where(x => x.Status == true).Where(x => x.MaKH == MaKH).ToList();
        }
        public List<NguoiThan> TimTheoTenKH(string tenKH)
        {
            return db.NguoiThans.Where(x => x.Status == true).Where(x => x.MaKH == tenKH).ToList();
        }
        public void ThemNT(string MaNT,string MaKH,string TenNT,DateTime NgaySinh,string GioiTinh,string DiaChi,string CMND,string MaKHRieng,string sdt)
        {
            NguoiThan kh = new NguoiThan();
            kh.MaNT = MaNT;
            kh.MaKH = MaKH;
            kh.TenNT = TenNT;
            
            kh.NgaySinh = NgaySinh;
            if (GioiTinh == "Nam")
            {
                kh.GioiTinh = true;
            }
            else if (GioiTinh == "Nữ")
            {
                kh.GioiTinh = false;
            }
            kh.DiaChi = DiaChi;
            if (MaKHRieng == "")
            {
                kh.MaKHRieng = null;
            }
            else
            {
                kh.MaKHRieng = MaKHRieng;
            }
            if (sdt == "")
            {
                kh.SDT = null;
            }
            else
            {
                kh.SDT = sdt;
            }
            kh.Status = true;
            kh.CMND = CMND;
            db.NguoiThans.Add(kh);
            db.SaveChanges();
        }
        public void suakhachhang(string MaNT, string MaKH, string TenNT, DateTime NgaySinh, string GioiTinh, string DiaChi, string CMND, string MaKHRieng,string sdt)
        {
            var kh = db.NguoiThans.FirstOrDefault(x => x.MaNT == MaNT);
            kh.MaKH = MaKH;
            kh.TenNT = TenNT;
            if (sdt == "")
            {
                kh.SDT = null;
            }
            else
            {
                kh.SDT = sdt;
            }
            if (MaKHRieng == "")
            {
                kh.MaKHRieng = null;
            }
            else
            {
                kh.MaKHRieng = MaKHRieng;
            }
            kh.NgaySinh = NgaySinh;
            if (GioiTinh == "Nam")
            {
                kh.GioiTinh = true;
            }
            else if (GioiTinh == "Nữ")
            {
                kh.GioiTinh = false;
            }
            kh.DiaChi = DiaChi;
            kh.CMND = CMND;
           
            
            db.SaveChanges();
        }
        public string getlastnguoithan()
        {
            var countRow = db.NguoiThans.Count();
            int getCount = countRow + 1;
            string newMaSP = "NT";
            if (getCount < 10) newMaSP += "000" + getCount.ToString();
            else if (getCount < 100) newMaSP += "00" + getCount.ToString();
            return newMaSP;
        }
    }
}
