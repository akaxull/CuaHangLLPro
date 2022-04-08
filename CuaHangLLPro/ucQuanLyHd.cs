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
        int soLuongSachTrongListView = 0;
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
            addAutoCompleteSourMaKh();
            cboTim.SelectedItem = "Mã nhân viên";
            createColumn(lvwDsHoaDon);
            loadHdToListView(lvwDsHoaDon, dshd);

            // TRANG 2
            sach = new clsSach();
         //   lvwSach.Font.Size = 14;
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
        void createColumn(ListView lvw)
        {
            lvw.Columns.Add("Mã hóa đơn", 240);
            lvw.Columns.Add("Tên khách hàng", 250);
            lvw.Columns.Add("Tên nhân viên", 290);
            lvw.Columns.Add("Ngày lập hóa đơn", 240);
            lvw.Columns.Add("Giảm giá(%)", 150);
            lvw.Columns.Add("Tổng tiền", 150);
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
            txtSoDt1.AutoCompleteCustomSource = souceItems;
        }           

        private void btnThemSach_Click(object sender, EventArgs e)
        { 
            if (txtSl.Text.Equals("Nhập SL") || txtSl.Text.Equals("") || txtMaSach.Text.Equals("") || txtMaSach.Text.Equals("Nhập mã sách") )
            {
                if (txtMaSach.Text.Equals("") || txtMaSach.Text.Equals("Nhập mã sách"))
                {
                    txtMaSach.Focus();
                    errorProvider1.SetError(txtMaSach, "Bạn phải chọn sách");
                }
                else
                {
                    txtSl.Focus();
                    errorProvider1.SetError(txtSl, "Bạn phải nhập số lượng sách");
                }
            }
            else
            {
                if (sach.DemSoLuongSach(txtTenSach.Texts) <= 0)
                {
                    txtSl.Focus();
                    errorProvider1.SetError(txtMaSach, "Sách đã hết hàng vui lòng chọn sách khác");
                }
                else
                {
                    MessageBox.Show(txtTenSach.Texts, txtTenSach.Texts, MessageBoxButtons.OK);
                    if (sach.checkSachTonTai(txtTenSach.Texts.ToString()))
                    {
                        loadSachToListView(lvwSach);                  
                        txtMaSach.Text = "Nhập mã sách";
                        txtMaSach.ForeColor = Color.DarkGray;
                        txtTenSach.Texts = "";
                        txtSoDt1.Text = "Nhập số điện thoại khách hàng";
                        txtSoDt1.ForeColor = Color.DarkGray;
                        txtTenK.Texts = "";
                        txtSl.Text = "Nhập SL";
                        txtSl.ForeColor = Color.DarkGray;

                        txtThanhTien.Text = (tongTien - tongTien * Convert.ToInt32(txtGiamGia.Text) / 100).ToString();
                        txtTongTien.Text = tongTien.ToString();
                        txtTongSach.Text = soLuongSach.ToString();
                        errorProvider1.SetError(lvwSach, null);
                    }
                    else
                    {
                        txtMaSach.Focus();
                        MessageBox.Show("Sách không tồn tại", "Lỗi", MessageBoxButtons.OK);
                    }
                }
            }
        }
        void loadSachToListView(ListView lvw)
        {
            // lvw.Items.Clear();
            ListViewItem item;
            tblSach s = sach.getTblSachTuMa(txtMaSach.Text.ToString());
            tblSach s1;
            bool isExist = false;
            int sl = 0;
            foreach (ListViewItem item1 in lvw.Items)
            {
                s1 = (tblSach)item1.Tag;
                if( s1.MaSach.Contains(txtMaSach.Text.ToString()) )
                {
                    sl = Convert.ToInt32(txtSl.Text) + Convert.ToInt32(item1.SubItems[2].Text);
                    item1.SubItems[2].Text = sl.ToString();
                    item1.SubItems[5].Text = thanhTien( s.GiaTien , Thue(s1.TheLoai), sl).ToString();
                    isExist = true;
                    soLuongSach = soLuongSach + Convert.ToInt32(txtSl.Text);
                    soLuongSachTrongListView = sl; 
                    tongTien = tongTien + thanhTien(s.GiaTien, Thue(s.TheLoai), Convert.ToInt32(txtSl.Text));
                    break;
                }

            }
            if(!isExist)
            {
                item = GenerateItemSach(s, txtSl.Text.ToString());
                sl = Convert.ToInt32(txtSl.Text);
                lvw.Items.Add(item);
                soLuongSach = soLuongSach + sl;
                soLuongSachTrongListView = sl; ;
                tongTien = tongTien + thanhTien(s.GiaTien, Thue(s.TheLoai), sl);
            }          
                     
            //      lvwSach.Select;

        }

        private void txtSoDt1_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name.ToString())
            {
                case "txtSoDt1":
                    if (txtSoDt1.Text == "")
                    {
                        txtSoDt1.Text = "Nhập số điện thoại khách hàng";
                        txtSoDt1.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        if (khachHang.checkTonTaiKhach(txtSoDt1.Text))
                            txtTenK.Texts = khachHang.getKhTuSDt(txtSoDt1.Text.ToString()).TenKhachHang.ToString();
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Khách hàng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    break;
                case "txtMaSach": 
                    if (txtMaSach.Text == "")
                    {
                        txtMaSach.Text = "Nhập mã sách";
                        txtMaSach.ForeColor = Color.DarkGray;
                    }
                    else 
                    {
                        if (sach.checkSachTonTaiMa(txtMaSach.Text))
                            txtTenSach.Texts = sach.getTenSachTuMa(txtMaSach.Text);
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Sách không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                       
                case "txtSl": 
                    if (txtSl.Text == "")
                    {
                        txtSl.Text = "Nhập SL";
                        txtSl.ForeColor = Color.DarkGray;
                    }
                    break;
                case "txtTim":
                    if (txtTim.Text == "")
                    {
                        switch (cboTim.SelectedItem)
                        {
                            case "Mã nhân viên":
                                txtTim.Text = "Nhập mã nhân viên";
                                txtTim.ForeColor = Color.DarkGray; ;
                                break;

                            case "Mã hóa đơn":
                                txtTim.Text = "Nhập mã hóa đơn";
                                txtTim.ForeColor = Color.DarkGray; ;
                                break;
                            case "Mã khách hàng":
                                txtTim.Text = "Nhập mã khách hàng";
                                txtTim.ForeColor = Color.DarkGray; ;
                                break;
                        }
                        
                    }
                    break;
            } 
           /* */
                
        }
      
        private void txtSoDt1_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            //  MessageBox.Show(txt.Name.ToString(), txt.Name.ToString(), MessageBoxButtons.OK);
            switch (txt.Name.ToString())
            {
                case "txtSoDt1":
                    if (txtSoDt1.Text == "Nhập số điện thoại khách hàng")
                    {
                        txtSoDt1.Text = null;
                        txtSoDt1.ForeColor = Color.Black;
                    }
                    break;
                case "txtMaSach":
                    errorProvider1.SetError(txtMaSach, null);
                    if (txtMaSach.Text == "Nhập mã sách")
                    {
                        txtMaSach.Text = "";
                        txtMaSach.ForeColor = Color.Black;
                    }
                    break;

                case "txtSl":
                    errorProvider1.SetError(txtSl, null);
                    if (txtSl.Text == "Nhập SL")
                    {
                        txtSl.Text = "";
                        txtSl.ForeColor = Color.Black;
                    }
                    break;
                case "txtTim":
                    if (txtTim.Text == "Nhập mã nhân viên" || txtTim.Text == "Nhập mã hóa đơn" || txtTim.Text == "Nhập mã khách hàng")
                    {
                        txtTim.Text = "";
                        txtTim.ForeColor = Color.Black;
                    }
                    break;

            }
        }

        private void addAutoCompleteSourMaNV()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblNhanVien> dsNv = nhanVien.getAllNhanVien();
            foreach (tblNhanVien nv in dsNv)
            {
                souceItems.Add(nv.MaNhanVien);
            }
            txtTim.AutoCompleteCustomSource = souceItems;
        }

        private void addAutoCompleteSourMaKh()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblKhachHang> dsKh = khachHang.GetAllKh();
            foreach (tblKhachHang k in dsKh)
            {
                souceItems.Add(k.MaKhachHang);
            }
            txtTim.AutoCompleteCustomSource = souceItems;
        }

        private void addAutoCompleteSourMaHD()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblHoaDon> dsHD = hoaDon.GetAllHoaDons();
            foreach (tblHoaDon hd in dsHD)
            {
                souceItems.Add(hd.MaHoaDon);
            }
            txtTim.AutoCompleteCustomSource = souceItems;
        }

        private void addAutoCompleteSourcTenSach()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblSach> dsSach = sach.GetTblSach();
            foreach (tblSach s in dsSach)
            {
                if(s.TrangThai)
                    souceItems.Add(s.MaSach);
            }
            txtMaSach.AutoCompleteCustomSource = souceItems;
        }
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (lvwSach.Items.Count <= 0)
            {
                errorProvider1.SetError(lvwSach, "Hóa đơn chưa có sách");
                txtMaSach.Focus();
            }
            else if (!txtTienKhachDua.Text.Equals(""))
            {
                if (txtTienKhachDua.Text.tienChek() == false)
                {
                    errorProvider2.SetError(txtTienKhachDua, "Số tiền phải lớn hơn 10 và bé hơn 1.000.000.000 và không được chứa kí tự khác số tự nhiên");
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
           // (tblHoaDon)lvwDsHoaDon.SelectedItems[0].Tag;
            if (lvwSach.SelectedItems.Count > 0)
            {
              //  lvwSach.Items = lvwDsHoaDon.SelectedIndices[0];
                int tmp = Convert.ToInt32(lvwSach.SelectedItems[0].SubItems[2].Text);
                soLuongSach -= tmp;
               
                txtTongSach.Text = soLuongSach.ToString();
                int tmp2 = Convert.ToInt32(lvwSach.SelectedItems[0].SubItems[3].Text);
                tongTien -= tmp2;
                txtTongTien.Text = tongTien.ToString();
                txtThanhTien.Text = (tongTien - tongTien * Convert.ToInt32(txtGiamGia.Text) / 100).ToString();
                lvwSach.Items.RemoveAt(lvwSach.SelectedIndices[0]);
            }
            
            
        }

        private int thanhTien(int tien , int vat, int soLuong)
        {
            return (tien + tien * vat / 100)*soLuong;
        }
        ListViewItem GenerateItemSach(tblSach s, string sl)
        {
            ListViewItem lvwItems;
            lvwItems = new ListViewItem(s.MaSach);
            lvwItems.SubItems.Add(s.TenSach);
            lvwItems.SubItems.Add(sl);
            lvwItems.SubItems.Add(s.GiaTien.ToString());
            lvwItems.SubItems.Add(Thue(s.TheLoai).ToString());
            lvwItems.SubItems.Add(thanhTien(s.GiaTien, Thue(s.TheLoai), Convert.ToInt32(sl)).ToString());
            tblSach tmp = new tblSach();
            tmp = s;
            tmp.SoLuong = Convert.ToInt32(sl);
            lvwItems.Tag = s;
            return lvwItems;

        }

        private int Thue(string loaisach)
        {
            switch (loaisach)
            {
                case "Khoa học công nghệ":
                    return 0;
                    break;
                case "Chính trị pháp luật":
                    return 0;
                case "Giáo Trình":
                    return 0;
                    break;
                default:
                    return 10;
                    break;
            }
        }
        //30 100 30

        void createColumnSach(ListView lvw)
        {
           // lvw.Columns.fo
            lvw.Columns.Add("Mã sách", 150);
            lvw.Columns.Add("Tên sách", 350);
            lvw.Columns.Add("Sl", 70);
            lvw.Columns.Add("Đơn giá", 100);
            lvw.Columns.Add("VAT(%)", 90);
            lvw.Columns.Add("Thành Tiền", 160);
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
            if (txtSoDt1.Text.Equals("Nhập số điện thoại khách hàng"))
                hoaDon.MaKhachHang = null;
            else
            {
                tblKhachHang k = khachHang.getKhTuSDt(txtSoDt1.Text.ToString());
                hoaDon.MaKhachHang = k.MaKhachHang;
            }          
            hoaDon.MaNhanVien = maNV;
            hoaDon.NgayXuatHoaDon = daytime;
            hoaDon.GiamGia = Convert.ToInt32(txtGiamGia.Text);
            hoaDon.TongTien = Convert.ToInt32(txtTongTien.Text);
            return hoaDon;

        }

        tblChiTietHoaDon taoHoaDonChiTiet(tblHoaDon hd, string maSach, int Sl)
        {
            tblChiTietHoaDon hoaDon = new tblChiTietHoaDon();
            hoaDon.MaHoaDon = hd.MaHoaDon;           
            hoaDon.MaSach = maSach;
            hoaDon.SoLuong = Sl;             
            return hoaDon;

        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            int count = 0;
            tblHoaDon hd = taoHoaDon();           
            bool x = hoaDon.add(hd);
            bool y = false;
            bool z = false;
            if (x)
            {
                foreach (ListViewItem item in lvwSach.Items)
                {
                    tblChiTietHoaDon hdChiTiet = taoHoaDonChiTiet(hd, item.Text.ToString(), Convert.ToInt32(item.SubItems[2].Text));
                    y = hoaDon.addHdChiTiet(hdChiTiet);
                    z = sach.suaSlSach(hdChiTiet, hdChiTiet.SoLuong);
                }
            }
            if (y && z)
            {
                frmChiTietHoaDon frm = new frmChiTietHoaDon(hd);
                frm.ShowDialog();
                txtMaSach.Text = "Nhập mã sách";
                txtMaSach.ForeColor = Color.DarkGray;
                txtTenSach.Texts = "";
                txtSoDt1.Text = "Nhập số điện thoại khách hàng";
                txtSoDt1.ForeColor = Color.DarkGray;
                txtTenK.Texts = "";
                txtSl.Text = "Nhập SL";
                txtSl.ForeColor = Color.DarkGray;
                txtGiamGia.Text = "0";
                txtThanhTien.Text = "";
                txtTienKhachDua.Text = "";
                txtTienThoi.Text = "0";
                txtTongSach.Text = "0";
                txtTongTien.Text = "0";
                txtSoDt1.Focus();
                lvwSach.Clear();
            }

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

  

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaSach, null);
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSl, null);
        }

      

        private void cboTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTim.SelectedItem)
            {
                case "Mã nhân viên":
                    txtTim.Text = "Nhập mã nhân viên";
                    txtTim.ForeColor = Color.DarkGray; ;
                    addAutoCompleteSourMaNV();
                    break;

                case "Mã hóa đơn":
                    txtTim.Text = "Nhập mã hóa đơn";
                    txtTim.ForeColor = Color.DarkGray;
                    addAutoCompleteSourMaHD();
                    break;
                case "Mã khách hàng":
                    txtTim.Text = "Nhập mã khách hàng";
                    txtTim.ForeColor = Color.DarkGray;
                    addAutoCompleteSourMaKh();
                    break;
            }
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IEnumerable<tblHoaDon> dshd;
            switch (cboTim.SelectedItem)
            {
                case "Mã nhân viên":
                    dshd = hoaDon.GetHoaDonTheoMaNV(txtTim.Text.ToString());
                    loadHdToListView(lvwDsHoaDon, dshd);
                    break;

                case "Mã hóa đơn":
                    dshd = hoaDon.GetHoaDonTheoMa(txtTim.Text.ToString());
                    loadHdToListView(lvwDsHoaDon, dshd);
                    break;
                case "Mã khách hàng":
                    dshd = hoaDon.GetHoaDonTheoMaKH(txtTim.Text.ToString());
                    loadHdToListView(lvwDsHoaDon, dshd);
                    break;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IEnumerable<tblHoaDon> dshd = hoaDon.GetAllHoaDons();
            loadHdToListView(lvwDsHoaDon, dshd);
        }

        private void txtTienKhachDua_Leave(object sender, EventArgs e)
        {

        }
    }
}
