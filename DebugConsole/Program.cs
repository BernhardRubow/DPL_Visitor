using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcNetworth_V1();
            CalcNetworth_V2();
            Console.ReadLine();

        }

        static void CalcNetworth_V1()
        {
            var calculator = new VisitorPattern_v1.Logic.NetWorthCaclulator();

            Console.WriteLine($"Networth (straigth forward): {calculator.CalcNetWorth()}");
        }

        static void CalcNetworth_V2()
        {
            var calculator = new VisitorPattern_v2.Logic.NetWorthCaclulator();

            Console.WriteLine($"Networth (visitor pattern) : {calculator.CalcNetWorth()}");
        }
    }
}
