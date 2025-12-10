using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supply Store1 = new Supply();
            
            Store1.MainMenu();
        }
    }
}

/* 
    "\x1b[38;5;196mRed\x1b[0m "    
    "\x1b[38;5;208mOrange\x1b[0m " 
    "\x1b[38;5;226mYellow\x1b[0m " 
    "\x1b[38;5;46mGreen\x1b[0m "   
    "\x1b[38;5;21mBlue\x1b[0m "    
    "\x1b[38;5;54mIndigo\x1b[0m "  
    "\x1b[38;5;201mViolet\x1b[0m"
*/