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
        BindingSource bsSach;
        clsSach sach;
        clsKetNoi dt;
       // clsChucNang chucNang;
        int count;
        bool test= true;
        IEnumerable<tblSach> listSach;
        bool check = true;
        int tmp = 0;
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
            txtLoai.AutoCompleteCustomSource = addAutoCompleteSourcTheLoai();
          //  addAutoCompleteSourcTenSach();
            
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            tmp = 1;
            if (btnThemSach.Text != "Hủy")
            {
                clearText();
                btnXoaSach.Enabled = false;
                btnThemSach.Text = "Hủy";
            }
            else
            {
                DialogResult a;
                a = MetroFramework.MetroMessageBox.Show(this, "Bạn muốn đùng thêm và xóa thông tin vừa nhập", "Thông báo", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    clearText();
                    btnXoaSach.Enabled = true;
                    btnThemSach.Text = "Thêm sách";
                }
            }
           
           
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
        void createColumn(ListView lvw)
        {
            lvw.Columns.Add("Stt", 30);
            lvw.Columns.Add("Mã sách", 90);
            lvw.Columns.Add("Tên sách", 220);
            lvw.Columns.Add("Thể loại", 130);
            lvw.Columns.Add("Số lượng", 50);
            lvw.Columns.Add("Giá tiền", 70);
            lvw.Columns.Add("Tác gỉả", 160);
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

        private string nameBook(string ten, int nam, string tacGia)
        {
            IEnumerable<tblSach> a;
            a = sach.GetAllSach();
            int demsach = 0;
            foreach (tblSach sacha in a)
            {
                demsach++;
            }
            int count = 0;
            string name = "BK" + ten[0].ToString();
            int tmp = 0;
            foreach (char s in ten)
            {
                if (count > 5)
                    break;
                if (s.ToString() == " ")
                {
                    tmp = 1;
                    continue;
                }
                if (tmp == 1)
                {
                    name = name + s.ToString();
                    tmp = 0;
                }
                count++;
            }

            return (name + demsach.ToString());
        }
        /*
        private void dataRowCheck(DataGridView drg , int index)
        {
            check = false;
            DataGridViewRow row = drg.Rows[index];
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.OwningColumn.Name.Equals("MaSach"))
                    continue;
                string name = cell.OwningColumn.Name;
              //  string value = drgSach.Rows[index].Cells[name].Value.ToString();
                //  int rowIndex = e.RowIndex;
                //  
                switch (name)
                {
                    case "TheLoai":
                        {
                            if (drgSach.Rows[index].Cells[name].Value.ToString().Equals(""))
                            {
                                MessageBox.Show("Bạn phải chọn thể loại sách", "", MessageBoxButtons.OK);
                                drgSach.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                                return;
                            }
                            break;
                        }

                    case "TenSach":
                        {
                            
                            if (drgSach.Rows[index].Cells[1].Value == null)
                            {
                                drgSach.Rows[index].Cells[1].Selected = true;
                                MessageBox.Show("Bạn phải ten sac", "", MessageBoxButtons.OK);
                                drgSach.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                                return;
                            }
                            ten = drgSach.Rows[index].Cells[1].Value.ToString();
                            break;
                        }
                    case "SoLuong":
                        {
                            if (drgSach.Rows[index].Cells[name].Value.ToString().Equals(""))
                            {
                                MessageBox.Show("Bạn phải nhập số lượng", "", MessageBoxButtons.OK);
                                drgSach.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                                break;
                            }
                            break;
                        }
                    case "TacGia":
                        if (drgSach.Rows[index].Cells[name].Value.ToString().Equals(""))
                        {
                            MessageBox.Show("Bạn phải nhập tên tác gỉả", "", MessageBoxButtons.OK);
                            drgSach.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                            return;
                        }
                        tg = drgSach.Rows[index].Cells[name].Value.ToString();
                      //  tg = drgSach.EditingControl.Text.ToString();

                        break;
                    case "NamXuatBan":
                        if (drgSach.Rows[index].Cells[cell.ColumnIndex].Value.ToString().Equals(""))
                        {
                            MessageBox.Show("Bạn nhập năm xuất bản", "", MessageBoxButtons.OK);
                            drgSach.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                            return;
                        }
                        date = drgSach.Rows[index].Cells[6].Value.ToString();
                        
                        break;
                    case "NhaXuatBan":
                        if (drgSach.Rows[index].Cells[name].IsInEditMode.ToString().Equals(""))
                        {
                            MessageBox.Show("Bạn phải nhập nhà xuât bản", "", MessageBoxButtons.OK);
                            drgSach.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                            return;
                        }
                        break;

                    case "GiaTien":
                        if (drgSach.Rows[index].Cells[name].Value.ToString().Equals(""))
                        {
                            MessageBox.Show("Bạn phải nhập gía tiền", "", MessageBoxButtons.OK);
                            drgSach.Rows[index].Cells[cell.ColumnIndex].Selected = true;
                            return;
                        }
                        break;
                }
                
            }
            check = true;
            drgSach.Rows[count].Cells[0].Value = nameBook(ten, Convert.ToInt32(date), tg);
            drgSach.Rows[count].Cells[8].Value = true;
        }
        */
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string str = txtTim.Text.ToString();
            string tmp = cbxTim.SelectedItem.ToString();
            IEnumerable<tblSach> dsSach = null;
            switch (tmp)
            {
                case "Tên sách":
                    dsSach = sach.getSachTuTenS(str);
                    break;
                case "Tên tác giả":
                    dsSach = sach.getSachTuTenTg(str);
                    break;
                case "Mã Sách":
                    dsSach = sach.getSachTuMa(str);
                    break;
                case "Nhà xuất bản":
                    dsSach = sach.getSachTuNxb(str);
                    break;

            }
            IEnumerable<tblSach> dsSach2 = null;
            string loaiSach = strLoai();
            if (loaiSach != "")
            {
                dsSach2 = sach.getSachTheoRad(loaiSach, dsSach);
                loadSToListView(lvwS, dsSach2);
            }
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

            /*
        *Sách thiếu nhi
        *Văn hóa xã hội – lịch sử
        *Khoa học công nghệ
        *Văn học nghệ thuật
        *Chính trị pháp luật
        *Tâm linh tôn giáo
        *Giáo Trình
        *Truyện Tiểu Thuyết
Tên tác giả
Mã Sách
Nhà xuất bản
        */
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
          //  clearText();
        }

        private void clearText()
        {
            txtSL.Text = "";
            txtTenSach.Text = "";
            txtLoai.Text = "";
            txtGg.Text = "";
            txtGia.Text = "";
            txtNam.Text = "";
            txtMa.Text = "";
            txtTg.Text = "";
            txtNxb.Text = "";
            tmp = 0;
        }
        private void lvwS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            clearText();
            if (lvwS.SelectedItems.Count > 0)
            {
                string sTrung = cbxTim.SelectedItem.ToString();
                tblSach sach = (tblSach)lvwS.SelectedItems[0].Tag;
                if (lvwS.SelectedItems.Count > 1)
                {
                    txtSL.Enabled = false;
                    txtTenSach.Enabled = false;
                    txtLoai.Enabled = false;
                    txtGg.Enabled = true;
                    txtGia.Enabled = true;
                    txtNam.Enabled = false;
                    switch (sTrung)
                    {
                        case "Tên tác giả":
                            txtTg.Text = sach.TacGia;
                            txtNxb.Enabled = false;
                            break;
                        case "Nhà xuất bản":
                            txtNxb.Text = sach.NhaXuatBan;
                            txtTg.Enabled = false;
                            break;

                    }
                }
                else
                {
                    txtSL.Text = sach.SoLuong.ToString();
                    txtTenSach.Text = sach.TenSach;
                    txtLoai.Text = sach.TheLoai;
                    txtGg.Text = sach.GiamGia.ToString();
                    txtGia.Text = sach.GiaTien.ToString();
                    txtNam.Text = sach.NamXuatBan.ToString();
                    txtMa.Text = sach.MaSach.ToString();
                    txtTg.Text = sach.TacGia;
                    txtNxb.Text = sach.NhaXuatBan;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (Checknhap())
            {
                tblSach s = new tblSach();
                s.TenSach = txtTenSach.Text.ToString();
                s.TheLoai = txtLoai.Text.ToString();
                s.SoLuong = Convert.ToInt32(txtSL.Text.ToString());
                s.TacGia = txtTg.Text.ToString();
                s.GiaTien = Convert.ToInt32(txtGia.Text.ToString());
                s.NamXuatBan = Convert.ToInt32(txtNam.Text.ToString());
                s.NhaXuatBan = txtNxb.Text.ToString();
                if (txtGg.Text.ToString().Equals(""))
                    s.GiamGia = 0;
                else
                    s.GiamGia = Convert.ToInt32(txtNam.Text.ToString());

                s.TrangThai = true;
                if(btnThemSach.Text == "Hủy"    )
                    txtMa.Text = nameBook(s.TenSach, Convert.ToInt32(s.NamXuatBan), s.TacGia);
                s.MaSach = txtMa.Text;
                //trung ten sach
                txtMa.Text = s.MaSach;
                if (btnThemSach.Text == "Hủy")
                {
                    
                    if (!sach.checkSachTonTai(s.TenSach))
                    {
                        DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Ban có muốn thêm sách " + s.TenSach + " vào cửa hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                        if (test == DialogResult.Yes)
                        {
                            int tmpMa = 1;
                            while (sach.checkSachTonTaiMa(s.MaSach))
                            {
                                s.MaSach = s.MaSach + tmpMa.ToString();
                                tmpMa++;
                            }
                            if (sach.addSach(s))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                                selectS(s.MaSach);
                                clearText();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        }
                    }
                    else
                    {
                        tblSach sachTmp = sach.getSachTuTen(s.TenSach);
                        if ((bool)sachTmp.TrangThai)
                        {

                            DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Sách " + sachTmp.TenSach + " đã có rồi bạn có muốn dừng thêm và sửa lại thông tin sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100);
                            int lvwCout = 0;
                            if (test == DialogResult.Yes)
                            {
                                foreach (ListViewItem item in lvwS.Items)
                                {
                                    tblSach tmpS = (tblSach)item.Tag;
                                    if (sachTmp.MaSach.Equals(tmpS.MaSach))
                                    {
                                        lvwS.Items[lvwCout].Selected = true;
                                        lvwS.Select();
                                        btnThemSach.Text = "Thêm sách";
                                        btnXoaSach.Enabled = true;
                                        break;
                                    }
                                    lvwCout++;
                                }
                            }
                            else
                                txtTenSach.Focus();
                        }
                        else
                        {
                            DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Sách đã ngừng kinh doanh bạn có muốn thêm lại vào cửa hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100);
                            if (test == DialogResult.Yes)
                            {
                                sachTmp.TrangThai = true;
                                if (sach.suaSach(sachTmp))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                                    selectS(sachTmp.MaSach);
                                }

                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);

                            }
                            else
                                txtTenSach.Focus();
                        }

                    }
                        //MessageBox.Show("T")
                                      
                }
                else
                {
                    if (lvwS.SelectedItems.Count == 0)
                        MetroFramework.MetroMessageBox.Show(this, "Ban chưa chọn sách! ","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                    else
                    {
                        DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Ban có muốn sửa thông tin sách " + s.TenSach +"?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                        if (test == DialogResult.Yes)
                        {
                            if (sach.suaSach(s))
                            {
                                selectS(s.MaSach);
                                MetroFramework.MetroMessageBox.Show(this, "Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);

                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        }
                    }
                }

            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Ban phải nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
        }
        private void selectS(string ma)
        {
            IEnumerable<tblSach> dsSach;
            dsSach = sach.GetAllSach();
            loadSToListView(lvwS, dsSach);
            int coutItem = 0;
            foreach (ListViewItem s in lvwS.Items)
            {
                tblSach sacTam = (tblSach)s.Tag;
                string strTam = sacTam.MaSach.Trim();
                string strTam1 = ma.Trim();
                if(strTam == strTam1)
                {
                    lvwS.Items[coutItem].Selected = true;
                    lvwS.Select();
                    break;
                }
                coutItem++;
            }

        }

        private bool Checknhap()
        {
            if (txtTenSach.Text.ToString() == "")
            {
                errorProvider1.SetError(txtTenSach, "Bạn phải nhập tên sách!");
                return false;
            }

            if (txtTg.Text.ToString() == "")
            {
                errorProvider1.SetError(txtTg, "Bạn phải nhập tên tác gỉả!");
                return false;

            }

            if (txtGia.Text.ToString() == "")
            {
                errorProvider1.SetError(txtGia, "Bạn phải nhập giá sách!");
                return false;

            }

            if (txtNam.Text.ToString() == "")
            {
                errorProvider1.SetError(txtNam, "Bạn phải nhập năm xuất bản!");
                return false;

            }

            if (txtSL.Text.ToString() == "")
            {
                errorProvider1.SetError(txtSL, "Bạn phải số lượng sách!");
                return false;

            }

            if (txtNxb.Text.ToString() == "")
            {
                errorProvider1.SetError(txtNxb, "Bạn phải nhập tên sách!");
                return false;
            }
            return true;
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            string name = a.Name;
            switch (name)
            {
                case "txtTenSach": 
                        errorProvider1.SetError(txtTenSach, null);
                        test = true;
                        break;
                case "txtTg":                
                        errorProvider1.SetError(txtTg, null);
                        test = true;
                        break;
                case "txtGia":                                         
                        errorProvider1.SetError(txtGia, null);
                        test = true;
                        break;
                case "txtNam":                   
                        
                        errorProvider1.SetError(txtNam, null);
                        test = true;
                        break;
                case "txtSL":
                    
                        errorProvider1.SetError(txtSL, null);
                        test = true;
                        break;
   
                case "txtNxb":
                   
                        errorProvider1.SetError(txtNxb, null);
                        test = true;
                        break;
            }
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

        private void txtTenSach_Leave(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            string name = a.Name;
            switch (name)
            {
                case "txtTenSach":
                    txtTenSach.Text = clsChucNang.PerfectString1(txtTenSach.Text.ToString());
                    break;

                case "txtNxb":
                    txtNxb.Text = clsChucNang.PerfectString1(txtNxb.Text.ToString());
                    break;
            }
            // TextBox test = (te)sender;
            
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
        private AutoCompleteStringCollection addAutoCompleteSourcTheLoai()
        {
            AutoCompleteStringCollection souceItems = new AutoCompleteStringCollection();        
            souceItems.Add("Sách thiếu nhi");
            souceItems.Add("Văn hóa xã hội – lịch sử");
            souceItems.Add("Văn học nghệ thuật");
            souceItems.Add("Chính trị pháp luật");
            souceItems.Add("Khoa học công nghệ");
            souceItems.Add("Giáo Trình");
            souceItems.Add("Truyện tiểu thuyết");
            souceItems.Add("Tâm linh tôn giáo");
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
    }
}
