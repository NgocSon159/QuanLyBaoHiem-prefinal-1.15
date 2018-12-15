using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Dao;
using QuanLyBaoHiem.Models;

namespace QuanLyBaoHiem.MinhTam
{
    public class ThongBaoHopDong
    {
        public string MaGoiHD;
        public string MaKH;
        public string TenKH;
        public decimal MucPhi;
        public ThongBaoHopDong(HopDong hd)
        {
            KhachHangDao kh = new KhachHangDao();
            GoiHopDongDao gh = new GoiHopDongDao();
            MaGoiHD = hd.MaGoiHD;
            MaKH = hd.MaKHChinh;
            TenKH = kh.TenKH(hd.MaKHChinh);
            MucPhi = Convert.ToDecimal(gh.MucPhi(hd.MaGoiHD));
        }
    }
}
