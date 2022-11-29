using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NumericSystemConverter;

namespace NumericSystemConverter
{
    class ErrorHandling
    {
        public static void ErrorHandler(Exception exec)
        {
            Console.WriteLine($"Uh-Oh! Looks like we ran into a problem! Patching the issue! it looks like it was a '{exec.Message}' \nWe're starting over with you please wait...!");
            Thread.Sleep(6000);
            Console.Clear();
            Program.Main(new string[0]);
        }
    }
}
