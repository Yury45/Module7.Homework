using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Homework.Extentions
{
    public static class StringExtention
    {
        public static string ToNewFormat(this int str)
        {
            string a = "R" + str.ToString();
            return a;
        }
    }
}
