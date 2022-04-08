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
    public partial class DangNhap : Form
    {
        private clsTaiKhoan qlAccount = new clsTaiKhoan();
        public tblTaiKhoan account;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account = new tblTaiKhoan()
            {
                MaNhanVien = txtma.Text.ToUpper(),
                MatKhau = txtpass.Text
            };           
            if (qlAccount.CheckAccount(account))
            {
                if (Regex.Match(txtma.Text, @"NV.+").Success)
                {
                    MessageBox.Show("Kết Nối");
                    this.Hide();
                    TrangChu frm = new TrangChu();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                    this.Show();
                }                  
            }
            else
            {
                MessageBox.Show("Username hoặc Password không đúng!", "Thông báo");
                    
            }
        }
    }
}
