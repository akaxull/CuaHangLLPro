using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLLPro
{
    class clsSach : clsKetNoi
    {
        CuaHangLLProDataContext dt;
        public clsSach()
        {
            dt = GetDataContext();
        }

        public IEnumerable<tblSach> GetAllSach()
        {
            IEnumerable<tblSach> s = from sach in dt.tblSaches.Where(q => q.TrangThai == true)
                                     select sach;
            return s;
        }


        public IEnumerable<tblSach> getSachTheoRad(string rad, IEnumerable<tblSach> dsSach)
        {
            IEnumerable<tblSach> s = from sach in dsSach.Where(q => rad.Contains(q.TheLoai))
                                     select sach;
            return s;
        }
        public IEnumerable<tblSach> getSachTuMa (string maSach)
        {
            IEnumerable<tblSach> s = from sach in dt.tblSaches.Where(q => q.MaSach.Contains(maSach))
                                     select sach;
            return s;
        }
        public IEnumerable<tblSach> getSachTuTenS(string tenSach)
        {
            IEnumerable<tblSach> s = from sach in dt.tblSaches.Where(q => q.TenSach.Contains(tenSach))
                                     select sach;
            return s;
        }
        public IEnumerable<tblSach> getSachTuTenTg(string tenTG)
        {
            IEnumerable<tblSach> s = from sach in dt.tblSaches.Where(q => q.TacGia.Contains(tenTG))
                                     select sach;
            return s;
        }
        public IEnumerable<tblSach> getSachTuNxb(string nxb)
        {
            IEnumerable<tblSach> s = from sach in dt.tblSaches.Where(q => q.NhaXuatBan.Contains(nxb))
                                     select sach;
            return s;
        }

        public string getTenSachTuMa(string maSach)
        {
            tblSach q = dt.tblSaches.Where(s => s.MaSach.Equals(maSach)).FirstOrDefault();
            return q.TenSach;
        }

        public tblSach getSachTuTen(string tenSach)
        {
            tblSach q = dt.tblSaches.Where(s => s.TenSach.Equals(tenSach)).FirstOrDefault();
            return q;
        }

        public tblSach getTblSachTuMa(string maSach)
        {
            tblSach q = dt.tblSaches.Where(s => s.MaSach.Equals(maSach)).FirstOrDefault();
            return q;
        }

        public IEnumerable<tblSach> GetTblSach()
        {
            IEnumerable<tblSach> s = from sach in dt.tblSaches
                                     select sach;
            return s;
        }
        public bool checkSachTonTai(string tenSach)
        {
            tblSach q = dt.tblSaches.Where(s => s.TenSach.Equals(tenSach)).FirstOrDefault();
            if (q == null)
                return false;
            else
                return true;
        }
        public bool checkSachTonTaiMa(string maSach)
        {
            tblSach q = dt.tblSaches.Where(s => s.MaSach.Equals(maSach)).FirstOrDefault();
            if (q == null)
                return false;
            else
                return true;
        }
        public bool addSach(tblSach sach)
        {
            System.Data.Common.DbTransaction myTrans = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTrans;
                dt.tblSaches.InsertOnSubmit(sach);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                return false;
            }
        }
        public bool XoaSach(tblSach sach)
        {
            System.Data.Common.DbTransaction myTrans = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTrans;
                IQueryable<tblSach> sTam = (from s in dt.tblSaches
                                            where s.MaSach == sach.MaSach
                                            select s);

                sTam.First().TrangThai = false;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
                //  dt.Transaction.Rollback();
                return false;
            }
        }
       

        public bool suaSach(tblSach sach)
        {
            System.Data.Common.DbTransaction myTrans = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTrans;
                IQueryable<tblSach> sTam = (from s in dt.tblSaches
                                            where s.MaSach == sach.MaSach                
                                            select s);
                    sTam.First().TenSach = sach.TenSach;
                    sTam.First().TacGia = sach.TacGia;
                    sTam.First().SoLuong = sach.SoLuong;
                    sTam.First().NamXuatBan = sach.NamXuatBan;
                    sTam.First().GiaTien = sach.GiaTien;
                    sTam.First().GiamGia = sach.GiamGia;
                    sTam.First().NhaXuatBan = sach.NhaXuatBan;
                    sTam.First().TheLoai = sach.TheLoai;
                    sTam.First().TrangThai = sach.TrangThai;
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                throw new Exception(e.ToString());                
                return false;
            }
        }

        public bool suaSlSach(tblChiTietHoaDon sach, int sl)
        {
            System.Data.Common.DbTransaction myTrans = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTrans;
                IQueryable<tblSach> sTam = (from s in dt.tblSaches
                                            where s.MaSach == sach.MaSach
                                            select s);
                
                sTam.First().SoLuong = sach.SoLuong - sl;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                throw new Exception(e.ToString());
                return false;
            }
        }
        public int DemSoLuongSach(string ten)
        {
            int s = (from sach in dt.tblSaches.Where(q => q.TenSach.StartsWith(ten))
                                     select sach.SoLuong).FirstOrDefault();
            return s;
        }
    }
}
