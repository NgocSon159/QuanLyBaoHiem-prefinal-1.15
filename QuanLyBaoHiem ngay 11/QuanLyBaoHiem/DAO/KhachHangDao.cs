using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using QuanLyBaoHiem.Models;
namespace Model.Dao
{
    public class KhachHangDao
    {
        QLBHContext db = null;
        public KhachHangDao()
        {
            db = new QLBHContext();
        }
        public List<KhachHang> Load()
        {
            return db.KhachHangs.Where(x => x.Status == true).ToList();    
        }
        public void SuaDoiCapDoKH(string MaKH, string MaCD)
        {
            var result = db.KhachHangs.FirstOrDefault(x => x.MaKH == MaKH);
            result.MaCD = MaCD;
            db.SaveChanges();
        }
        public List<KhachHang> TimTheoMaKH(string MaKH)
        {
            return db.KhachHangs.Where(x => x.Status == true).Where(x => x.MaKH == MaKH).ToList();
        }
        public List<KhachHang> TimTheoTenKH(string TenKH)
        {
            return db.KhachHangs.Where(x => x.Status == true).Where(x => x.TenKH.Contains(TenKH)).ToList();
        }
        public void ThemKH(string MaKH,string TenKH,string MaCD,string NgaySinh,string GioiTinh,string DiaChi,string sdt,string CMND,string hinhanh)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = MaKH;
            kh.MaCD = MaCD;
            kh.TenKH = TenKH;
            kh.NgaySinh = Convert.ToDateTime(NgaySinh);
            if(GioiTinh=="Nam")
            {
                kh.GioiTinh = true;
            }
            else if(GioiTinh=="Nữ")
            {
                kh.GioiTinh = false;
            }
            kh.DiaChi = DiaChi;
            kh.Sdt = sdt;
            kh.Status = true;
            kh.CMND = CMND;
            if(hinhanh!=null)
            {
                FileStream f = new FileStream(hinhanh, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(f);
                kh.HinhAnh = br.ReadBytes((int)f.Length);
            }
            
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }
        public void xoakhachhang(string MaKH)
        {
            var result = db.KhachHangs.FirstOrDefault(x => x.MaKH == MaKH);
            result.Status = false;
            db.SaveChanges();
        }
        public string GetCapDo(string MaKH)
        {
            return db.KhachHangs.FirstOrDefault(x => x.MaKH == MaKH).MaCD;
        }
        public void suakhachhang(string MaKH, string TenKH, string MaCD, DateTime NgaySinh, string GioiTinh, string DiaChi, string sdt, string CMND, byte[] hinhanh)
        {
            var kh = db.KhachHangs.FirstOrDefault(x => x.MaKH == MaKH);
            kh.MaCD = MaCD;
            kh.TenKH = TenKH;


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
            kh.Sdt = sdt;
            kh.CMND = CMND;
            kh.HinhAnh = hinhanh;
            db.SaveChanges();
        }

        public List<KhachHang> LoadNgaySinh(DateTime dt)
        {
            var result = db.KhachHangs.Where(x => x.NgaySinh.Value.Day == dt.Day).Where(x => x.NgaySinh.Value.Month == dt.Month).Where(x=>x.Status==true).ToList();
            return result;
        }
        public string TenKH(string MaKH)
        {
            return db.KhachHangs.FirstOrDefault(x => x.MaKH == MaKH).TenKH;
        }
        public KhachHang getKH(string MaKH)
        {
            return db.KhachHangs.FirstOrDefault(x => x.MaKH == MaKH);
        }
        public string getlastkhachhang()
        {
            var countRow = db.KhachHangs.Count();
            int getCount = countRow + 1;
            string newMaSP = "KH";
            if (getCount < 10) newMaSP += "000" + getCount.ToString();
            else if (getCount < 100) newMaSP += "00" + getCount.ToString();
            return newMaSP;
        }

        public int checkmakhtontai(string makh)
        {
            var kh = db.KhachHangs.Find(makh);
            if (kh == null)
            {
                return 0;

            }
            else
                return 1;
        }
    }
}
