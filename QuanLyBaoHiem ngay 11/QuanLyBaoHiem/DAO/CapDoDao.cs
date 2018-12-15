using QuanLyBaoHiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class CapDoDao
    {
        QLBHContext db = null;
        public CapDoDao()
        {
            db = new QLBHContext();
        }
        public List<CapDo> Load()
        {
            return db.CapDoes.Where(x => x.Status == true).ToList();
        }
        public List<string> GetCapDo()
        {
            return db.CapDoes.Where(x => x.Status == true).Select(s => s.MaCD).ToList();
        }
        public string MaCD(string tenCD)
        {
            return db.CapDoes.FirstOrDefault(x => x.TenCD == tenCD).MaCD;
        }
        public List<string> GetTenCD()
        {
            return db.CapDoes.Where(x => x.Status == true).Select(s => s.TenCD).ToList();
        }
        public string TenCD(string MaCD)
        {
            if(MaCD=="")
            {
                return "";
            }
            return db.CapDoes.FirstOrDefault(x => x.MaCD == MaCD).TenCD;
        }

        //Sang
        public void ThemCD(string MaCD, string TenCD)
        {
            CapDo cd = new CapDo();
            cd.MaCD = MaCD;
            cd.TenCD = TenCD;
            cd.Status = true;
            db.CapDoes.Add(cd);
            db.SaveChanges();
        }

        public void SuaCD(string MaCD, string TenCD)
        {
            var cd = db.CapDoes.FirstOrDefault(x => x.MaCD == MaCD);
            cd.TenCD = TenCD;
            db.SaveChanges();
        }

        public void XoaCD(string MaCD)
        {
            var cd = db.CapDoes.FirstOrDefault(x => x.MaCD == MaCD);
            cd.Status = false;
            db.SaveChanges();
        }

        public int kiemtratontai(string macd)
        {
            var cd = db.CapDoes.Find(macd);
            if (cd == null)
            {
                return 0;
            }
            else return 1;
        }
    }
}
