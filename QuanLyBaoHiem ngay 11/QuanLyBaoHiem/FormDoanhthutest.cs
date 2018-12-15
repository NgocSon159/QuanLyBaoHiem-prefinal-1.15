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
using DevExpress.XtraCharts;
using QuanLyBaoHiem.Models;
using QuanLyBaoHiem.ModelDoanhThu;

namespace QuanLyBaoHiem
{
    public partial class FormDoanhthutest : DevExpress.XtraEditors.XtraForm
    {
        QLBHContext db = new QLBHContext();
        List<DoanhThu> listdoanhthuchung = new List<DoanhThu>();

        decimal[] doanhthutungthang = new decimal[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        List<decimal> doanhthutheonam = new List<decimal>();
        public FormDoanhthutest()
        {
            InitializeComponent();
            radioGroup1.SelectedIndex = 0;
            setyearpicker();



            
        }

        public void setyearpicker()
        {
            dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateEdit1.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView;
            dateden.Properties.Mask.UseMaskAsDisplayFormat = true;
            dateden.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView;
            datetu.Properties.Mask.UseMaskAsDisplayFormat = true;
            datetu.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView;
        }

        public void ve(DateTime tuyear, DateTime denyear)
        {
            if (tuyear.Year == denyear.Year)
            {
                laydulieu(tuyear, denyear);
                xulyradoanhthuhangthang();
                Series series1 = new Series("Doanh thu (VNĐ)", ViewType.Bar);

                // Set the numerical argument scale type for the series,
                // as it is qualitative, by default.
                series1.ArgumentScaleType = ScaleType.Auto;

                // Add points to it.
                for (int i = 0; i < 12; i++)
                {
                    series1.Points.Add(new SeriesPoint("Tháng " + (i + 1) + "", doanhthutungthang[i]));

                }

                 // Add the series to the chart.
                pointChart.Series.Add(series1);

                // Access the view-type-specific options of the series.
                BarSeriesView myView1 = (BarSeriesView)series1.View;
                
                // Access the type-specific options of the diagram.
                ((XYDiagram)pointChart.Diagram).EnableAxisXZooming = true;

                // Hide the legend (if necessary).
                pointChart.Legend.Visible = true;

                // Add a title to the chart (if necessary).
                pointChart.Titles.Add(new ChartTitle());
                pointChart.Titles[0].Text = "Doanh thu từng tháng trong năm " + tuyear.Year + "";
            }
            else
            ///////Theo năm từ xxx đến yyyy
            {
                laydulieu(tuyear, denyear);
                xulydoanhtheonamtuden(tuyear.Year,denyear.Year);
                Series series1 = new Series("Doanh thu (VNĐ)", ViewType.Bar);

                // Set the numerical argument scale type for the series,
                // as it is qualitative, by default.
                series1.ArgumentScaleType = ScaleType.Auto;

                // Add points to it.
                for (int i = tuyear.Year; i <= denyear.Year; i++)
                {
                    series1.Points.Add(new SeriesPoint("Năm " + i + "", doanhthutheonam[i-tuyear.Year])); //vd i=2013-2013=0; i=2014-2013=1,....

                }

                // Add the series to the chart.
                pointChart.Series.Add(series1);

                // Access the view-type-specific options of the series.
                BarSeriesView myView1 = (BarSeriesView)series1.View;

                // Access the type-specific options of the diagram.
                ((XYDiagram)pointChart.Diagram).EnableAxisXZooming = true;

                // Hide the legend (if necessary).
                pointChart.Legend.Visible = true;

                // Add a title to the chart (if necessary).
                pointChart.Titles.Add(new ChartTitle());
                pointChart.Titles[0].Text = "Doanh thu từ năm " + tuyear.Year + " đến năm "+denyear.Year;
            }

            
            
        }

        public void laydulieu(DateTime tuyear,DateTime denyear)
        {
            //Get tất cả dữ liệu
            var dulieu = (from p in db.HopDongs
                          join b in db.GoiHopDongs
                          on p.MaGoiHD equals b.MaGoiHD
                          select new
                          {
                              MaHD = p.MaHD,
                              MucPhi = b.MucPhi,
                              NgayHieuLuc = p.NgayHieuLuc
                          }
                        ).ToList();
            foreach (var a in dulieu)
            {
                DateTime temp = (DateTime)a.NgayHieuLuc;
                if(tuyear.Year <= temp.Year && temp.Year <=denyear.Year)
                {
                    DoanhThu b = new DoanhThu();
                    b.MaHD = a.MaHD;
                    b.MucPhi = a.MucPhi;
                    b.NgayHieuLuc = a.NgayHieuLuc;
                    listdoanhthuchung.Add(b);
                }
                
            }
        }
        public void xulyradoanhthuhangthang()
        {
            for (int i = 0; i < 12; i++)
            {
                foreach (var a in listdoanhthuchung)
                {
                    DateTime temp = (DateTime)a.NgayHieuLuc;
                    if (temp.Month == i + 1)
                    {
                        doanhthutungthang[i] = (decimal)(doanhthutungthang[i] + a.MucPhi);
                        
                    }

                }
            }
        }

        public void xulydoanhtheonamtuden(int tunam,int dennam)
        {
            for (int i = tunam; i <= dennam; i++)
            {
                decimal tongtheonam = 0;
                foreach (var a in listdoanhthuchung)
                {
                    DateTime temp = (DateTime)a.NgayHieuLuc;
                    if (temp.Year == i)
                    {
                        tongtheonam = (decimal)(tongtheonam + a.MucPhi);


                    }

                }
                doanhthutheonam.Add(tongtheonam);
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioGroup1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 1)
            {
                dateEdit1.Enabled = false;
                dateden.Enabled = true;
                datetu.Enabled = true;
            }
            else
            {
                dateEdit1.Enabled = true; ;
                dateden.Enabled = false;
                datetu.Enabled = false;
            }
        }

        public void cleardatadoanhthu()
        {
            pointChart.DataSource = null;
            pointChart.Series.Clear();
            if(pointChart.Titles.Count==1)
            {
                pointChart.Titles.RemoveAt(0);
            }
            
            for(int i=0;i<12;i++)
            {
                doanhthutungthang[i] = 0;
            }
            if(listdoanhthuchung.Count >0)
                listdoanhthuchung.RemoveRange(0, listdoanhthuchung.Count);

            if (doanhthutheonam.Count > 0)
                doanhthutheonam.RemoveRange(0, doanhthutheonam.Count);


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 0)
            {
                cleardatadoanhthu();
                ve(dateEdit1.DateTime, dateEdit1.DateTime);
            }
            else
            {
                cleardatadoanhthu();
                ve(datetu.DateTime, dateden.DateTime);
            }
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}