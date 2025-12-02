using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hw2_Email
{
    internal class Tools
    {
        public static bool EmailFormatCheck(string From, string To)
        {
            string input = From;
            bool Correct = Regex.IsMatch(From, @"^([a-zA-Z\d\.\-_]+)@([a-z]{2,15})((\.([a-z]+))|(\.([a-z][A-Z]+)\.([a-z]+)))$");
            if (Correct) return true;
            else return false;
        }
    }
}
