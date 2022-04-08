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
    public partial class frmQuenMk : MetroFramework.Forms.MetroForm
    {
        clsTaiKhoan tk;
        public frmQuenMk()
        {
            InitializeComponent();
        }

        private void frmQuenMk_Load(object sender, EventArgs e)
        {
            tk = new clsTaiKhoan();
        }
        tblTaiKhoan MKmoi()
        {
            tblTaiKhoan tkmoi = new tblTaiKhoan();
            tkmoi.MaNhanVien = txtMa.Text;
            tkmoi.MatKhau = txtMatKhauMoi.Text;
            return tkmoi;
        }
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            if (txtMa.Text == "")
            {
                errorProvider1.SetError(txtMa, "Bạn phải nhập mã nhân viên!");
                tmp = 1;
            }
            if (txtMatKhauMoi.Text == "")
            {
                errorProvider1.SetError(txtMatKhauMoi, "Bạn chưa nhập mật khẩu mới!");
                tmp = 1;
            }
            if (txtCMND.Text == "")
            {
                errorProvider1.SetError(txtNhapLai, "Bạn phải xác nhận lại mật khẩu mới!");
                tmp = 1;
            }
            if (txtNhapLai.Text != txtMatKhauMoi.Text)
            {
                errorProvider1.SetError(txtNhapLai, "Mật khẩu không trùng khớp!");
                tmp = 1;
            }

            
            
            if (tmp == 0)
            {
                tblTaiKhoan taiKhoan = tk.Tim(txtMa.Text.ToString());
                if(taiKhoan == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Mã nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(tk.checkCmnd(taiKhoan, txtCMND.Text.ToString()))
                {
                    taiKhoan.MatKhau = txtMatKhauMoi.Text.ToString();
                    if (tk.DoiMK(taiKhoan))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Đổi mật khảu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Đổi mật khảu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Sai chứng minh nhân dân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
