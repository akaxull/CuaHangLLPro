
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
            string connectStr = @"Data Source=DESKTOP-8FPG7JT\MAY0;Initial Catalog=QLCuaHang;Integrated Security=True";
            dt = new CuaHangLLProDataContext(connectStr);
            dt.Connection.Open();
            return dt;
        }

        public void closeConnection()
        {
            dt.Connection.Close();
        }


    }
}