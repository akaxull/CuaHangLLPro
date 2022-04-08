using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLLPro
{
    class clsKh : clsKetNoi 
    {
        CuaHangLLProDataContext dt;
        public clsKh()
        {
            dt = GetDataContext();
        }
        /*  public IEnumerable<tblKhachHang> getTenKhTuMA(string maKh)
          {
              IEnumerable<tblKhachHang> q;

              q = from kh in dt.tblKhachHangs
                  where kh.MaKhachHang.Equals(maKh)
                     select kh;

              return q;
          }*/
        public String getTenKhTuMA(string ma)
        {
            tblKhachHang khachHang = dt.tblKhachHangs.Where(mak => mak.MaKhachHang.Equals(ma)).FirstOrDefault();
            return khachHang.TenKhachHang;
        }
        public tblKhachHang getKhTuSDt(string sdt)
        {
            tblKhachHang khachHang = dt.tblKhachHangs.Where(mak => mak.Sdt.Equals(sdt)).FirstOrDefault();
            return khachHang;
        }




        public IEnumerable<tblKhachHang> GetAllKh()
        {
            IEnumerable<tblKhachHang> p = from Kh in dt.tblKhachHangs
                                          select Kh;
            return p;
        }

        
        public tblKhachHang Tim(string strmanv)
        {
            tblKhachHang mttemp = (from n in dt.tblKhachHangs
                                   where n.MaKhachHang.Equals(strmanv)
                                   select n).FirstOrDefault();
            return mttemp;
        }
        public int ThemKH(tblKhachHang kh)
        {
            System.Data.Common.DbTransaction them = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = them;
                if (Tim(kh.MaKhachHang.ToString()) != null)
                    return 0;
                else
                {
                    dt.tblKhachHangs.InsertOnSubmit(kh);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi không sửa được " + ex.Message);
            }
        }
        public bool Suanv(tblKhachHang kh)
        {
            System.Data.Common.DbTransaction sua = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = sua;
                IQueryable<tblKhachHang> tam = (from n in dt.tblKhachHangs
                                                where n.MaKhachHang == kh.MaKhachHang
                                                select n);
                tam.First().TenKhachHang = kh.TenKhachHang;
                tam.First().GioiTinh = kh.GioiTinh;
                tam.First().Sdt = kh.Sdt;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi khong sua duoc" + ex.Message);
            }
        }
        public IEnumerable<tblKhachHang> SXTangTheoTen()
        {
            IEnumerable<tblKhachHang> q;
            q = from n in dt.tblKhachHangs
                orderby n.TenKhachHang
                select n;
            return q;
        }
        public IEnumerable<tblKhachHang> SXGiamTheoten()
        {
            IEnumerable<tblKhachHang> q;
            q = from n in dt.tblKhachHangs
                orderby n.TenKhachHang descending
                select n;
            return q;
        }
        public string CreateKeyKH(string tiento, string Ten)
        {
            String result = "";
            String key = tiento;

            var a = (from n in dt.tblKhachHangs
                     select n.MaKhachHang).Count();

            bool v = true;
            for (int i = 0; i < Ten.Length; i++)
            {

                if (Ten[i] == ' ')
                {
                    v = true;
                }

                else if (Ten[i] != ' ' && v == true)
                {
                    result += (Ten[i]);
                    v = false;
                }
            }
            key = key + result + a.ToString();
            return key;
        }
    }
}

