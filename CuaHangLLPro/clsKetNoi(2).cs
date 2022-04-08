
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CuaHangLLPro
{
    class clsKetNoi
    {
        CuaHangLLProDataContext dt;

        public CuaHangLLProDataContext GetDataContext()
        {
            string connectStr = @"Data Source=BAK9YF01HT2EEVD\SQLEXPRESS;Initial Catalog=QLCuaHang1;Integrated Security=True";
            dt = new CuaHangLLProDataContext(connectStr);
            dt.Connection.Open();
            return dt;
        }
    }
}