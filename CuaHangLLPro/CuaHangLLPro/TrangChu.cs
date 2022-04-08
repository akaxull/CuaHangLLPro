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
    public partial class TrangChu : Form
    {
        string TaiKhoan;

        static TrangChu obj;
        public TrangChu()
        {
            InitializeComponent();
        }

        public TrangChu(string tk)
        {
            TaiKhoan = tk;
            InitializeComponent();

        }

        public static TrangChu Instance
        {
            get
            {
                if (obj == null)
                    obj = new TrangChu();
                return obj;
            }
        }

        public Panel panel
        {
            get { return panel3; }
            set { panel = value; }
        }

        public Button HdButton
        {
            get { return btnHd; }
            set { btnHd = value; }
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
                urcQl ucQl = new urcQl(TaiKhoan, this);
                ucQl.Dock = DockStyle.Fill;
                panel2.Controls.Clear();
                panel2.Controls.Add(ucQl);
            obj = this;
            ucTrangChu uc = new ucTrangChu();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
            this.KeyPreview = true;
        }
        private void btnHd_Click(object sender, EventArgs e)
        {
            ucQuanLyHd uc = new ucQuanLyHd(TaiKhoan, panel3);
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);    
            
        }

        private void tbnSach_Click(object sender, EventArgs e)
        {
            uCrtSach uc = new uCrtSach();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ucCrtQuanLyNv uc = new ucCrtQuanLyNv();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            uCtrKh uc = new uCtrKh();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            uCrtThongKe uc = new uCrtThongKe();
          //  uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcount_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
