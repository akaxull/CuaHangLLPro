
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CuaHangLLPro
{
    public class clsKetNoi
    {
        CuaHangLLProDataContext dt;

        public CuaHangLLProDataContext GetDataContext()
        { 
            string connectStr = @"Data Source=DESKTOP-6D5Q3BS\SQLEXPRESS;Initial Catalog=QLCuaHang;Integrated Security=True";
            dt = new CuaHangLLProDataContext(connectStr);
            dt.Connection.Open();
            return dt;
        }


    }
}