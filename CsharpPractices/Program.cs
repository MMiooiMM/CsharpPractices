using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            Work.Mapping(new Class1 { A1 = "1", A2 = "2", A3 = "3", A4 = "4", A5 = "5", A6 = "6", A7 = "7" },
                System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Practice01\\Txt1.txt"),
                System.IO.Directory.GetCurrentDirectory() + "\\Txt1.txt");

            Work.Mapping(new Class2 { B1 = "A", B2 = "B", B3 = "C", B4 = "D", B5 = "E" },
              System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Practice01\\Txt2.txt"),
              System.IO.Directory.GetCurrentDirectory() + "\\Txt2.txt");
        }
    }
}
