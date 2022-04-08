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
    public partial class urcQl : UserControl
    {
        string ma;
        clsNhanVien Nv;
        Form frm;
        public urcQl()
        {
            InitializeComponent();
        }
        public urcQl(string strMa, Form form)
        {
            ma = strMa;
            Nv = new clsNhanVien();
            frm = form;
            InitializeComponent();
        }

        private void urcQl_Load(object sender, EventArgs e)
        {
            lblTen.Text = Nv.getTenMvTuMA(ma);
        }

        private void lblTen_Click(object sender, EventArgs e)
        {
            frmChiTietNhanVien frm = new frmChiTietNhanVien(ma);
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frm.Close();
            frmDangNhap.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
