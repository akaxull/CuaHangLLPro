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
    public partial class frmDangNhap : MetroSet_UI.Forms.MetroSetForm
    {
        clsNhanVien Nv;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Nv = new clsNhanVien();
            txtMk.UseSystemPasswordChar = true;
        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            if(kiemTraNhap())
            {
                
                if (kiemTraTk(txtMa.Text.ToString()) != null)
                {
                    string mk = kiemTraTk(txtMa.Text.ToString()).MatKhau.Trim();
                    if(txtMk.Text.Equals(mk))
                    {
                        this.Hide();
                        TrangChu frm = new TrangChu(txtMa.Text.ToString());
                        frm.ShowDialog();

                    }
                    else
                    {
                        errorProvider1.SetError(txtMk, "Sai mật khẩu!");
                        txtMk.Focus();
                    }
                }
                else
                {
                    errorProvider1.SetError(txtMa, "Mã nhân viên không tồn tại!");
                    txtMa.Focus();
                }
            }
            
        }


        public bool kiemTraNhap()
        {
            if (txtMa.Text.Equals(""))
            {
                errorProvider1.SetError(txtMa, "Bạn chưa nhập mã nhân viên!");
                txtMa.Focus();
                return false;
            }
            else if (txtMk.Text.Equals(""))
            {
                errorProvider1.SetError(txtMk, "Bạn chưa nhập mật khẩu!");
                txtMk.Focus();
                return false;
            }
            return true;
        }

        public tblTaiKhoan kiemTraTk(string maNv)
        {
           
            IEnumerable<tblTaiKhoan> dsTk = Nv.getAllTaiKhoan();
            foreach(tblTaiKhoan tk in dsTk)
            {
                if(tk.MaNhanVien.Contains(maNv))
                {
                    return tk;
                  //  break;
                }
            }
            return null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMk.Checked == true)
                txtMk.UseSystemPasswordChar = false;
            else
                txtMk.UseSystemPasswordChar = true;
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {
            if (txtMa.Text.Equals(""))
                errorProvider1.SetError(txtMa, "Bạn chưa nhập mã nhân viên!");
            else
                errorProvider1.SetError(txtMa, null);
        }

        private void txtMk_TextChanged(object sender, EventArgs e)
        {
            if (txtMk.Text.Equals(""))
                errorProvider1.SetError(txtMk, "Bạn chưa nhập mật khẩu!");
            else
                errorProvider1.SetError(txtMk, null);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmQuenMk frm = new frmQuenMk();
            frm.ShowDialog();

        }
    }
}
