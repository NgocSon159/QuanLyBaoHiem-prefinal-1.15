using DevExpress.XtraEditors;
using QuanLyBaoHiem.Models;
using STSShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHiem.DAO
{
    class DangnhapDao
    {
        QLBHContext db = new QLBHContext();
        public string dangnhap(string taikhoan,string matkhau)
        {
            var nhanvientimduoc = db.NhanViens.Find(taikhoan);

            if(nhanvientimduoc!=null)
            {
                if (nhanvientimduoc.MatKhau.Equals(MahoaMD5.getMd5Hash(matkhau)))
                    return nhanvientimduoc.MaCV;
            }
            
            return "no";
        }
        public void doimatkhau(string taikhoan,string matkhaucu,string matkhaumoi)
        {
            var nhanvientimduoc = db.NhanViens.Find(taikhoan);
            nhanvientimduoc.MatKhau = MahoaMD5.getMd5Hash(matkhaumoi);
            db.SaveChanges();
            XtraMessageBox.Show("Đổi mật khẩu thành công");




        }
        
    }
}
