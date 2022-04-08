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
    public partial class frmMatKhau : MetroSet_UI.Forms.MetroSetForm
    {
        clsTaiKhoan tk;
        tblTaiKhoan tkHienTai;
        public frmMatKhau()
        {
            InitializeComponent();
        }
        public frmMatKhau(tblTaiKhoan taikhoan)
        {
           
           tkHienTai = taikhoan; 
            InitializeComponent();
        }       
        private void frmMatKhau_Load(object sender, EventArgs e)
        {
            tk = new clsTaiKhoan();
        }
        tblTaiKhoan MKmoi()
        {
            tblTaiKhoan tkmoi = new tblTaiKhoan();
            tkmoi.MaNhanVien = tkHienTai.MaNhanVien;
            tkmoi.MatKhau = txtMatKhauMoi.Text;
            return tkmoi;
        }
        private void btnDoiMk_Click(object sender, EventArgs e)
        {           
            int tmp = 0;
            if(txtMatKhauHt.Text == "")
            {
                errorProvider1.SetError(txtMatKhauHt, "Bạn phải nhập mật khẩu hiện tại!");
                tmp = 1;
            }
            if(txtMatKhauMoi.Text =="")
            {
                errorProvider1.SetError(txtMatKhauMoi, "Bạn chưa nhập mật khẩu mới!");
                tmp = 1;
            }
            if (txtNhapLai.Text == "")
            {
                errorProvider1.SetError(txtNhapLai, "Bạn phải xác nhận lại mật khẩu mới!");
                tmp = 1;
            }
            if (txtNhapLai.Text != txtMatKhauMoi.Text)
            {
                errorProvider1.SetError(txtNhapLai, "Mật khẩu không trùng khớp!");
                tmp = 1;
            }
            if (txtMatKhauHt.Text == txtMatKhauMoi.Text)
            {
                errorProvider1.SetError(txtMatKhauMoi, "Mật khẩu mới không được trùng với mật khẩu hiện tại!");
                tmp = 1;
            }
            if(tmp == 0)
            {
                tblTaiKhoan tkmoi=MKmoi();
                tk.DoiMK(tkmoi);
            }
            
        }

        private void txtMatKhauHt_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "txtMatKhauHt":
                    errorProvider1.SetError(txtMatKhauHt, null);
                    break;
                case "txtMatKhauMoi":
                    errorProvider1.SetError(txtMatKhauMoi, null);
                    break;
                case "txtNhapLai":
                    errorProvider1.SetError(txtNhapLai, null);
                    break;
            }

        }
    }
}
