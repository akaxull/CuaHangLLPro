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
    public partial class ucQuanLyHd : UserControl
    {
        public ucQuanLyHd()
        {
            InitializeComponent();
        }
        clsHoaDon hoaDon;
        clsNhanVien nhanVien;
        clsKh khachHang;
        void createColumn(ListView lvw)
        {
            lvw.Columns.Add("Mã hóa đơn       ", 70);
            lvw.Columns.Add("Tên khách hàng                      ", 250);
            lvw.Columns.Add("Tên nhân viên    ", 250);
            lvw.Columns.Add("Ngày lập hóa đơn    ", 200);
            lvw.Columns.Add("Tổng tiền     ", 70);
        }

        ListViewItem GenerateItem(tblHoaDon hd)
        {

            ListViewItem lvwItems;
            lvwItems = new ListViewItem(hd.MaHoaDon);
            //   lvwItems.SubItems.Add(hd.MaKhachHang);
            //   lvwItems.SubItems.Add(hd.MaNhanVien);
            lvwItems.SubItems.Add(khachHang.getTenKhTuMA((hd.MaKhachHang)));
            lvwItems.SubItems.Add(nhanVien.getTenMvTuMA(hd.MaNhanVien));
            lvwItems.SubItems.Add(Convert.ToString(hd.NgayXuatHoaDon));
            lvwItems.SubItems.Add(Convert.ToString(hd.TongTien));

            return lvwItems;
        }

        void loadHdToListView(ListView lvw, IEnumerable<tblHoaDon> dshd)
        {
            lvw.Items.Clear();
            ListViewItem item;

            foreach (tblHoaDon hd in dshd)
            {
                item = GenerateItem(hd);
                lvw.Items.Add(item);

            }
        }

        private void ucQuanLyHd_Load(object sender, EventArgs e)
        {
            hoaDon = new clsHoaDon();
            khachHang = new clsKh();
            nhanVien = new clsNhanVien();
            IEnumerable<tblHoaDon> dshd;
            dshd = hoaDon.GetAllHoaDons();
           // createColumn(lvwDsHoaDon);
            loadHdToListView(lvwDsHoaDon, dshd);
        }

        private void lvwDsHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
