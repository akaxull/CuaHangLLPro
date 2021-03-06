using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CuaHangLLPro
{
    static class Function
    {
        public static bool PhoneCheck(this String s)
        {
            return Regex.Match(s, @"^([0][0-9]{2}[1-9]{7})$").Success;
        }
        public static bool CheckDate(this DateTime datetime)
        {
            return (datetime.CompareTo(DateTime.Now) <= 0);
        }
        public static bool CheckName(this string name)
        {
            return Regex.Match(name, @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$").Success;
        }
        public static bool CheckCMND(this string CMND)
        {
            return Regex.Match(CMND, @"^[0-9]{9}$").Success;
        }
    }
}
