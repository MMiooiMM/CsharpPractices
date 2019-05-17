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
            Work.Mapping(
                System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Practice01\\Txt1.txt"),
                new Class1 { A1 = "1", A2 = "2", A3 = "3", A4 = "4", A5 = "5", A6 = "6", A7 = "7" });

            Work.Mapping(
                System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "\\Practice01\\Txt2.txt"),
                new Class2 { B1 = "A", B2 = "B", B3 = "C", B4 = "D", B5 = "E" });
        }
    }
}
