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
        public TrangChu()
        {
            InitializeComponent();
        }

        static TrangChu obj;

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
            obj = this;
             ucTrangChu uc = new ucTrangChu();         
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);    
        }
        private void btnHd_Click(object sender, EventArgs e)
        {        
            
            ucQuanLyHd uc = new ucQuanLyHd();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);   
           // panel3.Controls.Add(uc);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmNhanVien uc = new FrmNhanVien();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmKhachHang uc = new FrmKhachHang();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(uc);
        }
    }
}
