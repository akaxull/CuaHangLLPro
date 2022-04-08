using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLLPro
{
    class clsNhanVien  : clsKetNoi
    {
        CuaHangLLProDataContext dt;
        
        public clsNhanVien ()
        {
            dt = GetDataContext();
        }
        //
        // lấy tên nv
        //
        public String getTenMvTuMA(string maNv)
        {
            tblNhanVien nv = dt.tblNhanViens.Where(ma => ma.MaNhanVien.Equals(maNv)).FirstOrDefault();
            return nv.TenNhanVien;
        }

        public tblNhanVien GetNhanVienTuMa(string maNv)
        {
            tblNhanVien nv = dt.tblNhanViens.Where(ma => ma.MaNhanVien.Equals(maNv)).FirstOrDefault();
            return nv;
        }
        public IEnumerable<tblNhanVien> getAllNhanVien()
        {
            IEnumerable<tblNhanVien> q = from nv in dt.tblNhanViens
                                       select nv;
            return q;
        }
        public IEnumerable<tblTaiKhoan> getAllTaiKhoan()
        {
            IEnumerable<tblTaiKhoan> q = from nv in dt.tblTaiKhoans
                                         select nv;
            return q;
        }
        public tblNhanVien Tim(string strmanv)
        {
            tblNhanVien mttemp = (from n in dt.tblNhanViens
                                  where n.MaNhanVien.Equals(strmanv)
                                  select n).FirstOrDefault();
            return mttemp;
        }
        public int Xoanv(tblNhanVien nv)
        {
            System.Data.Common.DbTransaction xoa = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = xoa;
                if (Tim(nv.MaNhanVien.ToString()) != null)
                {
                    dt.tblNhanViens.DeleteOnSubmit(nv);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;

                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không sữa được" + ex.Message);
            }
        }


        public string CreateKey(string tiento, string Ten)
        {
            String result = "";
            String key = tiento;

            var a = (from n in dt.tblNhanViens
                     select n.MaNhanVien).Count();

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
        public int ThemNV(tblNhanVien nv)
        {
            System.Data.Common.DbTransaction them = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = them;
                if (Tim(nv.MaNhanVien.ToString()) != null)
                    return 0;
                else
                {
                    dt.tblNhanViens.InsertOnSubmit(nv);
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
        public bool Suanv(tblNhanVien nv)
        {
            System.Data.Common.DbTransaction sua = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = sua;
                IQueryable<tblNhanVien> tam = (from n in dt.tblNhanViens
                                               where n.MaNhanVien == nv.MaNhanVien
                                               select n);
                tam.First().TenNhanVien = nv.TenNhanVien;
                tam.First().NgaySinh = nv.NgaySinh;
                tam.First().ChucVu = nv.ChucVu;
                tam.First().CMND = nv.CMND;
                tam.First().GioiTinh = nv.GioiTinh;
                tam.First().SDT = nv.SDT;
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

    }
}
