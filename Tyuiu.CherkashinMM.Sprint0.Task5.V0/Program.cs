using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.CherkashinMM.Sprint0.Task5.V0.Lib;

namespace Tyuiu.CherkashinMM.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1 + num2 = " + DataService.Addition(1,5));
            Console.WriteLine("num1 - num2 = " + DataService.Subtraction(15,5));
            Console.WriteLine("num1 * num2 = " + DataService.Multipl(10, 10));
            Console.WriteLine("num1 / num2 = " + DataService.Division(9,3));
            Console.ReadKey();
        }
    }
}
