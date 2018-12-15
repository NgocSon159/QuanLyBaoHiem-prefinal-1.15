using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBaoHiem.MinhTam;
using Model.Dao;
using QuanLyBaoHiem.Models;
namespace QuanLyBaoHiem
{
    public partial class ucThongBaoDongHoaDon : DevExpress.XtraEditors.XtraUserControl
    {
        #region properties
        NotifyIcon notify { get; set; }
        private List<List<SimpleButton>> matrix;
        public List<List<SimpleButton>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }
        public List<string> dateofWeek =new List<string>(){"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
        #endregion

        public ucThongBaoDongHoaDon()
        {
            InitializeComponent();
            notify = new NotifyIcon();
            LoadMatrix();
            DateTime dt = DateTime.Now;
            HopDongDao hd = new HopDongDao();
            List<HopDong> result = hd.LoadThongBaoHopDong(dt);
            if (result == null) return;
            List<ThongBaoHopDong> today = new List<ThongBaoHopDong>();
            foreach (var item in result)
            {
                ThongBaoHopDong thongBaoHopDong = new ThongBaoHopDong(item); 
                today.Add(thongBaoHopDong);
            }

            notifyIcon.ShowBalloonTip(10000, "Lịch Công Việc", string.Format("Bạn có {0} thông báo hợp đồng trong ngày hôm nay", today.Count), ToolTipIcon.Info);
            //timerNotify.Start();
        }
        public void LoadMatrix()
        {
            
            Matrix = new List<List<SimpleButton>>();
            SimpleButton oldbtn = new SimpleButton() { Width = 0,Height = 0,Location = new Point(-19, 0) };
            for(int i=0;i<6;i++)
            {
                Matrix.Add(new List<SimpleButton>());
                for(int j=0;j<7;j++)
                {
                    SimpleButton bt = new SimpleButton() { Width=75,Height=44,};
                    bt.Location = new Point(oldbtn.Location.X + oldbtn.Width+19,oldbtn.Location.Y);
                    bt.LookAndFeel.SetSkinStyle("", "");
                    bt.LookAndFeel.SkinMaskColor2 = Color.YellowGreen;
                    bt.Click += bt_Click;
                    panel1.Controls.Add(bt);
                    Matrix[i].Add(bt);
                    oldbtn = bt;
                }
                oldbtn = new SimpleButton() { Width = 0, Height = 0, Location = new Point(-19, oldbtn.Location.Y+50) };
            }
            SetDefault();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty((sender as SimpleButton).Text)) return;
            else
            {
                DateTime dt = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, Convert.ToInt32((sender as SimpleButton).Text));
                dateTimePicker1.Value = dt;
                ThongBaoHopDongForm tb = new ThongBaoHopDongForm(dateTimePicker1.Value);
                tb.ShowDialog();
            }
        }

        void bt_click(object sender,EventArgs eventArgs)
        {

        }
        void ClearMatrix()
        {
            for(int i=0;i<Matrix.Count;i++)
            {
                for(int j=0;j<Matrix[i].Count;j++)
                {
                    SimpleButton btn = Matrix[i][j];
                    btn.Text = "";
                    btn.LookAndFeel.SkinMaskColor = Color.WhiteSmoke;
                }
            }
        }
        int DayOfMonth(DateTime dt)
        {
            switch(dt.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((dt.Year % 4 == 0 && dt.Year % 100 != 0) || dt.Year % 400 == 0) return 29;
                    else return 28;
                default:
                    return 30; ;
            }
        }
        public void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for(int i=1;i<=DayOfMonth(date);i++)
            {
                int column = dateofWeek.IndexOf(useDate.DayOfWeek.ToString());
                SimpleButton btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (isEqualDate(useDate, dateTimePicker1.Value))
                {
                    btn.LookAndFeel.SkinMaskColor = Color.Goldenrod; 
                }
                if (isEqualDate(useDate,DateTime.Now))
                {    
                    btn.LookAndFeel.SkinMaskColor = Color.GreenYellow;
                    //btn.BackColor = Color.Yellow;
                }
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
            }
        }
        bool isEqualDate(DateTime a,DateTime b)
        {
            return a.Year == b.Year && a.Month == b.Month && a.Day == b.Day;
        }
        public void SetDefault()
        {
            dateTimePicker1.Value = DateTime.Now;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefault();
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            
            
            
        }

        
    }
}
