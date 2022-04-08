using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangLLPro
{
    class clsHoaDon : clsKetNoi
    {
        CuaHangLLProDataContext dt;
        public clsHoaDon()
        {
            dt = GetDataContext();
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
    }
}
