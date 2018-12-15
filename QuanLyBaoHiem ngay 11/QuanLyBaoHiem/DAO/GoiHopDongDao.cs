using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBaoHiem.Models;
namespace Model.Dao
{
    public class GoiHopDongDao
    {
        QLBHContext db = null;
        public GoiHopDongDao()
        {
            db = new QLBHContext();
        }
        public List<GoiHopDong> Load()
        {
            return db.GoiHopDongs.Where(x => x.Status == true).ToList();
        }
        public void ThemGHD(string MaHD,decimal MucPhi, decimal GiaTriBaoHiem,int ThoiHanBaoHiem,int ThoiHanDongPhi)
        {
            GoiHopDong gh = new GoiHopDong();
            gh.MaGoiHD = MaHD;
            gh.MucPhi = MucPhi;
            gh.GiaTriBaoHiem = GiaTriBaoHiem;
            gh.ThoiHanBaoHiem = ThoiHanBaoHiem;
            gh.ThoiHanDongPhi = ThoiHanDongPhi;
            gh.Status = true;
            db.GoiHopDongs.Add(gh);
            db.SaveChanges();
        }
        public void SuaGHD(string MaHD, string MucPhi, string GiaTriBaoHiem, int ThoiHanBaoHiem, int ThoiHanDongPhi)
        {
            var result = db.GoiHopDongs.FirstOrDefault(x => x.MaGoiHD == MaHD);
            
            result.MucPhi = Convert.ToDecimal(MucPhi);
            result.GiaTriBaoHiem = Convert.ToDecimal(GiaTriBaoHiem);
            result.ThoiHanBaoHiem = ThoiHanBaoHiem;
            result.ThoiHanDongPhi = ThoiHanDongPhi;
            db.SaveChanges();
        }
        public void xoagoihd(string MaHD)
        {
            var result = db.GoiHopDongs.FirstOrDefault(x => x.MaGoiHD == MaHD);
            result.Status = false;
            db.SaveChanges();
        }
        public decimal? MucPhi(string MaGHD)
        {
            return db.GoiHopDongs.FirstOrDefault(x => x.MaGoiHD == MaGHD).MucPhi;
        }

        public int checkxemmaGHDtontai(string magoihd)
        {
            var ghd = db.GoiHopDongs.Find(magoihd);
            if (ghd == null)
            {
                return 0;

            }
            else
                return 1;
        }
    }
}
