using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuaHangLLPro.Properties;

namespace CuaHangLLPro
{
    public partial class uCrtSach : UserControl
    {
        clsSach sach;
        // clsChucNang chucNang;
        string radName = "";
        public uCrtSach()
        {
            InitializeComponent();
         
        }
        private void uCrtSach_Load(object sender, EventArgs e)
        {
            sach = new clsSach();
            IEnumerable<tblSach> dsSach;
            dsSach = sach.GetAllSach();
            createColumn(lvwS);
            loadSToListView(lvwS, dsSach);
            cbxTim.SelectedIndex = cbxTim.FindString("Tên sách");
           // addAutoCompleteSourcTenSach();
            
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            tblSach sachSelected = new tblSach();
            frmThongTinSach frm = new frmThongTinSach(this, true);
            frm.ShowDialog();
        }

        private void lvwDsHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblHoaDon hoaDonSelect = new tblHoaDon();
            if (lvwS.SelectedItems.Count > 0)
            {
                hoaDonSelect = (tblHoaDon)lvwS.SelectedItems[0].Tag;
                frmChiTietHoaDon frm = new frmChiTietHoaDon(hoaDonSelect);
                frm.ShowDialog();

            }

        }
        void loadSToListView(ListView lvw, IEnumerable<tblSach> dsSach)
        {
            lvw.Items.Clear();
            ListViewItem item;
            int count = 1;
            foreach (tblSach s in dsSach)
            {
                if ((bool)s.TrangThai)
                {
                    item = GenerateItem(s, count);
                    lvw.Items.Add(item);
                    count++;
                }
                else
                    continue;

            }                
        }

        void loadSNgungKdToListView(ListView lvw, IEnumerable<tblSach> dsSach)
        {
            lvw.Items.Clear();
            ListViewItem item;
            int count = 1;
            foreach (tblSach s in dsSach)
            {
                item = GenerateItem(s, count);
                lvw.Items.Add(item);
                count++;
            }
        }
        void createColumn(ListView lvw)
        {
            lvw.Columns.Add("STT", 50);
            lvw.Columns.Add("Mã sách", 100);
            lvw.Columns.Add("Tên sách", 290);
            lvw.Columns.Add("Thể loại", 170);
            lvw.Columns.Add("SL", 60);
            lvw.Columns.Add("Giá tiền", 70);
            lvw.Columns.Add("Tác gỉả", 200);
            lvw.Columns.Add("Nhà Xuất Bản", 160);
            // lvw.Columns.Add("", 30);
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;

            //  lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        ListViewItem GenerateItem(tblSach s, int stt)
        {
            ListViewItem lvwItems;
            lvwItems = new ListViewItem(stt.ToString());
            lvwItems.SubItems.Add(s.MaSach);
            lvwItems.SubItems.Add(s.TenSach);
            lvwItems.SubItems.Add(s.TheLoai);
            lvwItems.SubItems.Add(Convert.ToString(s.SoLuong));
            lvwItems.SubItems.Add(Convert.ToString(s.GiaTien));
            lvwItems.SubItems.Add(s.TacGia);
            lvwItems.SubItems.Add(s.NhaXuatBan);
            lvwItems.Tag = s;

            return lvwItems;
        }

        


        private void btnTim_Click(object sender, EventArgs e)
        {
            clsSach sachTmp = new clsSach();
            string str = "";
            if (txtTim.Text == "Nhập mã sách" || txtTim.Text == "Nhập tên tác giả" || txtTim.Text == "Nhập tên Nhà xuất bản" || txtTim.Text == "Nhập tên sách")
            {
                str = txtTim.Text.ToString();
            }
            bool test = false;
            string tmp = "";
            tmp = cbxTim.SelectedItem.ToString();
            IEnumerable<tblSach> dsSach = null;
            switch (tmp)
            {
                case "Tên sách":
                    dsSach = sachTmp.getSachTuTenS(str);
                    break;
                case "Tên tác giả":
                    dsSach = sachTmp.getSachTuTenTg(str);
                    break;
                case "Mã Sách":
                    dsSach = sachTmp.getSachTuMa(str);
                    break;
                case "Nhà xuất bản":
                    dsSach = sachTmp.getSachTuNxb(str);
                    break;

            }    
            
            if (radName != "")
            {
                switch (radName)
                {
                    case "radHet":
                        dsSach = sachTmp.getSachHetHang(dsSach);
                        break;
                    case "radCon":
                        dsSach = sachTmp.getSachConHang(dsSach);
                        break;
                    case "radNgungKinhDoanh":
                        test = true;
                        dsSach = sachTmp.getSachNgungKinhDoanh(dsSach);
                        break;
                    default:
                        break;
                }

            }

            string loaiSach = strLoai();
            if (loaiSach != "")
            {
                dsSach = sachTmp.getSachTheoRad(loaiSach, dsSach);
            }
            if (test)
                loadSNgungKdToListView(lvwS, dsSach);
            else
                loadSToListView(lvwS, dsSach);
        }

   


        private string strLoai()
        {
            string strTim = "";
            if (radTn.Checked)
                strTim = strTim + "Sách thiếu nhi";

            if (radVhLs.Checked)
                strTim = strTim + "Văn hóa xã hội – lịch sử";

            if (radKhcn.Checked)
                strTim = strTim + "Khoa học công nghệ";

            if (radVhNt.Checked)
                strTim = strTim + "Văn học nghệ thuật";

            if (radCtPL.Checked)
                strTim = strTim + "Chính trị pháp luật";

            if (radTlTg.Checked)
                strTim = strTim + "Tâm linh tôn giáo";

            if (radGt.Checked)
                strTim = strTim + "Giáo Trình";

            if (radTt.Checked)
                strTim = strTim + "*Truyện Tiểu Thuyết";
            return strTim;
        }

        private void radTt_CheckedChanged(object sender, EventArgs e)
        {
            string strTim = "";
            if (radCtPL.Checked)
                strTim = strTim + "Sách thiếu nhi";

            if (radVhLs.Checked)
                strTim = strTim + "Văn hóa xã hội – lịch sử";

            if (radKhcn.Checked)
                strTim = strTim + "Khoa học công nghệ";

            if (radVhNt.Checked)
                strTim = strTim + "Văn học nghệ thuật";

            if (radCtPL.Checked)
                strTim = strTim + "Chính trị pháp luật";

            if (radTlTg.Checked)
                strTim = strTim + "Tâm linh tôn giáo";

            if (radGt.Checked)
                strTim = strTim + "Giáo Trình";

            if (radTt.Checked)
                strTim = strTim + "*Truyện Tiểu Thuyết";

        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            int coutItems = 0;
            DialogResult a;
            string ten = "";
            int TMP = lvwS.SelectedItems.Count;
            while (coutItems < lvwS.SelectedItems.Count)
            {
                tblSach sachTml = (tblSach)lvwS.SelectedItems[coutItems].Tag;
                if (coutItems == 0)
                {
                    ten = ten + sachTml.TenSach;
                }
                else
                    ten = ten+ ", " + sachTml.TenSach;
                coutItems++;
            }
            coutItems = 0;
            a = MetroFramework.MetroMessageBox.Show(this, "Bạn muốn  xóa sách : " + ten +".", "Thông báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                while (coutItems < lvwS.SelectedItems.Count)
                {
                    tblSach sachTml = (tblSach)lvwS.SelectedItems[coutItems].Tag;
                    sach.XoaSach(sachTml);
                    coutItems++;

                }
                IEnumerable<tblSach> dsSauXoa;
                dsSauXoa = sach.GetAllSach();
                loadSToListView(lvwS, dsSauXoa);
            }
        }

        
        private void lvwS_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                     
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
      {
            bool isDigit = e.KeyChar >= '0' && e.KeyChar <= '9';
            bool isBackspace = e.KeyChar == '\b';

            // If we get anything other than a digit or backspace, tell the rest of
            // the event processing logic to ignore this event
            if (!isDigit && !isBackspace)
            {
                e.Handled = true;
            }
        }

       

        private AutoCompleteStringCollection addAutoCompleteSourcTenSach()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblSach> dsSach = sach.GetTblSach();
            foreach (tblSach s in dsSach)
            {
                souceItems.Add(s.TenSach);
            }
            return souceItems;
        }
        
        private AutoCompleteStringCollection addAutoCompleteSourcTenTg()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblSach> dsSach = sach.GetTblSach();
            foreach (tblSach s in dsSach)
            {
                souceItems.Add(s.TacGia);
            }
            return souceItems;
        }

        private AutoCompleteStringCollection addAutoCompleteSourcNxb()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblSach> dsSach = sach.GetTblSach();
            foreach (tblSach s in dsSach)
            {
                souceItems.Add(s.NhaXuatBan);
            }
            return souceItems;
        }
        private AutoCompleteStringCollection addAutoCompleteSourcMa()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();
            IEnumerable<tblSach> dsSach = sach.GetTblSach();
            foreach (tblSach s in dsSach)
            {
                souceItems.Add(s.MaSach);
            }
            return souceItems;
        }

        private void cbxTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cbxTim.SelectedIndex.ToString();

            switch (str)
            {
                case "0":
                    txtTim.AutoCompleteCustomSource = addAutoCompleteSourcTenSach();
                    break;
                case "1":
                    txtTim.AutoCompleteCustomSource = addAutoCompleteSourcTenTg();
                    break;
                case "2":
                    txtTim.AutoCompleteCustomSource = addAutoCompleteSourcMa();
                    break;
                case "3":
                    txtTim.AutoCompleteCustomSource = addAutoCompleteSourcNxb();
                    break;
            }

        }

        private void txtTim_Enter(object sender, EventArgs e)
        {
            if (txtTim.Text == "Nhập mã sách" || txtTim.Text == "Nhập tên tác giả" || txtTim.Text == "Nhập tên Nhà xuất bản" || txtTim.Text == "Nhập tên sách")
            {
                txtTim.Text = "";
                txtTim.ForeColor = Color.Black;
            }
        }
        private void txtTim_Leave(object sender, EventArgs e)
        {
            switch (cbxTim.SelectedItem)
            {
                case "Tên sách":
                    txtTim.Text = "Nhập tên sách";
                    txtTim.ForeColor = Color.DarkGray; ;
                    break;

                case "Tên tác giả":
                    txtTim.Text = "Nhập tên tác giả";
                    txtTim.ForeColor = Color.DarkGray; ;
                    break;
                case "Mã sách":
                    txtTim.Text = "Nhập mã sách";
                    txtTim.ForeColor = Color.DarkGray; ;
                    break;
                case "Nhà xuất bản":
                    txtTim.Text = "Nhập tên Nhà xuất bản";
                    txtTim.ForeColor = Color.DarkGray; ;
                    break;
            }
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                RadioButton rb = (RadioButton)sender;
                radName = rb.Name;
            }
        }

        public void refreshListView()
        {
            btnTim.PerformClick();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            tblSach sachSelected = new tblSach();
            if (lvwS.SelectedItems.Count > 0)
            {
                sachSelected = (tblSach)lvwS.SelectedItems[0].Tag;
                if (radNgungKinhDoanh.Checked)

                {
                    DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Bạn có muốn kinh doanh lại sách '" + sachSelected.TenSach + "' ?", "Thông báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    {
                        if(dialog == DialogResult.Yes)
                        {
                            sachSelected.TrangThai = true;
                            if(sach.suaSach(sachSelected))
                                MetroFramework.MetroMessageBox.Show(this, "Sửa thành công", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Sửa thất bại", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                sachSelected = (tblSach)lvwS.SelectedItems[0].Tag;
                frmThongTinSach frm = new frmThongTinSach(sachSelected, this, false);
                frm.ShowDialog();
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            frmExcel frm = new frmExcel();
            frm.ShowDialog();
        }
    }
}
