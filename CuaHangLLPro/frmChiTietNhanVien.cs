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
    public partial class frmChiTietNhanVien : MetroFramework.Forms.MetroForm
    {
        clsNhanVien Nv;
        string ma;
        clsTaiKhoan taiKhoan;
        public frmChiTietNhanVien()
        {
            InitializeComponent();
        }

        public frmChiTietNhanVien(string maNv)
        {
            InitializeComponent();
            ma = maNv;
        }

        private void frmChiTietNhanVien_Load(object sender, EventArgs e)
        {
            taiKhoan = new clsTaiKhoan();
            Nv = new clsNhanVien();
            tblNhanVien nv = Nv.GetNhanVienTuMa(ma);
            this.Text = nv.TenNhanVien;
            txtCccD.Text = nv.CMND;
            txtCv.Text = nv.ChucVu;
            txtGt.Text = nv.GioiTinh;
            txtDate.Text = Convert.ToString(nv.NgaySinh);
            txtMaHd.Text = nv.MaNhanVien;
            txtSdt.Text = Convert.ToString(nv.SDT);

        }

        private void txtCccD_Click(object sender, EventArgs e)
        {

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            tblTaiKhoan tk = taiKhoan.Tim(ma);
            frmMatKhau frm = new frmMatKhau(tk);
            frm.ShowDialog();
        }
    }
}
