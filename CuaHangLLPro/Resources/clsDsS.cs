using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLLPro
{
    public class clsDsS
    {
        string Ma;
        string Ten;
        int giaSach;

        int Sl;
        int TongTien;

        public clsDsS()
        {

        }

        public clsDsS(string ma, string ten, int gia, int sl, int tt)
        {
            Ma = ma;
            Ten = ten;
            Sl = sl;
            TongTien = tt;
            giaSach = gia;
        }

        public void setSl(int sl)
        {
            Sl = sl;
        }
        public void setTT(int tt)
        {
            TongTien = tt;
        }

        public string getMa()
        {
            return Ma;
        }

        public string getTen()
        {
            return Ten;
        }

        public int getSl()
        {
            return Sl;
        }

        public int getTien()
        {
            return giaSach;
        }

        public int getTt()
        {
            return TongTien;
        }

        public IEnumerable<clsDsS> getDsSachIt(IEnumerable<clsDsS> dsS)
        {
            IEnumerable<clsDsS> s = from sach in dsS where sach.getSl() <= 30 && sach.getSl() > 0
                                    select sach;
            return s;
        }

        public IEnumerable<clsDsS> getDsSachKhongBanDuoc(IEnumerable<clsDsS> dsS)
        {
            IEnumerable<clsDsS> s = from sach in dsS
                                    where sach.getSl() == 0
                                    select sach;
            return s;
        }

        public IEnumerable<clsDsS> getDsSachVua(IEnumerable<clsDsS> dsS)
        {
            IEnumerable<clsDsS> s = from sach in dsS
                                    where sach.getSl() > 30 && sach.getSl() <= 70
                                    select sach;
            return s;
        }

        public IEnumerable<clsDsS> getDsSachNhieu(IEnumerable<clsDsS> dsS)
        {
            IEnumerable<clsDsS> s = from sach in dsS
                                    where sach.getSl() > 70 
                                    select sach;
            return s;
        }

        

        
    }
}
