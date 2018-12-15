using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyBaoHiem.Models;

namespace QuanLyBaoHiem.MinhTam
{
    public class Birthday
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string NgaySinh { get; set; }
        public bool status { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public Birthday(KhachHang kh)
        {
            MaKH = kh.MaKH;
            TenKH = kh.TenKH;
            NgaySinh= (Convert.ToDateTime(kh.NgaySinh)).ToString("dd/MM/yyyy");
            CMND = kh.CMND;
            SDT = kh.Sdt;
            status = true;
        }
    }
}
