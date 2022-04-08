using CuaHangLLPro.Properties;
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
        Panel pn;
        
        string maNV;
        public ucQuanLyHd(string ma , Panel panelConstain)
        {
            InitializeComponent();
            maNV = ma;
            pn = panelConstain;
        }
        int soLuongSach = 0;
        int tongTien = 0;
        clsSach sach;
        clsHoaDon hoaDon;
        clsNhanVien nhanVien;
        clsKh khachHang;


        private void ucQuanLyHd_Load(object sender, EventArgs e)
        {
            // TRANG 1
            hoaDon = new clsHoaDon();
            khachHang = new clsKh();
            nhanVien = new clsNhanVien();
            IEnumerable<tblHoaDon> dshd;
            dshd = hoaDon.GetAllHoaDons();
            createColumn(lvwDsHoaDon);
            loadHdToListViewTheoNam(lvwDsHoaDon, dshd);
            cboTim.SelectedIndex = 1;
            // TRANG 2
            sach = new clsSach();
            createColumnSach(lvwSach);
            addAutoCompleteSourcTenSach();
            addAutoCompleteSourcSdt();

            btnLapHoaDon.Enabled = false;           
        }

        //
        //tab Danh Sach hd
        //
        
        private void lvwDsHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblHoaDon hoaDonSelect = new tblHoaDon();
            if (lvwDsHoaDon.SelectedItems.Count > 0)
            {
                  hoaDonSelect = (tblHoaDon)lvwDsHoaDon.SelectedItems[0].Tag;            
                  frmChiTietHoaDon frm = new frmChiTietHoaDon(hoaDonSelect);
                  frm.ShowDialog();
            }

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
        int namhientai = DateTime.Now.Year;
        void loadHdToListViewTheoNam(ListView lvw, IEnumerable<tblHoaDon> dshd)
        {
            lvw.Items.Clear();
            ListViewItem item;
           
            foreach (tblHoaDon hd in dshd)
            {
                if (hd.NgayXuatHoaDon.Year==namhientai)
                {
                    item = GenerateItem(hd);
                    lvw.Items.Add(item);
                }

            }
        }
        void createColumn(ListView lvw)
        {
            lvw.Columns.Add("Mã hóa đơn", 140);
            lvw.Columns.Add("Tên khách hàng", 210);
            lvw.Columns.Add("Tên nhân viên", 210);
            lvw.Columns.Add("Ngày lập hóa đơn", 140);
            lvw.Columns.Add("Giảm giá(%)", 80);
            lvw.Columns.Add("Tổng tiền", 100);
         //   lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
        ListViewItem GenerateItem(tblHoaDon hd)
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
        

        //
        //tab Lap hd
        //
        private void addAutoCompleteSourcSdt()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblKhachHang> dsKh = khachHang.GetAllKh();
            foreach (tblKhachHang kh in dsKh)
            {
                souceItems.Add(kh.Sdt);
            }
            txtSoDt.AutoCompleteCustomSource = souceItems;
        }
        
        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

            if (!txtTenSach.Text.Equals(""))
                errorProvider1.SetError(txtTenSach, null);
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            if (!txtSl.Text.Equals("") && txtSl.Text.intcheck() == false)
            {
                errorProvider1.SetError(txtSl, "Số lượng phải bé hơn 100 và không được chứa kí tự khác số tự nhiên");
            }
            else
                errorProvider1.SetError(txtSl, null);
       
        }
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (sach.DemSoLuongSach(txtTenSach.Text) <= 0)
            {
                txtSl.Focus();
                errorProvider1.SetError(txtTenSach, "Sách đã hết hàng vui lòng chọn sách khác");
            }
            else
            {
                if (txtSl.Text.Equals("") || txtTenSach.Text.Equals(""))
                {
                    if (txtTenSach.Text.Equals(""))
                    {
                        txtTenSach.Focus();
                        errorProvider1.SetError(txtTenSach, "Bạn phải nhập tên sách");
                    }
                    else
                    {
                        txtSl.Focus();
                        errorProvider1.SetError(txtSl, "Bạn phải nhập số lượng sách");
                    }
                }
                else
                {
                    if (sach.checkSachTonTai(txtTenSach.Text.ToString()))
                    {
                        loadSachToListView(lvwSach);
                        txtTenSach.Text = "";
                        txtSl.Text = "";
                        txtThanhTien.Text = (tongTien - tongTien * Convert.ToInt32(txtGiamGia.Text) / 100).ToString();
                        txtTongTien.Text = tongTien.ToString();
                        txtTongSach.Text = soLuongSach.ToString();
                        errorProvider1.SetError(lvwSach, null);
                    }
                    else
                    {
                        txtTenSach.Focus();
                        MessageBox.Show("Sách không tồn tại", "Lỗi", MessageBoxButtons.OK);
                    }
                }
            }
        }
        void loadSachToListView(ListView lvw)
        {
            // lvw.Items.Clear();
            ListViewItem item;
            tblSach s = sach.getSachTuTen(txtTenSach.Text.ToString());
            item = GenerateItemSach(s, txtSl.Text.ToString());
            lvw.Items.Add(item);
            soLuongSach = soLuongSach + Convert.ToInt32(txtSl.Text);
            tongTien = tongTien + (s.GiaTien * soLuongSach);
            //      lvwSach.Select;

        }
        private void txtSoDt_Leave(object sender, EventArgs e)
        {
            if(!txtSoDt.Text.Equals(""))
                txtTenK.Text = khachHang.getKhTuSDt(txtSoDt.Text.ToString()).TenKhachHang.ToString();
        }
        private void addAutoCompleteSourcTenSach()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblSach> dsSach = sach.GetTblSach();
            foreach (tblSach s in dsSach)
            {
                souceItems.Add(s.TenSach);
            }
            txtTenSach.AutoCompleteCustomSource = souceItems;
        }
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (lvwSach.Items.Count <= 0)
            {
                errorProvider1.SetError(lvwSach, "Hóa đơn chưa có sách");
                txtTenSach.Focus();
            }
            else if (!txtTienKhachDua.Text.Equals(""))
            {
                if (txtTienKhachDua.Text.tienChek() == false)
                {
                    errorProvider2.SetError(txtTienKhachDua, "Số tiền phải bé hơn 1.000.000.000 và không được chứa kí tự khác số tự nhiên");
                }
                else
                {
                    errorProvider2.SetError(txtTienKhachDua, null);
                    txtTienThoi.Text = (Convert.ToInt64(txtTienKhachDua.Text) - Convert.ToInt64(txtThanhTien.Text)).ToString();
                }
            }
        }
        private void txtTienThoi_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(txtTienThoi.Text) > 0)
            {
                if (lvwSach.Items.Count > 0)
                    btnLapHoaDon.Enabled = true;
            }
            else
                btnLapHoaDon.Enabled = false;
        }
        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (!txtGiamGia.Text.ToString().Equals(""))
            {
                txtThanhTien.Text = (tongTien - tongTien * Convert.ToInt32(txtGiamGia.Text) / 100).ToString();
            }
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // string s = Convert.ToString();
            if (lvwSach.SelectedItems.Count > 0)
                lvwSach.Items.RemoveAt(lvwSach.SelectedIndices[0]);
        }
        ListViewItem GenerateItemSach(tblSach s, string sl)
        {
            int gia = Convert.ToInt32(s.GiaTien) * Convert.ToInt32(sl);
            ListViewItem lvwItems;
            lvwItems = new ListViewItem(s.MaSach);
            lvwItems.SubItems.Add(s.TenSach);
            lvwItems.SubItems.Add(sl);
            lvwItems.SubItems.Add(gia.ToString());
            tblSach tmp = new tblSach();
            tmp = s;
            tmp.SoLuong = Convert.ToInt32(sl);
            lvwItems.Tag = s;
            return lvwItems;

        }
        void createColumnSach(ListView lvw)
        {
            lvw.Columns.Add("Mã sách", 100);
            lvw.Columns.Add("Tên sách", 400);
            lvw.Columns.Add("Số lượng", 110);
            lvw.Columns.Add("Gía Tiền", 210);
            lvw.View = View.Details;
            // lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }


        tblHoaDon taoHoaDon()
        {
            DateTime daytime = DateTime.Now;
            string str  = "HD" + maNV +daytime.Minute.ToString() + daytime.Hour.ToString() + daytime.Day.ToString() + daytime.Month.ToString() + daytime.Year.ToString();
            tblHoaDon hoaDon = new tblHoaDon();
            hoaDon.MaHoaDon = str;
            if (txtSoDt.Text.Equals(""))
                hoaDon.MaKhachHang = null;
            else
            {
                tblKhachHang k = khachHang.getKhTuSDt(txtSoDt.Text.ToString());
                hoaDon.MaKhachHang = k.MaKhachHang;
            }          
            hoaDon.MaNhanVien = maNV;
            hoaDon.NgayXuatHoaDon = daytime;
            hoaDon.GiamGia = Convert.ToInt32(txtGiamGia.Text);
            hoaDon.TongTien = Convert.ToInt32(txtTongTien.Text);
            return hoaDon;

        }

        tblChiTietHoaDon taoHoaDonChiTiet(tblHoaDon hd, int cout)
        {
            tblChiTietHoaDon hoaDon = new tblChiTietHoaDon();
            tblSach s = new tblSach();
            hoaDon.MaHoaDon = hd.MaHoaDon;           
            s = (tblSach)lvwSach.Items[cout].Tag;
            hoaDon.MaSach = s.MaSach;
            hoaDon.SoLuong = s.SoLuong;             
            return hoaDon;

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            int count = 0;
            tblHoaDon hd = taoHoaDon();           
            bool x = hoaDon.add(hd);
            bool y = false;
            bool z = false;
            while (lvwSach.Items.Count > count)
            {
                tblChiTietHoaDon hdChiTiet = taoHoaDonChiTiet(hd, count);
                y = hoaDon.addHdChiTiet(hdChiTiet);
                z = sach.suaSlSach(hdChiTiet, hdChiTiet.SoLuong);
                count++;
            }
            if (x && y && z)
            {
                frmChiTietHoaDon frm = new frmChiTietHoaDon(hd);
                frm.ShowDialog();
            }

        }

        private void tabQlHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            createColumn(lvwDsHoaDon);
            IEnumerable<tblHoaDon> dshd;
            dshd = hoaDon.GetAllHoaDons();
            loadHdToListView(lvwDsHoaDon, dshd);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           // textBox1.Se
        }

       

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            IEnumerable<tblHoaDon> dshd;
            switch (cboTim.SelectedItem)
            {
                case "Mã nhân viên":
                    dshd = hoaDon.GetHoaDonTheoMaNV(txtTim.Text.ToString());
                    createColumn(lvwDsHoaDon);
                    loadHdToListView(lvwDsHoaDon, dshd);
                    break;

                case "Mã hóa đơn":
                    dshd = hoaDon.GetHoaDonTheoMa(txtTim.Text.ToString());
                    createColumn(lvwDsHoaDon);
                    loadHdToListView(lvwDsHoaDon, dshd);
                    break;
                case "Mã khách hàng":
                    dshd = hoaDon.GetHoaDonTheoMaKH(txtTim.Text.ToString());
                    createColumn(lvwDsHoaDon);
                    loadHdToListView(lvwDsHoaDon, dshd);
                    break;
                case "Theo Năm":
                    if(txtTim.Text.intcheck())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Phai Nhập Số ", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        dshd = hoaDon.GetHoaDonTheoNam(Convert.ToInt32(txtTim.Text));
                        createColumn(lvwDsHoaDon);
                        loadHdToListView(lvwDsHoaDon, dshd);
                        break;

                    }
                   
            }
            /*
                Mã nhân viên
Mã hóa đơn
Mã khách hàng
                */
        }

        private void txtTim_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            ucCrtQuanLyNv uc = new ucCrtQuanLyNv();
            DialogResult dialog = new DialogResult();
             dialog =  MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn thêm khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                uc.Dock = DockStyle.Fill;
                pn.Controls.Clear();
                pn.Controls.Add(uc);
            }
            
        }

        private void tabPageLapHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void metroSetButton2_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void ucQuanLyHd_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            IEnumerable<tblHoaDon> dshd;
            dshd = hoaDon.GetAllHoaDons();
            createColumn(lvwDsHoaDon);
            loadHdToListViewTheoNam(lvwDsHoaDon, dshd);
        }
    }
}
