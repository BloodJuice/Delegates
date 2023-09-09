using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects_Time
{
    static class ExtensionMethods
    {
        public static void Print(this DateTime dateTime) 
        { 
            Console.WriteLine(dateTime);
            Console.ReadLine();
        }
    }
}
