using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.DotNet.ProjectModel.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CuaHangLLPro
{
    public partial class frmChiTietHoaDon : MetroFramework.Forms.MetroForm

    {
        tblHoaDon hoaDons;
        clsKh kh;
        clsNhanVien nhanVien;
        clsKetNoi dt;
        clsHoaDon hoaDon;
        clsKh khachHang;
        clsSach sach;
        IEnumerable<tblChiTietHoaDon> ds;
        int count = 0;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        public frmChiTietHoaDon(tblHoaDon hd)
        { 
            kh = new clsKh();
            nhanVien = new clsNhanVien();
            dt = new clsKetNoi();           
            InitializeComponent();
            hoaDons = hd;
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            nhanVien = new clsNhanVien();
            kh = new clsKh();
            hoaDon = new clsHoaDon();
            sach = new clsSach();
            
            ds = hoaDon.GetHoaDonCtTheoMa(hoaDons.MaHoaDon);
            txtMaHd.Text = hoaDons.MaHoaDon;

            if (hoaDons.MaKhachHang == null)
            {
                txtTenKh.Text = "";
                txtMaKh.Text = "";
            }
            else
            {
                txtTenKh.Text = kh.getTenKhTuMA(hoaDons.MaKhachHang);
                txtMaKh.Text = hoaDons.MaKhachHang;
            }
            txtNgay.Text = hoaDons.NgayXuatHoaDon.ToString();
            txtMaNv.Text = hoaDons.MaNhanVien;
            txtTenNv.Text = nhanVien.getTenMvTuMA(hoaDons.MaNhanVien);
            txtGiamGia.Text = hoaDons.GiamGia.ToString();
            txtThanhTien.Text = hoaDons.TongTien.ToString();
            
            foreach (tblChiTietHoaDon hd in ds)
            {
                count = count + hd.SoLuong;
            }
            txtSoLuon.Text = Convert.ToString(count);
            // createColumn(lvwDs);
            
            loadHdToListView(lvwDs, ds);
        }
        void createColumn(ListView lvw)
        {
            lvw.Columns.Add("Mã sách", 100);
            lvw.Columns.Add("Tên sách", 300);
            lvw.Columns.Add("Số lượng", 100);        
            lvw.Columns.Add("Giá", 100);        
            lvw.View = View.Details;
          //  lvw.GridLines = true;
         //   lvw.FullRowSelect = true;
        }

        void createColumnMax(ListView lvw)
        {
            lvw.Columns.Add("Mã sách", 300);
            lvw.Columns.Add("Tên sách", 750);
            lvw.Columns.Add("Số lượng", 300);
            lvw.Columns.Add("Giá", 200);
            lvw.View = View.Details;
            //  lvw.GridLines = true;
            //   lvw.FullRowSelect = true;
        }
        ListViewItem GenerateItem(tblChiTietHoaDon hd)
        {

            ListViewItem lvwItems;
            tblSach s = sach.getTblSachTuMa(hd.MaSach);
            int gia = s.GiaTien * hd.SoLuong;
            lvwItems = new ListViewItem(hd.MaSach);
            lvwItems.SubItems.Add(sach.getTenSachTuMa(hd.MaSach));
            lvwItems.SubItems.Add(Convert.ToString(hd.SoLuong));
            
            lvwItems.SubItems.Add(Convert.ToString(gia));
            lvwItems.Tag = hd;
            return lvwItems;
        }

        void loadHdToListView(ListView lvw, IEnumerable<tblChiTietHoaDon> dshd)
        {
            lvw.Items.Clear();
            ListViewItem item;

            foreach (tblChiTietHoaDon hd in dshd)
            {
                item = GenerateItem(hd);
                lvw.Items.Add(item);

            }
        }

        private void frmChiTietHoaDon_ClientSizeChanged(object sender, EventArgs e)
        {
            int sz = frmChiTietHoaDon.ActiveForm.Size.Width;
            if (sz > 1550)
            {
                lvwDs.Columns.Clear();
                createColumnMax(lvwDs);
            }
            else
            {
                lvwDs.Columns.Clear();
                createColumn(lvwDs);
            }
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }
        public static readonly String RUPEE = "The Rupee character đơ and the Rupee symbol ư";
        private void btnIn_Click(object sender, EventArgs e)
        {
            var exportFoder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var exportFile = System.IO.Path.Combine(exportFoder, hoaDons.MaHoaDon + ".pdf");

            using (var writer = new PdfWriter(exportFile))
            {
                using( var pdf = new PdfDocument(writer))
                {
                   
                    string working = Environment.CurrentDirectory;
                    string projectDirectoty = Directory.GetParent(working).Parent.FullName;
                    PdfFont font = PdfFontFactory.CreateFont(projectDirectoty + "/vuArialBold.ttf");
                    var doc = new Document(pdf);
                    Paragraph header = new Paragraph("Hóa đơn: " + hoaDons.MaHoaDon)
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(20);   

                    //Tao dong
                    doc.Add(header);
                    Paragraph item = new Paragraph("Ngày lập hóa đơn: " + hoaDon.GettblHoaDonTheoMa(hoaDons.MaHoaDon).NgayXuatHoaDon)
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    doc.Add(item);
                    if (hoaDons.MaKhachHang != null)
                    {
                        item = new Paragraph("Mã khách hàng: " + hoaDons.MaKhachHang)
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    doc.Add(item);
                    
                        item = new Paragraph("Tên khách hàng: " + kh.getTenKhTuMA(hoaDons.MaKhachHang))
                            .SetFont(font)
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(15);
                        doc.Add(item);
                    }
                    item = new Paragraph("Mã nhân viên lập hóa đơn: " + hoaDons.MaNhanVien)
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    doc.Add(item);
                    item = new Paragraph("Tên nhân viên lập hóa đơn: " + nhanVien.getTenMvTuMA(hoaDons.MaNhanVien))
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    doc.Add(item);
                    item = new Paragraph("Sản phẩm: ")
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    doc.Add(item);
                    // tao bang san pham
                    Table table = new Table(5, false);
                    Cell cell11 = new Cell(1, 1)
                        .SetFont(font)
                  .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph("STT"));
                    Cell cell12 = new Cell(1, 1)
                        .SetFont(font)
                       .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph("Mã sách"));
                    Cell cell13 = new Cell(1, 1)
                       .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
                       .SetFont(font)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph("Tên sách"));
                    Cell cell14 = new Cell(1, 1)
                       .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
                       .SetFont(font)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph("Số lượng"));
                    Cell cell15 = new Cell(1, 1)
                       .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.BLUE)
                       .SetFont(font)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph("Giá tiền"));
                    int i = 1;
                    table.AddCell(cell11);
                    table.AddCell(cell12);
                    table.AddCell(cell13);
                    table.AddCell(cell14);
                    table.AddCell(cell15);
                    foreach (tblChiTietHoaDon hd in ds)
                    {
                        tblSach s = sach.getTblSachTuMa(hd.MaSach);
                        int gia = s.GiaTien * hd.SoLuong;
                        
                        Cell cell21 = new Cell(1, 1)
                            .SetFont(font)
                         .SetTextAlignment(TextAlignment.CENTER)
                         .Add(new Paragraph(1.ToString()));
                        Cell cell22 = new Cell(1, 1)
                            .SetFont(font)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(hd.MaSach));
                        Cell cell23 = new Cell(1, 1)
                            .SetFont(font)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(s.TenSach));
                        Cell cell24 = new Cell(1, 1)
                            .SetFont(font)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(hd.SoLuong.ToString()));
                        Cell cell25 = new Cell(1, 1)
                            .SetFont(font)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(gia.ToString()));
                        table.AddCell(cell21);
                        table.AddCell(cell22);
                        table.AddCell(cell23);
                        table.AddCell(cell24);
                        table.AddCell(cell25);
                        i++;
                    }
                    doc.Add(table);
                    item = new Paragraph("Tổng cộng: " + count.ToString())
                        .SetFontColor(iText.Kernel.Colors.ColorConstants.RED)
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    doc.Add(item);
                    if (hoaDons.GiamGia != null)
                    {
                        item = new Paragraph("Giảm giá: " + hoaDons.GiamGia.ToString())
                            .SetFontColor(iText.Kernel.Colors.ColorConstants.RED)
                            .SetFont(font)
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetFontSize(15);
                        doc.Add(item);
                    }
                    
                    item = new Paragraph("Tổng tiền: " + hoaDons.TongTien.ToString())
                        .SetFontColor(iText.Kernel.Colors.ColorConstants.RED)
                        .SetFont(font)
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(15);
                    doc.Add(item);
                    if (doc != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Hoá đã được lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
            

        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            string[] str2 = new string[30];
            // tạo một tin nhắn và thêm những thông tin cần thiết như: ai gửi, người nhận, tên tiêu đề, và có đôi lời gì cần nhắn nhủ
            MailMessage mail = new MailMessage("nguyenkhanhxm13@gmail.com", txtMail.Text, "Hóa đơn điện tử", "Cảm ơn quý khách đã tin tưởng của hàng"); //
            mail.IsBodyHtml = true;
            //gửi tin nhắn
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);          
            
                               // thêm vào credential vì SMTP server cần nó để biết được email + password của email đó mà bạn đang dùng
            client.Credentials = new System.Net.NetworkCredential("tranvukhai720@gmail.com", "q0989619562");
            client.EnableSsl = true; //vì ta cần thiết lập kết nối SSL với SMTP server nên cần gán nó bằng true
            
            

            string fileName = ""; //khởi tạo ban đầu
                                  //open tệp tin với component OpenFileDialog
            using (OpenFileDialog myDialog = new OpenFileDialog())
            {
                myDialog.Multiselect = true;
                myDialog.InitialDirectory = "";
                myDialog.Filter ="Pdf Files | *.pdf";
                myDialog.FilterIndex = 2;
                myDialog.RestoreDirectory = true;

                if (myDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in myDialog.FileNames)
                    //cứ sau mỗi lần lặp ta lại có được một file, điều này cho phép bạn chọn nhiều file thay vì chỉ một cái
                    {
                        //Lấy đường dẫn của file cụ thể
                        //lấy tên của file cụ thể
                        fileName = Path.GetFileName(file);
                    }

                }
                 str2 = myDialog.FileNames;

                foreach (string names in str2)
                {
                    if (names != null)
                    {
                        mail.Attachments.Add(new Attachment(names));
                        MessageBox.Show("Have upload " + names + " succesfully!", "Upload File");
                    }

                }
                client.Send(mail);
                MessageBox.Show("Đã gửi tin nhắn thành công!", "Thành Công", MessageBoxButtons.OK);
            }
        }
    }
}
