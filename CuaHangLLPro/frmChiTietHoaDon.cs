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
    public partial class frmChiTietHoaDon : MetroSet_UI.Forms.MetroSetForm

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
        int tongTien= 0;
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
            }
            else
            {
                txtTenKh.Text = kh.getTenKhTuMA(hoaDons.MaKhachHang);
            }
            txtNgay.Text = hoaDons.NgayXuatHoaDon.ToString();
            txtTenNv.Text = nhanVien.getTenMvTuMA(hoaDons.MaNhanVien);
            txtGiamGia.Text = hoaDons.GiamGia.ToString();
                      
            foreach (tblChiTietHoaDon hd in ds)
            {
                count = count + hd.SoLuong;
            }
            loadHdToListView(lvwDs, ds);
            // createColumn(lvwDs);
            txtThanhTien.Text = (tongTien - tongTien * hoaDons.GiamGia/100).ToString();
        }
       // 40 30 50
        void createColumn(ListView lvw)
        {
            lvw.Columns.Add("STT", 60);
            lvw.Columns.Add("Tên sách", 330);
            lvw.Columns.Add("SL", 60);        
            lvw.Columns.Add("Giá", 100);
            lvw.Columns.Add("VAT(%)", 80);
            lvw.Columns.Add("Thành tiền", 150);
            lvw.View = View.Details;
          //  lvw.GridLines = true;
         //   lvw.FullRowSelect = true;
        }
        void createColumnMax(ListView lvw)
        {
            lvw.Columns.Add("Mã sách", 200);
            lvw.Columns.Add("Tên sách", 550);
            lvw.Columns.Add("SL", 200);
            lvw.Columns.Add("Đơn Giá", 200);
            lvw.Columns.Add("VAT(%)", 200);
            lvw.Columns.Add("Thành tiền", 200);
            lvw.View = View.Details;
            //  lvw.GridLines = true;
            //   lvw.FullRowSelect = true;
        }
        ListViewItem GenerateItem(tblChiTietHoaDon hd, int stt)
        {

            ListViewItem lvwItems;
            tblSach s = sach.getTblSachTuMa(hd.MaSach);
            lvwItems = new ListViewItem(stt.ToString());
            lvwItems.SubItems.Add(s.TenSach);       
            lvwItems.SubItems.Add(Convert.ToString(hd.SoLuong));       
            lvwItems.SubItems.Add(s.GiaTien.ToString());
            lvwItems.SubItems.Add(Thue(s.TheLoai).ToString());
            lvwItems.SubItems.Add(thanhTien(s.GiaTien, Thue(s.TheLoai), hd.SoLuong).ToString());
            tongTien += thanhTien(s.GiaTien, Thue(s.TheLoai), hd.SoLuong);
            lvwItems.Tag = hd;
            return lvwItems;
        }
        ListViewItem GenerateItemEnd(int tong, int soLuong)
        {
           
            ListViewItem lvwItems;          
            lvwItems = new ListViewItem("Tổng cộng:");
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add(soLuong.ToString());
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add("");
            lvwItems.SubItems.Add(tong.ToString());
            return lvwItems;
        }
        private int thanhTien(int tien, int vat, int soLuong)
        {
            return (tien + tien * vat / 100) * soLuong;
        }
        private int Thue(string loaisach)
        {
            switch (loaisach)
            {
                case "Khoa học công nghệ":
                    return 0;
                    break;
                case "Chính trị pháp luật":
                    return 0;
                case "Giáo Trình":
                    return 0;
                    break;
                default:
                    return 10;
                    break;
            }
        }

        void loadHdToListView(ListView lvw, IEnumerable<tblChiTietHoaDon> dshd)
        {
            lvw.Items.Clear();
            ListViewItem item;
            int dem = 0;
            foreach (tblChiTietHoaDon hd in dshd)
            {
                dem++;
                item = GenerateItem(hd, dem);
                lvw.Items.Add(item);

            }
            item = GenerateItemEnd(tongTien, count);
            lvw.Items.Add(item);
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

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
