using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLLPro
{
    public class clsTaiKhoan : clsKetNoi
    {
        CuaHangLLProDataContext dt;
        clsNhanVien nv;
        public clsTaiKhoan()
        {
            dt = GetDataContext();
        }
        public tblTaiKhoan Timma(string username)
        {
            var account = (from x in dt.tblTaiKhoans
                           where x.MaNhanVien == username
                           select x).FirstOrDefault();
            return account;
        }
        public tblTaiKhoan Tim(string strmanv)
        {
            tblTaiKhoan mttemp = (from n in dt.tblTaiKhoans
                                  where n.MaNhanVien.Equals(strmanv)
                                  select n).FirstOrDefault();
            return mttemp;
        }
        public bool CheckAccount(tblTaiKhoan a)
        {
            tblTaiKhoan account = Timma(a.MaNhanVien);
            if (account == null)
            {
                return false;
            }

            if (a.MaNhanVien.Equals(account.MaNhanVien.Trim()) && a.MatKhau.Equals(account.MatKhau))
            {
                return true;
            }

            return false;
        }

        public bool checkCmnd(tblTaiKhoan a, string cmnd)
        {
            nv = new clsNhanVien();
            tblNhanVien nhanVien = nv.GetNhanVienTuMa(a.MaNhanVien);
            if (nhanVien.CMND.Contains(cmnd))
                return true;
            else
                return false;

        }
        public int ThemTK(tblTaiKhoan tk)
        {
            System.Data.Common.DbTransaction them = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = them;
                // if (Tim(tk.MaNhanVien.ToString()) != null)
                //  return 0;
                //else
                //{
                dt.tblTaiKhoans.InsertOnSubmit(tk);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return 1;
                // }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Loi không sửa được " + ex.Message);
            }
        }

        public bool DoiMK(tblTaiKhoan tkMoi)
        {
            System.Data.Common.DbTransaction myTrans = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTrans;
                IQueryable<tblTaiKhoan> tkTam = (from tk in dt.tblTaiKhoans
                                            where tk.MaNhanVien.Contains(tkMoi.MaNhanVien)
                                            select tk);
                tkTam.First().MatKhau = tkMoi.MatKhau;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                throw new Exception(e.ToString());
               
            }
        }
       
    }
}
