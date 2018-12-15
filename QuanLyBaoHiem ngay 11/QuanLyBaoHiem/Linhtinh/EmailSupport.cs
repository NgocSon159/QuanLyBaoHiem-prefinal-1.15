using DevExpress.XtraEditors;
using QuanLyBaoHiem.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaoHiem.Linhtinh
{
    public class EmailSupport
    {
        public void guiemail(string manv)
        {
            try
            {
                NhanvienDao nvdao = new NhanvienDao();
                MailMessage mail = new MailMessage();
                Random rd = new Random();
                int pass=rd.Next(111111, 999999);
                string emailnv = nvdao.getEmailcuanhanvien(manv);
                string[] emailchia = emailnv.Split('@');
                char[] bentrai = emailchia[0].ToArray();

                for (int i = 0; i < (int)(bentrai.Length / 2); i++)
                {
                    
                    bentrai[i] = '*';

                }
                string passdache = new string(bentrai)+"@"+ emailchia[1];

                //Server mail của Google
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("son.95.1112@gmail.com");
                // Email cần đến
                mail.To.Add(nvdao.getEmailcuanhanvien(manv)); 
                mail.Subject = ("Thông báo mật khẩu");
                mail.Body = "Mật khẩu của bạn là "+pass+"!!\nVui lòng đổi mật khẩu lại ngay!!";
                
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("son.95.1112@gmail.com", "ngocsonvipro456");
                smtpServer.EnableSsl = true;
                nvdao.resetmatkhaunhanvien(manv, pass.ToString());
                smtpServer.Send(mail);
                XtraMessageBox.Show("Gửi email thành công đến: "+ passdache);
            }
            catch
            {
                XtraMessageBox.Show("Lổi xảy ra trong quá trình gửi mail");
            }
        }

        
    }
}
