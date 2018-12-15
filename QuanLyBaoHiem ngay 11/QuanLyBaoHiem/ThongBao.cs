using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model.Dao;
using QuanLyBaoHiem.MinhTam;
namespace QuanLyBaoHiem
{
    public partial class ThongBao : DevExpress.XtraEditors.XtraForm
    {
        public List<Birthday> birthdays;
        public ThongBao(DateTime dateTime)
        {
            InitializeComponent();
            FlowLayoutPanel f = new FlowLayoutPanel();
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            panel1.Controls.Add(f);
            f.AutoScroll = true;
            f.WrapContents = false;
            f.FlowDirection = FlowDirection.TopDown;
            KhachHangDao kh = new KhachHangDao();
            foreach(var item in kh.LoadNgaySinh(dateTime))
            {
                Birthday bd = new Birthday(item);
                ucBirthday ucBirthday = new ucBirthday(bd);
                f.Controls.Add(ucBirthday);
            }
        }
        //void Load(FlowLayoutPanel f)
        //{
        //    foreach(var item in birthdays)
        //    {
        //        if(item.status==true)
        //        {
        //            ucBirthday ucBirthday = new ucBirthday(item);
        //            f.Controls.Add(ucBirthday);
        //        }
        //    }
            
        //}
        private void ThongBao_Load(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}