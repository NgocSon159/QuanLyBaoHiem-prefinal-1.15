using QuanLyBaoHiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiem.Linhtinh
{
    class ExcelSuport
    {
        QLBHContext db = new QLBHContext();
        public List<string> LayTenCot(string tenbang)
        {
            List<string> tencot = new List<string>();
            var dbs = db.Database.SqlQuery<string>("select c.name from sys.columns c inner join sys.tables t on t.object_id = c.object_id and t.name = '" + tenbang + "' and t.type = 'U'");
            foreach (var item in dbs)
            {
                if(item== "HinhAnh"||item== "MatKhau"||item=="Status" || item == "MaKH" || item == "MaNV" || item == "MaHD" || item == "MaCV" || item == "MaNVQuanLi")
                {
                    continue;
                }
                else
                {
                    tencot.Add(item);
                }
                
            }
            return tencot;
        }



    }
}
