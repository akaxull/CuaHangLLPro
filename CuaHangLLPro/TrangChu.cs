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
        string focus = "";
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
            if (TaiKhoan.Contains("NV"))
            {
                btnNhanVien.Hide();
                btnThongKe.Hide();
                panel7.Hide();
                panel8.Hide();
            }
                
            obj = this;
            ucTrangChu uc = new ucTrangChu();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }
        private void btnHd_Click(object sender, EventArgs e)
        {
            Button txt = (Button)sender;
            Color focusColor = Color.FromArgb(243, 219, 223);
            Color normal = Color.FromArgb(185, 187, 203);
            switch (txt.Name.ToString())
            {
                case "btnHd":
                    if(focus != "btnHd")
                    {
                        focus = "btnHd";
                    }
                    btnHd.BackColor = focusColor;
                    ucQuanLyHd uc = new ucQuanLyHd(TaiKhoan, panel3);
                    uc.Dock = DockStyle.Fill;
                    panel3.Controls.Clear();
                    panel3.Controls.Add(uc);
                    break;

                case "tbnSach":
                    if (focus != "tbnSach")
                    {
                        focus = "tbnSach";
                    }
                    tbnSach.BackColor = focusColor;
                    uCrtSach uc1 = new uCrtSach();
                    uc1.Dock = DockStyle.Fill;
                    panel3.Controls.Clear();
                    panel3.Controls.Add(uc1);
                    break;
                case "btnNhanVien":
                    if (focus != "btnNhanVien")
                    {
                        focus = "btnNhanVien";
                    }
                    btnNhanVien.BackColor = focusColor;
                    ucCrtQuanLyNv uc2 = new ucCrtQuanLyNv();
                    uc2.Dock = DockStyle.Fill;
                    panel3.Controls.Clear();
                    panel3.Controls.Add(uc2);
                    break;
                case "btnKhachHang":
                    if (focus != "btnKhachHang")
                    {
                        focus = "btnKhachHang";
                    }
                    btnKhachHang.BackColor = focusColor;
                    uCtrKh uc3 = new uCtrKh();
                    uc3.Dock = DockStyle.Fill;
                    panel3.Controls.Clear();
                    panel3.Controls.Add(uc3);
                    break;
                case "btnThongKe":
                    if (focus != "btnThongKe")
                    {
                        focus = "btnThongKe";
                    }
                    btnThongKe.BackColor = focusColor;
                    uCrtThongKe uc4 = new uCrtThongKe();
                    panel3.Controls.Clear();
                    panel3.Controls.Add(uc4);
                    break;
                case "btnThoat":
                    this.Close();
                    break;

            }
            
            if (focus == "btnHd")
            {
                
                btnKhachHang.BackColor = normal;
                btnNhanVien.BackColor = normal;
                btnThongKe.BackColor = normal;
                tbnSach.BackColor = normal;
            }

            if (focus == "btnKhachHang")
            {
                btnHd.BackColor = normal;             
                btnNhanVien.BackColor = normal;
                btnThongKe.BackColor = normal;
                tbnSach.BackColor = normal;
            }


            if (focus == "btnNhanVien")
            {
                btnHd.BackColor = normal;
                btnKhachHang.BackColor = normal;
               
                btnThongKe.BackColor = normal;
                tbnSach.BackColor = normal;
            }

            if (focus == "btnThongKe")
            {
                btnHd.BackColor = normal;
                btnKhachHang.BackColor = normal;
                btnNhanVien.BackColor = normal;
           
                tbnSach.BackColor = normal;
            }

            if (focus == "tbnSach")
            {
                btnHd.BackColor = normal;
                btnKhachHang.BackColor = normal;
                btnNhanVien.BackColor = normal;
                btnThongKe.BackColor = normal;
               
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
