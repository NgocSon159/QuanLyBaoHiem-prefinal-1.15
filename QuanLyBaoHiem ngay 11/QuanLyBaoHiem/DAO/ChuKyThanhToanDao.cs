using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using QuanLyBaoHiem.Models;
namespace Model.Dao
{
    public class ChuKyThanhToanDao
    {
        QLBHContext db = null;
        public ChuKyThanhToanDao()
        {
            db = new QLBHContext();
        }
        public List<ChuKyThanhToan> Load()
        {
            return db.ChuKyThanhToans.Where(x => x.Status == true).ToList();
        }
        public void ThemCKTT(string MaCK,string ChuKyDong)
        {
            ChuKyThanhToan ck = new ChuKyThanhToan();
            ck.MaChuKy = MaCK;
            ck.ChuKyDong = ChuKyDong;
            ck.Status = true;
            db.ChuKyThanhToans.Add(ck);
            db.SaveChanges();
        }
        public void SuaCKTT(string MaCK, string ChuKyDong)
        {
            var result = db.ChuKyThanhToans.FirstOrDefault(x => x.MaChuKy == MaCK);
            result.ChuKyDong = ChuKyDong;
            db.SaveChanges();
        }
        public void xoaCKTT(string MaCK)
        {
            var result = db.ChuKyThanhToans.FirstOrDefault(x => x.MaChuKy == MaCK);
            result.Status = false;

            db.SaveChanges();
        }
        public int checkchukythanhtoantontai(string machukitt)
        {
            var a = db.ChuKyThanhToans.Find(machukitt);
            if(a==null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
