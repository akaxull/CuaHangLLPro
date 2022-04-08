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
            return TongTien;
        }
    }
}
