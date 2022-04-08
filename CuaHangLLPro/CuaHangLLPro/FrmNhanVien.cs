using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CuaHangLLPro
{
    public partial class FrmNhanVien : UserControl
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        clsNhanVien nv;
        clsTaiKhoan tk;
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            TaoTieuDeCot(lvwDanhSachNhanVien);
            nv = new clsNhanVien();
            tk = new clsTaiKhoan();
            IEnumerable<tblNhanVien> dsnv = nv.getAllNhanVien();
            LoadNhanVienToListView(lvwDanhSachNhanVien,dsnv);
            txtTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
            radTimma.Checked = true;
        }
        void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Ma Nhan Vien", 100);
            lvw.Columns.Add("Tên Nhân Viên", 200);                
            lvw.Columns.Add("CMND", 100);
            lvw.Columns.Add("Ngay Sinh ", 100);
            lvw.Columns.Add("Giới Tính", 100);
            lvw.Columns.Add("SDT", 100);        
            lvw.Columns.Add("Chức vụ", 100);
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }
        ListViewItem AddItem(tblNhanVien nv)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(nv.MaNhanVien);
            lvwItem.SubItems.Add(nv.TenNhanVien);              
            lvwItem.SubItems.Add(nv.CMND);
            lvwItem.SubItems.Add(nv.NgaySinh.ToString());
            lvwItem.SubItems.Add(nv.GioiTinh);
            lvwItem.SubItems.Add(nv.SDT);            
            lvwItem.SubItems.Add(nv.ChucVu);
            lvwItem.Tag = nv;
            return lvwItem;
        }
        void LoadNhanVienToListView(ListView lvw, IEnumerable<tblNhanVien> dsnv)
        {

            lvw.Items.Clear();
            ListViewItem itemNhanVien;
            foreach (tblNhanVien nv in dsnv)
            {
                itemNhanVien = AddItem(nv);
                lvw.Items.Add(itemNhanVien);
            }
        }
        void NhanVienToTextBox(tblNhanVien nv)
        {
            txtmanv.Text = nv.MaNhanVien;
            txtTen.Text = nv.TenNhanVien;
            txtSdt.Text = nv.SDT;
            txtCMND.Text = nv.CMND;
            dtpNS.Value = nv.NgaySinh;
            if(nv.GioiTinh.Trim().Length==3)
            {
                radnam.Checked = true;
            }
            else
            {
                radnu.Checked = true;
            }          
            if (nv.ChucVu.Trim().Length==9)
            {
                cboCV.SelectedIndex = 0;
            }
            else
            {
                cboCV.SelectedIndex = 1;
            }
        }

        tblNhanVien TaoNhanVien()
        {
            tblNhanVien nv = new tblNhanVien();
            nv.MaNhanVien = txtmanv.Text;
            nv.TenNhanVien =txtTen.Text;
            nv.CMND = txtCMND.Text;
            nv.NgaySinh = dtpNS.Value;
            if(radnam.Checked==true)
            {
                nv.GioiTinh = radnam.Text;
            }
            else
            {
                nv.GioiTinh = radnu.Text;
            }
            nv.SDT = txtSdt.Text;
            nv.ChucVu = cboCV.Text;
            return nv;
        }
        tblTaiKhoan TaoTaiKhoan(tblNhanVien nv)
        {
            tblTaiKhoan tk = new tblTaiKhoan();
            
            tk.MaNhanVien = nv.MaNhanVien;
            tk.MatKhau ="aa123";
            return tk;
        }
        private void lvwDanhSachNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblNhanVien nv = null;
            if (lvwDanhSachNhanVien.SelectedItems.Count > 0)//co chon
            {
                nv = (tblNhanVien)lvwDanhSachNhanVien.SelectedItems[0].Tag;
                NhanVienToTextBox(nv);
               
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            if (cboCV.SelectedIndex==0)
            {
                txtmanv.Text = nv.CreateKey("NV", txtTen.Text);
            }
            else
            {
                txtmanv.Text = nv.CreateKey("QL", txtTen.Text);
            }
            
            if(!txtTen.Text.Trim().CheckName())
            {
                MessageBox.Show("Họ Và Tên Nhập Không Dấu,Viết ho chữ cái đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if(!dtpNS.Value.CheckDate())
            {
                MessageBox.Show("Ngày Sinh Phải Trước ngày hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNS.Focus();
                return;
            }
            if(!txtCMND.Text.Trim().CheckCMND())
            {
                MessageBox.Show("CMND phải 9 số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtCMND.Focus();
                return;
            }
            if(!txtSdt.Text.Trim().PhoneCheck())
            {
                MessageBox.Show("Phải Bắt đầu bằng số 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return;
            }
          
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlghoixoa;
            tblNhanVien nv1;
            int Vitrithuc;
            if (lvwDanhSachNhanVien.SelectedItems.Count > 0)
            {
                dlghoixoa = MessageBox.Show("Bạn Có chắc chắn xóa?", "Hoi xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dlghoixoa == DialogResult.Yes)
                {
                    for (int i = 0; i < lvwDanhSachNhanVien.SelectedItems.Count; i++)
                    {
                        Vitrithuc = lvwDanhSachNhanVien.SelectedIndices[i];
                        nv1 = (tblNhanVien)lvwDanhSachNhanVien.Items[Vitrithuc].Tag;
                        nv.Xoanv(nv1);
                    }
                    IEnumerable<tblNhanVien> dsnv = nv.getAllNhanVien();
                    LoadNhanVienToListView(lvwDanhSachNhanVien, dsnv);
                    
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {                          
                tblNhanVien nv1 = TaoNhanVien();              
                nv.ThemNV(nv1);
                 tblTaiKhoan tk1 = TaoTaiKhoan(nv1);
                 txtSdt.Text = tk1.MaNhanVien;
                 txtTen.Text = tk1.MatKhau;
                  tk.ThemTK(tk1);
                 IEnumerable<tblNhanVien> dsnv = nv.getAllNhanVien();
                LoadNhanVienToListView(lvwDanhSachNhanVien, dsnv);
           
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!txtTen.Text.Trim().CheckName())
            {
                MessageBox.Show("Họ Và Tên Nhập Không Dấu,Viết ho chữ cái đầu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            if (!dtpNS.Value.CheckDate())
            {
                MessageBox.Show("Ngày Sinh Phải Trước ngày hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNS.Focus();
                return;
            }
            if (!txtCMND.Text.Trim().CheckCMND())
            {
                MessageBox.Show("CMND phải 9 số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND.Focus();
                return;
            }
            if (!txtSdt.Text.Trim().PhoneCheck())
            {
                MessageBox.Show("Phải Bắt đầu bằng số 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return;
            }
                tblNhanVien nv1 = TaoNhanVien();
                nv.Suanv(nv1);
                IEnumerable<tblNhanVien> dsnv = nv.getAllNhanVien();
                LoadNhanVienToListView(lvwDanhSachNhanVien, dsnv);
            
        }
        void XuLyHoTroAutocomlet()
        {
            IEnumerable<tblNhanVien> dsnv;
            dsnv = nv.getAllNhanVien();
            txtTim.AutoCompleteCustomSource.Clear();
            if (radTimma.Checked)
            {
                foreach (tblNhanVien nv1 in dsnv)
                {
                    txtTim.AutoCompleteCustomSource.Add(nv1.MaNhanVien.ToString());
                }
            }
            else
            {
                foreach (tblNhanVien nv1 in dsnv)
                {
                    txtTim.AutoCompleteCustomSource.Add(nv1.TenNhanVien);
                }
            }
        }
        int TimKiem(string strGiaTriTim)
        {
            tblNhanVien nv1;
            for (int i = 0; i < lvwDanhSachNhanVien.Items.Count; i++)
            {
                nv1 = (tblNhanVien)lvwDanhSachNhanVien.Items[i].Tag;
                if (radTimma.Checked)
                {

                    if (nv1.MaNhanVien.ToString().Equals(strGiaTriTim))
                        return i;
                }
                else
                {

                    if (nv1.TenNhanVien.Equals(strGiaTriTim))
                        return i;
                }

            }
            return -1;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            string strthongtintim = txtTim.Text;
            int vitritim = TimKiem(strthongtintim);
            int vitrichontruoc;
            if (vitritim >= 0)
            {
                if (lvwDanhSachNhanVien.SelectedItems.Count > 0)
                {
                    vitrichontruoc = lvwDanhSachNhanVien.SelectedIndices[0];
                    lvwDanhSachNhanVien.Items[vitrichontruoc].Selected = false;
                }
                lvwDanhSachNhanVien.Items[vitritim].Selected = true;
                lvwDanhSachNhanVien.Focus();
            }
            else
            {
                MessageBox.Show("Không có thông tin bạn muốn tìm vui lòng nhập lại","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radTimma_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void radTimten_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

       
    }
}
