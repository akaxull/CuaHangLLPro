using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Office.Interop.Excel;
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
    public partial class uCrtThongKe : UserControl
    {
        clsSach sach;
        clsHoaDon hoaDon;
        clsNhanVien nhanVien;
        clsKh khachHang;
        IEnumerable<clsDsS> dsSachs;

        string[] time = null;
        string[] mounth = null;

        


        public uCrtThongKe()
        {
            InitializeComponent();
        }

        private void uCrtThongKe_Load(object sender, EventArgs e)
        {
            // tab1
            time = new string[] { "07:00:00", "08:00:00", "09:00:00", "10:00:00", "11:00:00", "12:00:00", "13:00:00", "14:00:00", "15:00:00",
                "16:00:00","17:00:00","17:00:00","19:00:00","20:00:00","21:00:00","22:00:00"};
            mounth = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            hoaDon = new clsHoaDon();
            khachHang = new clsKh();
            nhanVien = new clsNhanVien();
            sach = new clsSach();
            //tab2
            cboTim.SelectedItem = "Chi tiết hóa đơn";
            //tab3


        }
        //Tab 1
        
        private void loadChart()
        {
            ChartTk.AxisX.Clear();
            ChartTk.AxisY.Clear();
            //
           if (radThang.Checked == true)
            {
                ChartTk.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Tháng",
                    Labels = mounth
                });
                ChartTk.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Doanh thu theo tháng",
                    //LabelFormatter = value => value.ToString("d")
                }
           );
            }
            else
            {
                ChartTk.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Giờ",
                    Labels = time
                });
                ChartTk.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Doanh thu theo giờ",
                    //LabelFormatter = value => value.ToString("d")
                }
           );
            }
            

           
            ChartTk.LegendLocation = LiveCharts.LegendLocation.Right;
         
        }
        private void getSeries()
        {
            ChartTk.Series.Clear();
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            IEnumerable<tblHoaDon> dshd;
            DateTime dateStart = dateStartBox.Value;
            DateTime dateEnd = dateEndBox.Value;
            dshd = hoaDon.GetHoaDonTheoNgay(dateStart, dateEnd);
            ChartValues<int> values = new ChartValues<int>();
            int tongHd = 0;
            int tbDoanhThu = 0;
            int tbSanPham = 0;
            foreach (string str in time)
            {
                tongHd = 0;
                tbDoanhThu = 0;
                tbSanPham = 0;
                int tongDoanhThu = 0;
                foreach (tblHoaDon hoaDonS in dshd)
                {
                    string time1 = Convert.ToDateTime(hoaDonS.NgayXuatHoaDon).TimeOfDay.ToString();
                    if (time1.Substring(0, 2) == str.Substring(0, 2))
                    {
                        tongDoanhThu = tongDoanhThu + hoaDonS.TongTien;
                    }
                    tongHd++;
                    tbDoanhThu = tbDoanhThu + hoaDonS.TongTien;
                    IEnumerable<tblChiTietHoaDon> dshdCt = hoaDon.GetAllHoaDonCt(hoaDonS.MaHoaDon);
                    foreach (tblChiTietHoaDon tblChiTiets in dshdCt)
                    {
                        tbSanPham = tbSanPham + tblChiTiets.SoLuong;
                    }
                }
                values.Add(tongDoanhThu);
            }
            series.Add(new LineSeries() { Title = "Tổng doanh thu", Values = values });
            ChartTk.Series = series;
            LblTong.Text = tongHd.ToString();
            if (tbSanPham != 0 && tbDoanhThu != 0)
            {
                lblSanPhamTb.Text = (tbSanPham / tongHd).ToString();
                lblGiaTb.Text = (tbDoanhThu / tongHd).ToString();
            }
        }
        private void getSeries2()
        {
            ChartTk.Series.Clear();
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            IEnumerable<tblHoaDon> dshd;
            DateTime dateStart = dateStartBox.Value;
            DateTime dateEnd = dateEndBox.Value;
            dshd = hoaDon.GetHoaDonTheoNgay(dateStart, dateEnd);
            ChartValues<int> values = new ChartValues<int>();
            int tongHd = 0;
            int tbDoanhThu = 0;
            int tbSanPham = 0;
            foreach (string t in mounth)
            {
                
                    tongHd = 0;
                    tbDoanhThu = 0;
                    tbSanPham = 0;
                    int tongDoanhThu = 0;
                    foreach (tblHoaDon hoaDonS in dshd)
                    {
                        string time1 = Convert.ToDateTime(hoaDonS.NgayXuatHoaDon).TimeOfDay.ToString();
                        int tmp = hoaDonS.NgayXuatHoaDon.Month;
                        if (Convert.ToInt32(t) == tmp)
                        {
                            tongDoanhThu = tongDoanhThu + hoaDonS.TongTien;
                        }
                        tongHd++;
                        tbDoanhThu = tbDoanhThu + hoaDonS.TongTien;
                        IEnumerable<tblChiTietHoaDon> dshdCt = hoaDon.GetAllHoaDonCt(hoaDonS.MaHoaDon);
                        foreach (tblChiTietHoaDon tblChiTiets in dshdCt)
                        {
                            tbSanPham = tbSanPham + tblChiTiets.SoLuong;
                        }
                    }
                    values.Add(tongDoanhThu);    
            }
            series.Add(new LineSeries() { Title = "Tổng doanh thu", Values = values });
            ChartTk.Series = series;
            LblTong.Text = tongHd.ToString();
            if (tbDoanhThu != 0 && tbSanPham != 0)
            {
                lblSanPhamTb.Text = (tbSanPham / tongHd).ToString();
                lblGiaTb.Text = (tbDoanhThu / tongHd).ToString();
            }
            
        }
        private void btnXemBd_Click(object sender, EventArgs e)
        {
            loadChart();
            if (radThang.Checked == true)
            {
                
                if(dateStartBox.Value.Year != dateEndBox.Value.Year)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Bạn phải chọn cùng một năm!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                    getSeries2();
            }
            else
                getSeries();
            

        }
        //tab2 3
        
        private void loadHdToListView(ListView lvw, IEnumerable<tblHoaDon> dshd)
        {
            lvw.Items.Clear();
            ListViewItem item;
            IEnumerable<tblChiTietHoaDon> dshdCt;
            foreach (tblHoaDon hd in dshd)
            {
                item = GenerateItemHD(hd);
                lvw.Items.Add(item);
                dshdCt = hoaDon.GetAllHoaDonCt(hd.MaHoaDon);
                foreach(tblChiTietHoaDon hdCt in dshdCt)
                {
                   item = GenerateItemChiTietHD(hdCt);
                    lvw.Items.Add(item);
                }
            }
        }
        private IEnumerable<clsDsS> loadSToListView(ListView lvw, IEnumerable<tblHoaDon> dshd)
        {
            lvw.Items.Clear();
            ListViewItem item;
            IEnumerable<tblChiTietHoaDon> dshdCt = hoaDon.GetHoaDonCtTheoDs(dshd);
            IEnumerable<tblSach> dsS = sach.GetAllSach();
            clsDsS clsDs;
            List<clsDsS> dsD = new List<clsDsS>();          
            foreach (tblSach s in dsS)
            {
                clsDs = new clsDsS(s.MaSach, s.TenSach, s.GiaTien, 0 ,0 );
                int sl = 0;
                foreach (tblChiTietHoaDon hdCt in dshdCt)
                {
                    if(s.MaSach.Equals(hdCt.MaSach))
                    {
                        sl += hdCt.SoLuong;                     
                    }
                }
                clsDs.setSl(sl);
                clsDs.setTT(sl * s.GiaTien);
                dsD.Add(clsDs);
            }
            IEnumerable<clsDsS> DSXS = from s in dsD
                                orderby s.getSl() descending
                                select s;
            int i = 0;
            foreach(clsDsS s in DSXS)
            {
                if (s.getSl() == 0)
                    break;
                item = GenerateItemS(s, i);
                lvw.Items.Add(item);
                    i++;
                
            }
            return DSXS;
            
        }
        private void loadHdGGToListView(ListView lvw, IEnumerable<tblHoaDon> dshd)
        {

            lvw.Items.Clear();
            ListViewItem item;

            foreach (tblHoaDon hd in dshd)
            {
                item = GenerateItem(hd);
                lvw.Items.Add(item);

            }
        }
        private void createColumnChiTietHD(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.Columns.Add("Mã hóa đơn", 140);
            lvw.Columns.Add("Tên sách", 310);
            lvw.Columns.Add("Gía sách", 100);
            lvw.Columns.Add("Số lượng", 100);          
            lvw.Columns.Add("Tổng tiền", 100);
            lvw.Columns.Add("Giảm giá(%)", 120);
            lvw.Columns.Add("Thành tiền", 120);
            lvw.Columns.Add("Nhân viên", 170);
            lvw.Columns.Add("Khách hàng", 150);
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void createtHDGG(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
            lvw.Columns.Add("Mã hóa đơn", 200);
            lvw.Columns.Add("Tên khách hàng", 310);
            lvw.Columns.Add("Tên nhân viên", 310);
            lvw.Columns.Add("Ngày lập hóa đơn", 250);
            lvw.Columns.Add("Giảm giá(%)", 120);
            lvw.Columns.Add("Tổng tiền", 100);
        }

        private void createColumnChiTietSach(ListView lvw)
        {
            lvw.Columns.Clear();
            lvw.Columns.Add("STT", 60);
            lvw.Columns.Add("Mã sách    ", 140);
            lvw.Columns.Add("Tên sách", 500);
            lvw.Columns.Add("Gía sách", 200);
            lvw.Columns.Add("Số lượng đã bán", 200);
            lvw.Columns.Add("Doanh thu", 300);
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
        private ListViewItem GenerateItemS(clsDsS s, int stt)
        {

            ListViewItem lvwItems;
            lvwItems = new ListViewItem(stt.ToString());
            lvwItems.SubItems.Add(s.getMa());
            lvwItems.SubItems.Add(s.getTen());
            lvwItems.SubItems.Add(s.getTien().ToString());
            lvwItems.SubItems.Add(s.getSl().ToString());
            lvwItems.SubItems.Add(s.getTt().ToString());      
            lvwItems.Tag = s;
            return lvwItems;

        }
        private ListViewItem GenerateItemHD(tblHoaDon hd)
        {

            ListViewItem lvwItems;
            lvwItems = new ListViewItem(hd.MaHoaDon);
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add(hd.GiamGia.ToString());
            lvwItems.SubItems.Add(hd.TongTien.ToString());
            string tenNv = nhanVien.GetNhanVienTuMa(hd.MaNhanVien).TenNhanVien;
            lvwItems.SubItems.Add(tenNv);
            if (hd.MaKhachHang == null)
                lvwItems.SubItems.Add("");
            else
            {
                string tenK = khachHang.getTenKhTuMA(hd.MaKhachHang);
                lvwItems.SubItems.Add(tenK);
            }
            lvwItems.Tag = hd;
            return lvwItems;

        }

        private ListViewItem GenerateItemGG(tblHoaDon hd)
        {

            ListViewItem lvwItems;
            lvwItems = new ListViewItem(hd.MaHoaDon);
            if (hd.MaKhachHang != null)
                lvwItems.SubItems.Add(khachHang.getTenKhTuMA((hd.MaKhachHang)));
            else
                lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add(nhanVien.getTenMvTuMA(hd.MaNhanVien));
            lvwItems.SubItems.Add(Convert.ToString(hd.NgayXuatHoaDon));
            lvwItems.SubItems.Add(Convert.ToString(hd.GiamGia));
            lvwItems.SubItems.Add(Convert.ToString(hd.TongTien));
            lvwItems.Tag = hd;
            return lvwItems;

        }


        private ListViewItem GenerateItemChiTietHD(tblChiTietHoaDon hdCt)
        {

            ListViewItem lvwItems;
            lvwItems = new ListViewItem("");
            string maSach = hdCt.MaSach;
            tblSach tmp = sach.getTblSachTuMa(hdCt.MaSach);
            lvwItems.SubItems.Add(tmp.TenSach);
            lvwItems.SubItems.Add(tmp.GiaTien.ToString());
            lvwItems.SubItems.Add(hdCt.SoLuong.ToString());
            lvwItems.SubItems.Add((hdCt.SoLuong * tmp.GiaTien).ToString());
            tblHoaDon hd = hoaDon.GettblHoaDonTheoMa(hdCt.MaHoaDon);
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add("");
            //lvwItems.Tag = hd;
            return lvwItems;
 


        }
        private ListViewItem GenerateItem(tblHoaDon hd)
        {

            ListViewItem lvwItems;
            lvwItems = new ListViewItem(hd.MaHoaDon);
            if (hd.MaKhachHang != null)
                lvwItems.SubItems.Add(khachHang.getTenKhTuMA((hd.MaKhachHang)));
            else
                lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add(nhanVien.getTenMvTuMA(hd.MaNhanVien));
            lvwItems.SubItems.Add(Convert.ToString(hd.NgayXuatHoaDon));
            lvwItems.SubItems.Add(Convert.ToString(hd.GiamGia));
            lvwItems.SubItems.Add(Convert.ToString(hd.TongTien));
            lvwItems.Tag = hd;
            return lvwItems;
        }

        private void metroSetLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroSetComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            
            IEnumerable<tblHoaDon> dshd;
            DateTime dateStart = dateStartBoxHd.Value;
            DateTime dateEnd = dateEndBoxHd.Value;
            if (dateStart >= dateEnd)
                MetroFramework.MetroMessageBox.Show(this, "Ngày bắt đầu phải bé hơn ngày kết thúc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            else
            {
                dshd = hoaDon.GetHoaDonTheoNgay(dateStart, dateEnd);
                switch (cboTim.SelectedItem.ToString())
                {
                    case "Chi tiết hóa đơn":
                        createColumnChiTietHD(lvwTk);
                        loadHdToListView(lvwTk, dshd);
                        break;
                    case "Giảm giá":
                        dshd = hoaDon.GetHoaDonsGG();
                        createtHDGG(lvwTk);
                        loadHdGGToListView(lvwTk, dshd);
                        break;
                }
            }
            
        }

        private void btnTimSp_Click(object sender, EventArgs e)
        {
            IEnumerable<tblHoaDon> dshd;
            DateTime dateStart = dateStartBoxSp.Value;
            DateTime dateEnd = dateEndBoxSp.Value;
            if (dateStart >= dateEnd)
                MetroFramework.MetroMessageBox.Show(this, "Ngày bắt đầu phải bé hơn ngày kết thúc", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            else
            {
                dshd = hoaDon.GetHoaDonTheoNgay(dateStart, dateEnd);
                createColumnChiTietSach(lvwS);
                dsSachs = loadSToListView(lvwS, dshd);
            }
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sdf = new SaveFileDialog() { Filter = "Excel worlkbook| *.xlsx", ValidateNames = true } )
            {
                if(sdf.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    switch (cboTim.SelectedItem.ToString())
                    {
                        case "Chi tiết hóa đơn":
                            ws.Cells[1, 1] = "Mã hóa đơn";
                            ws.Cells[1, 2] = "Tên sách";
                            ws.Cells[1, 3] = "Gía sách";
                            ws.Cells[1, 4] = "Số lượng";
                            ws.Cells[1, 5] = "Tổng tiền";
                            ws.Cells[1, 6] = "Giảm giá(%)";
                            ws.Cells[1, 7] = "Thành tiền";
                            ws.Cells[1, 8] = "Nhân viên";
                            ws.Cells[1, 9] = "Khách hàng";
                            ws.Cells[1, 10] = "Mã hóa đơn";
                            int i = 2;
                            foreach (ListViewItem item in lvwTk.Items)
                            {
                                ws.Cells[i, 1] = item.SubItems[0].Text;
                                ws.Cells[i, 2] = item.SubItems[1].Text;
                                ws.Cells[i, 3] = item.SubItems[2].Text;
                                ws.Cells[i, 4] = item.SubItems[3].Text;
                                ws.Cells[i, 5] = item.SubItems[4].Text;
                                ws.Cells[i, 6] = item.SubItems[5].Text;
                                ws.Cells[i, 7] = item.SubItems[6].Text;
                                ws.Cells[i, 8] = item.SubItems[7].Text;
                                ws.Cells[i, 9] = item.SubItems[8].Text;
                                i++;
                            }
                            break;
                        case "Giảm giá":
                            ws.Cells[1, 1] = "Mã hóa đơn";
                            ws.Cells[1, 2] = "Tên khách hàng";
                            ws.Cells[1, 3] = "Tên nhân viên";
                            ws.Cells[1, 4] = "Ngày lập hóa đơn";
                            ws.Cells[1, 5] = "Giảm giá(%)";
                            ws.Cells[1, 6] = "Tổng tiền";
                            i = 2;
                            foreach (ListViewItem item in lvwTk.Items)
                            {
                                ws.Cells[i, 1] = item.SubItems[0].Text;
                                ws.Cells[i, 2] = item.SubItems[1].Text;
                                ws.Cells[i, 3] = item.SubItems[2].Text;
                                ws.Cells[i, 4] = item.SubItems[3].Text;
                                ws.Cells[i, 5] = item.SubItems[4].Text;
                                ws.Cells[i, 6] = item.SubItems[5].Text;
                                i++;
                            }
                            break;
                            

                    }
                    wb.SaveAs(sdf.FileName, XlFileFormat.xlWorkbookDefault,
                        Type.Missing, Type.Missing,
                        true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MetroFramework.MetroMessageBox.Show(this, "Thống kê đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXuatFileS_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Excel worlkbook| *.xlsx", ValidateNames = true })
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Mã sách";
                    ws.Cells[1, 2] = "Tên sách";
                    ws.Cells[1, 3] = "Gía sách";
                    ws.Cells[1, 4] = "Số lượng đã bán";
                    ws.Cells[1, 5] = "Doanh thu";
                    int i = 2;
                    
                    foreach (ListViewItem item in lvwS.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[1].Text;
                        ws.Cells[i, 2] = item.SubItems[2].Text;
                        ws.Cells[i, 3] = item.SubItems[3].Text;
                        ws.Cells[i, 4] = item.SubItems[4].Text;
                        ws.Cells[i, 5] = item.SubItems[5].Text;                  
                        i++;
                    }
                    wb.SaveAs(sdf.FileName, XlFileFormat.xlWorkbookDefault,
                        Type.Missing, Type.Missing,
                        true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MetroFramework.MetroMessageBox.Show(this, "Thống kê đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXrmBdSach_Click(object sender, EventArgs e)
        {
            frmBieuDo frm = new frmBieuDo(dsSachs);
            frm.ShowDialog();
        }
    }
}
