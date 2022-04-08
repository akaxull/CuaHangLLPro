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
    public partial class frmThongTinSach : MetroFramework.Forms.MetroForm
    {
        uCrtSach uCrtl = new uCrtSach();
        bool test = true;
        bool isAdd = false;
        clsSach sach;
        tblSach s;
        public frmThongTinSach()
        {
            InitializeComponent();

        }
        public frmThongTinSach(tblSach TblSach, uCrtSach ucrt, bool tmp)
        {
            
            s = TblSach;
            uCrtl = ucrt;
            isAdd = tmp;
            InitializeComponent();

        }
        public frmThongTinSach(uCrtSach ucrt, bool tmp)
        {
            uCrtl = ucrt;
            isAdd = tmp;
            InitializeComponent();

        }
        private void frmThongTinSach_Load(object sender, EventArgs e)
        {
            sach = new clsSach();
            if (isAdd)
                clearText();
            else
                addText();
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
       
        private void txtTenSach_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name.ToString())
            {
                case "txtTenSach":
                    if (txtTenSach.Text == "")
                    {
                        txtTenSach.Text = "Nhập tên sách";
                        txtTenSach.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        txtTenSach.Text = clsChucNang.PerfectString1(txtTenSach.Text.ToString());
                    }                   
                    break;

                case "txtNxb":
                    if (txtNxb.Text == "")
                    {
                        txtNxb.Text = "Nhập tên nhà xuất bản";
                        txtNxb.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        txtNxb.Text = clsChucNang.PerfectString1(txtNxb.Text.ToString());
                    }
                    break;
                
                case "txtNam":
                    if (txtNam.Text == "")
                    {
                        txtNam.Text = "Nhập năm xuất bản";
                        txtNam.ForeColor = Color.DarkGray;
                    }  
                    else
                    {
                        if (txtNam.Text != "Nhập năm xuất bản")
                        {
                            if (txtNam.Text.namcheck() == false)
                            {
                                errorProvider1.SetError(txtNam, "Năm xuất bản phải từ năm 1800 đến năm hiện tại và không được chứa kí tự khác số tự nhiên");
                            }
                            else
                            {
                                int tmp = Convert.ToInt32(txtNam.Text);
                                if (tmp > DateTime.Now.Year)
                                    errorProvider1.SetError(txtNam, "Năm xuất bản thuộc từ năm 1800 đến năm hiện tại và không được chứa kí tự khác số tự nhiên");
                                else
                                    errorProvider1.SetError(txtNam, null);
                            }
                        }
                    }
                    break;
                case "txtTg":
                    if (txtTg.Text == "")
                    {
                        txtTg.Text = "Nhập tên tác giả ";
                        txtTg.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        if (txtTg.Text != "Nhập tên tác giả ")
                        {
                            if (txtTg.Text.nameCheck() == false)
                            {
                                errorProvider1.SetError(txtTg, "Tên tác giả không được chứa kí tự là số tự nhiên");
                            }
                            else
                            {
                                errorProvider1.SetError(txtTg, null);
                                txtTg.Text = clsChucNang.PerfectString(txtTg.Text.ToString());
                            }
                        }
  
                            
                    }
                    break;
                case "txtSL":
                    if (txtSL.Text == "")
                    {
                        txtSL.Text = "Nhập số lượng";
                        txtSL.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        if (txtSL.Text != "Nhập số lượng")
                        {
                            
                            if (txtSL.Text.slCheck() == false)
                            {
                                errorProvider1.SetError(txtSL, "Số lượng sách phải lớn hơn 0 và bé hơn 1.000.000.000 và không được chứa kí tự khác số tự nhiên");
                            }
                            else
                            {
                                int tmp = Convert.ToInt32(txtSL.Text);
                                if (tmp > 100000000)
                                    errorProvider1.SetError(txtSL, "Số lượng sách phải lớn hơn 0 và bé hơn 1.000.000.000 và không được chứa kí tự khác số tự nhiên");
                                else
                                    errorProvider1.SetError(txtSL, null);
                            }
                        }
                    }
                    break;
                case "txtMa":
                    if (txtMa.Text == "")
                    {
                        txtMa.Text = "Mã sách";
                        txtMa.ForeColor = Color.DarkGray;
                    }                 
                    break;
                case "txtGia":
                    if (txtGia.Text == "")
                    {
                        txtGia.Text = "Nhập giá tiền";
                        txtGia.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        if (txtGia.Text != "Nhập số lượng")
                        {

                            if (txtGia.Text.tienChek() == false)
                            {
                                errorProvider1.SetError(txtGia, "Số tiền phải lớn hơn 10 và bé hơn 1.000.000.000 và không được chứa kí tự khác số tự nhiên");
                            }
                            else
                            {
                                int tmp = Convert.ToInt32(txtGia.Text);
                                if (tmp > 100000000)
                                    errorProvider1.SetError(txtGia, "Số tiền phải lớn hơn 10 và bé hơn 1.000.000.000 và không được chứa kí tự khác số tự nhiên");
                                else
                                    errorProvider1.SetError(txtGia, null);
                            }
                        }
                    }
                    break;
                case "txtGg":
                    if (txtGg.Text == "")
                    {
                        txtGg.Text = "Giảm giá bao nhiêu phần trăm";
                        txtGg.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        if (txtGg.Text != "Giảm giá bao nhiêu phần trăm")
                        {

                            if (txtGg.Text.slCheck() == false)
                            {
                                errorProvider1.SetError(txtGg, "Giảm giá phải bé hơn 100 và không được chứa kí tự khác số tự nhiên");
                            }
                            else
                            {
                                int tmp = Convert.ToInt32(txtGg.Text);
                                if (tmp > 100)
                                    errorProvider1.SetError(txtGg, "Giảm giá phải và bé hơn 100 và không được chứa kí tự khác số tự nhiên");
                                else
                                    errorProvider1.SetError(txtGg, null);
                            }
                        }
                    }
                    break;
            }
            
        }
        private void txtTenSach_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name.ToString())
            {
                case "txtTenSach":
                    errorProvider1.SetError(txtTenSach, null);
                    if (txtTenSach.Text == "Nhập tên sách")
                    {
                        txtTenSach.Text = "";
                        txtTenSach.ForeColor = Color.Black;
                    }
                    else
                    {
                        txtTenSach.Text = clsChucNang.PerfectString1(txtTenSach.Text.ToString());
                    }
                    break;

                case "txtNxb":
                    errorProvider1.SetError(txtNxb, null);
                    if (txtNxb.Text == "Nhập tên nhà xuất bản")
                    {
                        txtNxb.Text = "";
                        txtNxb.ForeColor = Color.Black;
                    }
                    else
                    {
                        txtNxb.Text = clsChucNang.PerfectString1(txtNxb.Text.ToString());
                    }
                    break;
               
                case "txtNam":
                    errorProvider1.SetError(txtNam, null);
                    if (txtNam.Text == "Nhập năm xuất bản")
                    {
                        txtNam.Text = "";
                        txtNam.ForeColor = Color.Black;
                    }
                    break;
                case "txtTg":
                    errorProvider1.SetError(txtTg, null);
                    if (txtTg.Text == "Nhập tên tác giả ")
                    {
                        txtTg.Text = "";
                        txtTg.ForeColor = Color.Black;
                    }
                    else
                    {
                        txtNxb.Text = clsChucNang.PerfectString1(txtNxb.Text.ToString());
                    }
                    break;
                case "txtSL":
                    errorProvider1.SetError(txtSL, null);
                    if (txtSL.Text == "Nhập số lượng")
                    {
                        txtSL.Text = "";
                        txtSL.ForeColor = Color.Black;
                    }
                    break;
                case "txtMa":
                    errorProvider1.SetError(txtMa, null);
                    if (txtMa.Text == "Mã sách")
                    {
                        txtMa.Text = "";
                        txtMa.ForeColor = Color.Black;
                    }
                    break;
                case "txtGia":
                    errorProvider1.SetError(txtGia, null);
                    if (txtGia.Text == "Nhập giá tiền")
                    {
                        txtGia.Text = "";
                        txtGia.ForeColor = Color.Black;
                    }
                    break;
                case "txtGg":
                    errorProvider1.SetError(txtGg, null);
                    if (txtGg.Text == "Giảm giá bao nhiêu phần trăm")
                    {
                        txtGg.Text = "";
                        txtGg.ForeColor = Color.Black;
                    }
                    break;
            }
                   
        }
        private void clearText()
        {
            txtTenSach.Text = "Nhập tên sách";
            txtTenSach.ForeColor = Color.DarkGray;

            txtNxb.Text = "Nhập tên nhà xuất bản";
            txtNxb.ForeColor = Color.DarkGray;

           

            txtNam.Text = "Nhập năm xuất bản";
            txtNam.ForeColor = Color.DarkGray;

            txtTg.Text = "Nhập tên tác giả ";
            txtTg.ForeColor = Color.DarkGray;

            txtSL.Text = "Nhập số lượng";
            txtSL.ForeColor = Color.DarkGray;

            txtMa.Text = "Mã sách";
            txtMa.ForeColor = Color.DarkGray;
            
           txtGia.Text = "Nhập giá tiền";
            txtGia.ForeColor = Color.DarkGray;

            txtGg.Text = "Giảm giá bao nhiêu phần trăm";
            txtGg.ForeColor = Color.DarkGray;
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

        private bool Checknhap()
        {          

            if (txtTenSach.Text.ToString() == "" || txtTenSach.Text == "Nhập tên sách")
            {
                errorProvider1.SetError(txtTenSach, "Bạn phải nhập tên sách!");
                return false;
            }

            if (txtTg.Text.ToString() == "" || txtTg.Text == "Nhập tên tác giả ")
            {
                errorProvider1.SetError(txtTg, "Bạn phải nhập tên tác gỉả!");
                return false;

            }

            if (txtGia.Text.ToString() == "" || txtGia.Text == "Nhập giá tiền")
            {
                errorProvider1.SetError(txtGia, "Bạn phải nhập giá sách!");
                return false;

            }

            if (txtNam.Text.ToString() == "" || txtNam.Text == "Nhập tên sách")
            {
                errorProvider1.SetError(txtNam, "Bạn phải nhập năm xuất bản!");
                return false;

            }

            if (txtSL.Text.ToString() == "" || txtSL.Text == "Nhập số lượng")
            {
                errorProvider1.SetError(txtSL, "Bạn phải số lượng sách!");
                return false;

            }

            if (txtNxb.Text.ToString() == "" || txtNxb.Text == "Nhập tên nhà xuất bản")
            {
                errorProvider1.SetError(txtNxb, "Bạn phải nhập tên sách!");
                return false;
            }
            return true;
        }



        
        private void addText()
        {
            txtSL.Text = s.SoLuong.ToString();
            txtTenSach.Text = s.TenSach;
            string tmp = s.TheLoai.RTrim();
            cboLoai.SelectedItem = tmp;
            txtGg.Text = s.GiamGia.ToString();
            txtGia.Text = s.GiaTien.ToString();
            txtNam.Text = s.NamXuatBan.ToString();
            txtMa.Text = s.MaSach;
            txtTg.Text = s.TacGia;
            txtNxb.Text = s.NhaXuatBan;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLoai_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (Checknhap())
            {
                tblSach tmp = new tblSach();
                tmp.TenSach = txtTenSach.Text.ToString();
                tmp.TheLoai = cboLoai.SelectedItem.ToString();
                tmp.SoLuong = Convert.ToInt32(txtSL.Text.ToString());
                tmp.TacGia = txtTg.Text.ToString();
                tmp.GiaTien = Convert.ToInt32(txtGia.Text.ToString());
                tmp.NamXuatBan = Convert.ToInt32(txtNam.Text.ToString());
                tmp.NhaXuatBan = txtNxb.Text.ToString();
                tmp.TrangThai = true;
                if (txtGg.Text.ToString().Equals(""))
                    tmp.GiamGia = 0;
                else
                    tmp.GiamGia = Convert.ToInt32(txtNam.Text.ToString());
                
                
                
                if (isAdd)
                {
                    txtMa.Text = tmp.MaSach;
                    if (!sach.checkSachTonTai(s.TenSach))
                    {
                        int soLuongSach = sach.getSoLuong();
                        tmp.MaSach = sach.getMaSach(s.TenSach, soLuongSach);
                        DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Ban có muốn thêm sách " + s.TenSach + " vào cửa hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 100);
                        if (test == DialogResult.Yes)
                        {                           
                            if (sach.addSach(s))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Thêm thành công!", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearText();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Thêm thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        tblSach tmp1 = sach.getSachTuTen(s.TenSach);
                        if ((bool)tmp1.TrangThai)
                        {

                            DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Sách '" + tmp1.TenSach + "' đã có rồi bạn có muốn dừng thêm và sửa lại thông tin sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100);
                            int lvwCout = 0;
                            if (test == DialogResult.Yes)
                            {
                                s = tmp1;
                                addText();
                            }
                            else
                                txtTenSach.Focus();
                        }
                        else
                        {
                            DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Sách đã ngừng kinh doanh bạn có muốn thêm lại vào cửa hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error, 100);
                            if (test == DialogResult.Yes)
                            {
                                tmp1.TrangThai = true;
                                if (sach.suaSach(tmp1))
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "Đã thêm lại sách vào cửa hàng thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                                    clearText();
                                    txtTenSach.Focus();
                                }
                                else
                                {
                                    txtTenSach.Focus();
                                    MetroFramework.MetroMessageBox.Show(this, "Thêm sách thất bại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                                }
                                    
                            }
                            else
                                txtTenSach.Focus();
                        }

                    }

                }
                else
                {
                    tmp.MaSach = txtMa.Text;
                    DialogResult test = MetroFramework.MetroMessageBox.Show(this, "Ban có muốn sửa thông tin sách '" + tmp.TenSach + "' ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (test == DialogResult.Yes)
                    {
                        if (sach.suaSach(tmp))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    }
                }
            }            
            else
                MetroFramework.MetroMessageBox.Show(this, "Ban phải nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSL.Text = s.SoLuong.ToString();
            txtTenSach.Text = s.TenSach;
            string tmp = s.TheLoai.RTrim();
            cboLoai.SelectedItem = tmp;
            txtGg.Text = s.GiamGia.ToString();
            txtGia.Text = s.GiaTien.ToString();
            txtNam.Text = s.NamXuatBan.ToString();
            txtMa.Text = s.MaSach;
            txtTg.Text = s.TacGia;
            txtNxb.Text = s.NhaXuatBan;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            uCrtl.refreshListView();
        }

        private void txtNam_TextChanged(object sender, EventArgs e)
        {
            
            
        }

     
    }
}
