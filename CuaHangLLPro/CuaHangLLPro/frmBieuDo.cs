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
            foreach(clsDsS s in dsSachs)
            {
                if (s.getSl() == 0)
                    break;
                series.Add(new PieSeries() { Title = s.getTen(), Values = new ChartValues<int> { s.getSl() }, DataLabels = false, LabelPoint = lable });
                pieChart1.Series = series;

            }
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
