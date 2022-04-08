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
    public partial class ucrtNv : UserControl
    {
        string ma;
        clsNhanVien Nv;
        Form frm;
        public ucrtNv()
        {
            InitializeComponent();
        }

        public ucrtNv(string strMa, Form frmT)
        {
            Nv = new clsNhanVien();
            ma = strMa;
            frm = frmT;
            InitializeComponent();
        }

        private void ucrtNv_Load(object sender, EventArgs e)
        {
            lblTen.Text = Nv.getTenMvTuMA(ma);
        }

        private void lblTen_Click(object sender, EventArgs e)
        {
            frmChiTietNhanVien frm = new frmChiTietNhanVien(ma);
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmChiTietNhanVien frm = new frmChiTietNhanVien(ma);
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
