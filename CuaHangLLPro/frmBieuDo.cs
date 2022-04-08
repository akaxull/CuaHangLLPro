using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangLLPro
{
    public partial class frmBieuDo : MetroFramework.Forms.MetroForm
    {
        clsDsS ds = new clsDsS();
        IEnumerable<clsDsS> dsSachs;
        string ma;
        public frmBieuDo()
        {
            InitializeComponent();
        }
        
        public frmBieuDo(IEnumerable<clsDsS> dsS)
        {
            dsSachs = dsS;
            InitializeComponent();
        }

        Func<ChartPoint, string> lable = ChartPoint => string.Format("{0} ({1:p})", ChartPoint.Y, ChartPoint.Participation);
        private void Form2_Load(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            IEnumerable<clsDsS> dsSachIt = ds.getDsSachIt(dsSachs);
            IEnumerable<clsDsS> dsSachVua = ds.getDsSachVua(dsSachs);
            IEnumerable<clsDsS> dsSachNhieu = ds.getDsSachNhieu(dsSachs);
            IEnumerable<clsDsS> dsSachKhongBanDuoc = ds.getDsSachKhongBanDuoc(dsSachs);

            int countIt = 0;
            int countNhieu = 0;
            int countVua = 0;
            int countKoBanDc = 0;
            string titleIt = "Ít hơn 30 cuốn";
            string titleVua = "Từ 30 đến 70 cuốn";
            string titleNhieu = "Nhiều hơn 70 cuốn";
            string titleKoBanDc = "Không bán được";
            foreach (clsDsS s in dsSachIt)
            {
                lvwIt.Items.Add(s.getTen());
                countIt++;
            }
                

            foreach (clsDsS s in dsSachVua)
            {
                lvwVua.Items.Add(s.getTen());
                countVua++;
            }
                

            foreach (clsDsS s in dsSachNhieu)
            {
                lvwNhieu.Items.Add(s.getTen());
                countNhieu++;
            }
                

            foreach (clsDsS s in dsSachKhongBanDuoc)
            {
                lvwKo.Items.Add(s.getTen());
                countKoBanDc++;
            }
                

            series.Add(new PieSeries() { Title = titleKoBanDc, Values = new ChartValues<int> { countKoBanDc }, DataLabels = false, LabelPoint = lable });
            pieChart1.Series = series;

            series.Add(new PieSeries() { Title = titleIt, Values = new ChartValues<int> { countIt }, DataLabels = false, LabelPoint = lable });
            pieChart1.Series = series;

            series.Add(new PieSeries() { Title = titleVua, Values = new ChartValues<int> { countVua }, DataLabels = false, LabelPoint = lable });
            pieChart1.Series = series;

            series.Add(new PieSeries() { Title = titleNhieu, Values = new ChartValues<int> { countNhieu }, DataLabels = false, LabelPoint = lable });
            pieChart1.Series = series;

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
