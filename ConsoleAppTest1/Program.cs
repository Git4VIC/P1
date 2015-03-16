using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDT = string.Empty;

            Console.WriteLine("Hello, World!");

            strDT = GetCurrentDateTime();
            Console.WriteLine("Current DateTime is {0}", strDT);

            Console.ReadKey();
        }

        static string GetCurrentDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss, dddd");
        }
    }
}
