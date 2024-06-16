using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StaticDataAndMembers
{
    static class TimeUtilClass
    {
        public static void PrintTime() => WriteLine(DateTime.Now.ToShortTimeString());        
        public static void PrintDate() => WriteLine(DateTime.Today.ToShortDateString());
        
    }
}
