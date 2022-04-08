using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangLLPro.Properties;

namespace CuaHangLLPro
{

    public partial class uCtrKh : UserControl
    {
        clsKh kh;
        public uCtrKh()
        {
            InitializeComponent();
        }
        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            kh = new clsKh();
            btnLuu.Enabled = false;
            TaoTieuDeCot(lvwDanhSachKhachHang);
            IEnumerable<tblKhachHang> dsnv = kh.GetAllKh();
            LoadKhachHangToListView(lvwDanhSachKhachHang, dsnv);
            txtTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            XuLyHoTroAutocomlet();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Ma Khách Hàng", 100);
            lvw.Columns.Add("Tên Khách Hàng", 300);
            lvw.Columns.Add("SDT", 100);
            lvw.Columns.Add("Giới Tính", 100);
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
        ListViewItem AddItem(tblKhachHang kh)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(kh.MaKhachHang);
            lvwItem.SubItems.Add(kh.TenKhachHang);
            lvwItem.SubItems.Add(kh.Sdt);   
            lvwItem.SubItems.Add(kh.GioiTinh);
            lvwItem.Tag = kh;
            return lvwItem;
        }
        void LoadKhachHangToListView(ListView lvw, IEnumerable<tblKhachHang> dskh)
        {

            lvw.Items.Clear();
            ListViewItem itemKhach;
            foreach (tblKhachHang kh in dskh)
            {
                itemKhach = AddItem(kh);
                lvw.Items.Add(itemKhach);
            }
        }
        void KhachHangToTextBox(tblKhachHang kh)
        {
            txtma.Text = kh.MaKhachHang;
            txtTen.Text = kh.TenKhachHang;
            txtSDT.Text = kh.Sdt;

            if (kh.GioiTinh.Trim().Length == 3)
            {
                radnam.Checked = true;
            }
            else
            {
                radnu.Checked = true;
            }
        }

        tblKhachHang TaoKhach()
        {
            tblKhachHang kh = new tblKhachHang();
            kh.MaKhachHang = txtma.Text;
            kh.TenKhachHang = txtTen.Text;
            kh.Sdt = txtSDT.Text;
            if (radnam.Checked == true)
            {
                kh.GioiTinh = radnam.Text;
            }
            else
            {
                kh.GioiTinh = radnu.Text;
            }
            return kh;
        }

        private void lvwDanhSachKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblKhachHang kh = null;
            if (lvwDanhSachKhachHang.SelectedItems.Count > 0)//co chon
            {
                kh = (tblKhachHang)lvwDanhSachKhachHang.SelectedItems[0].Tag;
                KhachHangToTextBox(kh);
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {

            tblKhachHang kh1 = TaoKhach();
            kh.ThemKH(kh1);
            IEnumerable<tblKhachHang> dsnv = kh.GetAllKh();
            LoadKhachHangToListView(lvwDanhSachKhachHang, dsnv);
            btnThem.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtTen.Text.Trim().CheckName())
            {
                MessageBox.Show("Họ Và Tên Nhập Không Dấu,Viết ho chữ cái đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (!txtSDT.Text.Trim().PhoneCheck())
            {
                MessageBox.Show("Phải Bắt đầu bằng số 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            tblKhachHang kh1 = TaoKhach();
            kh.Suanv(kh1);
            IEnumerable<tblKhachHang> dsnv = kh.GetAllKh();
            LoadKhachHangToListView(lvwDanhSachKhachHang, dsnv);
        }
        void XuLyHoTroAutocomlet()
        {
            IEnumerable<tblKhachHang> dskh;
            dskh = kh.GetAllKh();
            txtTim.AutoCompleteCustomSource.Clear();

            foreach (tblKhachHang kh1 in dskh)
            {
                txtTim.AutoCompleteCustomSource.Add(kh1.MaKhachHang.ToString());
            }
        }

        int TimKiem(string strGiaTriTim)
        {
            tblKhachHang kh1;
            for (int i = 0; i < lvwDanhSachKhachHang.Items.Count; i++)
            {
                kh1 = (tblKhachHang)lvwDanhSachKhachHang.Items[i].Tag;

                if (kh1.MaKhachHang.ToString().Equals(strGiaTriTim))
                    return i;
            }
            return -1;
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            string strthongtintim = txtTim.Text;
            int vitritim = TimKiem(strthongtintim);
            int vitrichontruoc;
            if (vitritim >= 0)
            {
                if (lvwDanhSachKhachHang.SelectedItems.Count > 0)
                {
                    vitrichontruoc = lvwDanhSachKhachHang.SelectedIndices[0];
                    lvwDanhSachKhachHang.Items[vitrichontruoc].Selected = false;
                }
                lvwDanhSachKhachHang.Items[vitritim].Selected = true;
                lvwDanhSachKhachHang.Focus();
            }
            else
            {
                MessageBox.Show("Không có thông tin bạn muốn tìm vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnThem_Click_1(object sender, EventArgs e)
        {

           
            txtma.Text = kh.CreateKeyKH("KH",txtTen.Text);
            if (!txtTen.Text.Trim().CheckName())
            {
                MessageBox.Show("Họ Và Tên Nhập Không Dấu,Viết ho chữ cái đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (!txtSDT.Text.Trim().PhoneCheck())
            {
                MessageBox.Show("Phải Bắt đầu bằng số 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return;
            }
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {

            LoadKhachHangToListView(lvwDanhSachKhachHang, kh.SXTangTheoTen());
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {

            LoadKhachHangToListView(lvwDanhSachKhachHang, kh.SXGiamTheoten());
        }

        private void uCtrKh_Load(object sender, EventArgs e)
        {
            kh = new clsKh();
            btnLuu.Enabled = false;
            TaoTieuDeCot(lvwDanhSachKhachHang);
            IEnumerable<tblKhachHang> dsnv = kh.GetAllKh();
            LoadKhachHangToListView(lvwDanhSachKhachHang, dsnv);
            txtTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            XuLyHoTroAutocomlet();
        }
    }
}
