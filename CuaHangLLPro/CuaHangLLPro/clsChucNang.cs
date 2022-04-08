using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CuaHangLLPro
{
    public static class clsChucNang
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
        public static Boolean intcheck(this String s)
        {
            return Regex.Match(s, "^([0-9][0-9]{0,1})$").Success;
        }

        public static Boolean tienChek(this String s)
        {
            return Regex.Match(s, "^([0-9]{0,9})$").Success;
        }
        public static string LTrim(this string s)
        {
            //"    Le Tan Dung"
            int i = 0;
            while (s[i] == ' ')
            {
                i++;
            }
            s = s.Substring(i);
            return s;
        }
        //các bạn nện dùng cách này để kết hơp được RegularExpression
        public static string LTrim1(this string s)
        {
            //"    Le Tan Dung"
            while (Regex.Match(s, @"^\s+").Success)
                s = s.Substring(1);
            return s;
        }
        public static string RTrim(this string s)
        {
            //"Le Tan Dung    "
            int i = s.Length - 1;
            while (s[i] == ' ')
            {
                i--;
            }
            s = s.Substring(0, i + 1);
            return s;
        }

        public static string MTrim(this string s)
        {
            //"    Le Tan      Dung"
            while (s.IndexOf("  ") >= 0)
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public static string MTrim1(this string s)
        {
            //"    Le Tan      Dung"
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public static string MTrim2(this string s)
        {
            //"    Le Tan      Dung"
            while (Regex.Match(s, "  ").Success)
            {
                s = s.Replace("  ", " ");
            }
            return s;
        }
        public static String PerfectString(this String s)
        {
            //s = s.LTrim();
            //s = s.MTrim();
            //s = s.RTrim();
            s = s.LTrim().MTrim().RTrim();
            s = " " + s;
            s = s.ToLower();//" le tan dung" 
            foreach (Match item in Regex.Matches(s, @"\s\S"))
            {
                s = s.Replace(item.Value, item.Value.ToUpper());
            }
            // hoa dau moi tu
            //" Le Tan Dung" 
            return s.Substring(1, s.Length - 1);
        }
        public static String PerfectString1(this String s)
        {
            //s = s.LTrim();
            //s = s.MTrim();
            //s = s.RTrim();
            string sub = s.Substring(0, 1).ToUpper();
            return sub + s.Substring(1, s.Length - 1);
        }
    }
}
