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
    public partial class ThongBaoHopDongForm : DevExpress.XtraEditors.XtraForm
    {
        public List<ThongBaoHopDong> thongBaoHopDongs;
        public ThongBaoHopDongForm(DateTime dateTime)
        {
            InitializeComponent();
            FlowLayoutPanel f = new FlowLayoutPanel();
            f.Width = panel1.Width;
            f.Height = panel1.Height;
            panel1.Controls.Add(f);
            f.AutoScroll = true;
            f.WrapContents = false;
            f.FlowDirection = FlowDirection.TopDown;
            HopDongDao hd = new HopDongDao();
            foreach(var item in hd.LoadThongBaoHopDong(dateTime))
            {
                ThongBaoHopDong tb = new ThongBaoHopDong(item);
                ucThongBaoHopDong ucThongBaoHopDong = new ucThongBaoHopDong(tb);
                f.Controls.Add(ucThongBaoHopDong);
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