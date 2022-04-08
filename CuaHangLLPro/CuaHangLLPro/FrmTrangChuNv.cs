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
    public partial class FrmTrangChuNv : Form
    {
        string TaiKhoan;

        static FrmTrangChuNv obj;
        public FrmTrangChuNv()
        {
            InitializeComponent();
        }
        public FrmTrangChuNv(string tk)
        {
            TaiKhoan = tk;
            InitializeComponent();

        }
        public static FrmTrangChuNv Instance
        {
            get
            {
                if (obj == null)
                    obj = new FrmTrangChuNv();
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
        private void button1_Click(object sender, EventArgs e)
        {
            ucTrangChu uc = new ucTrangChu();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnHd_Click(object sender, EventArgs e)
        {
            ucQuanLyHd uc = new ucQuanLyHd( TaiKhoan, panel3);
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            uCtrKh uc = new uCtrKh();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            uCrtThongKe uc = new uCrtThongKe();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            uCrtSach uc = new uCrtSach();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }

        private void FrmTrangChuNv_Load(object sender, EventArgs e)
        {
            ucrtNv ucQl = new ucrtNv(TaiKhoan, this);
            ucQl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(ucQl);
        }
    }
}
