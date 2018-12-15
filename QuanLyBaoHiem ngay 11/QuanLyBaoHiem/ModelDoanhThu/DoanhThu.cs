using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiem.ModelDoanhThu
{
    class DoanhThu
    {
        private string maHD;
        private decimal? mucPhi;
        private DateTime? ngayHieuLuc;

        public string MaHD { get => maHD; set => maHD = value; }
        public decimal? MucPhi { get => mucPhi; set => mucPhi = value; }
        public DateTime? NgayHieuLuc { get => ngayHieuLuc; set => ngayHieuLuc = value; }
    }
    }

