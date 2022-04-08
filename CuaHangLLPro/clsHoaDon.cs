using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CuaHangLLPro
{
    public class clsHoaDon : clsKetNoi
    {
        CuaHangLLProDataContext dt;
        public clsHoaDon()
        {
            dt = GetDataContext();
        }
        String maNV;
        String maKh;
        String giamGia;
        public bool add(tblHoaDon hd)
        {
            System.Data.Common.DbTransaction myTrans = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTrans;
                dt.tblHoaDons.InsertOnSubmit(hd);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch(Exception e)
            {
                dt.Transaction.Rollback();
                //throw new Exception("Lỗi " + e);
                return false;
            }
        }
        public bool addHdChiTiet(tblChiTietHoaDon hd)
        {
            System.Data.Common.DbTransaction myTrans = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTrans;
                dt.tblChiTietHoaDons.InsertOnSubmit(hd);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                //  throw new Exception("Lỗi " + e);
                return false;
            }
        }
        public clsHoaDon(string maHd)
        {
            tblHoaDon hd = dt.tblHoaDons.Where(ma => ma.MaHoaDon.Equals(maHd)).FirstOrDefault();
            maNV = hd.MaNhanVien;
            maKh = hd.MaKhachHang;
            giamGia = Convert.ToString(hd.GiamGia);
        }

        public string GetMaNv()
        {
            return maNV;
        }

        public string GetMakh()
        {
            return maKh;
        }

        public string GetGiamGia()
        {
            return giamGia;
        }

       
        //      
        // lay danh sanh hd
        //
        public IEnumerable<tblHoaDon> GetAllHoaDons()
        {
            IEnumerable<tblHoaDon> q = from hd in dt.tblHoaDons
                                       select hd;
            return q;
        }

        public IEnumerable<tblHoaDon> GetHoaDonsGG()
        {
            IEnumerable<tblHoaDon> q = from hd in dt.tblHoaDons
                                       where hd.GiamGia != null
                                       orderby hd.GiamGia  descending
                                       select hd;
            return q;
        }
        public IEnumerable<tblHoaDon> GetHoaDonTheoMa(string ma)
        {
            IEnumerable<tblHoaDon> q = from hd in dt.tblHoaDons
                                              where hd.MaHoaDon.Contains(ma)
                                              select hd;
            return q;
        }
        public IEnumerable<tblHoaDon> GetHoaDonTheoMaKH(string ma)
        {
            IEnumerable<tblHoaDon> q = from hd in dt.tblHoaDons
                                              where hd.MaKhachHang.Contains(ma)
                                              select hd;
            return q;
        }
        public IEnumerable<tblChiTietHoaDon> GetHoaDonCtTheoMa(string ma)
        {
            IEnumerable<tblChiTietHoaDon> q = from hd in dt.tblChiTietHoaDons
                                       where hd.MaHoaDon.Contains(ma)
                                       select hd;
            return q;
        }
        public IEnumerable<tblHoaDon> GetHoaDonTheoMaNV(string ma)
        {
            IEnumerable<tblHoaDon> q = from hd in dt.tblHoaDons
                                       where hd.MaNhanVien.Contains(ma)
                                       select hd;
            return q;
        }
        public IEnumerable<tblChiTietHoaDon> GetAllHoaDonCt(string ma)
        {
            IEnumerable<tblChiTietHoaDon> q = from hd in dt.tblChiTietHoaDons
                                               where hd.MaHoaDon.Equals(ma)
                                                select hd;
            return q;
        }

        public IEnumerable<tblChiTietHoaDon> GetHoaDonCtTheoDs(IEnumerable<tblHoaDon> hoaDon)
        {
            IEnumerable<tblChiTietHoaDon> q = from hd in hoaDon
                                              join hdct in dt.tblChiTietHoaDons on hd.MaHoaDon equals hdct.MaHoaDon
                                              select hdct;
           

            return q;
        }

        public IEnumerable<tblChiTietHoaDon> GetDsSach(IEnumerable<tblHoaDon> hoaDon)
        {
            IEnumerable<tblChiTietHoaDon> q = from hd in hoaDon
                                              join hdct in dt.tblChiTietHoaDons on hd.MaHoaDon equals hdct.MaHoaDon
                                              select hdct;
          

            return q;
        }

       

        public tblHoaDon GettblHoaDonTheoMa(string maHd)
        {
            tblHoaDon q = dt.tblHoaDons.Where(hd => hd.MaHoaDon.Equals(maHd)).FirstOrDefault();

            return q;
        }

        public IEnumerable<tblHoaDon> GetHoaDonTheoNgay(DateTime dateStart , DateTime dateEnd)
        {
            IEnumerable<tblHoaDon> q = from hd in dt.tblHoaDons
                                              where hd.NgayXuatHoaDon > dateStart && hd.NgayXuatHoaDon < dateEnd
                                       select hd;

            return q;
        }
    }
}
