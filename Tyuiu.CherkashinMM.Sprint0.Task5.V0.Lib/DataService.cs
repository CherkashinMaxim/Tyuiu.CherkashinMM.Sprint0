using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.CherkashinMM.Sprint0.Task5.V0.Lib;

namespace Tyuiu.CherkashinMM.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtraction(int num1, int num2)
        {
            return (num1 - num2);
        }
        public static int Multipl(int num1, int num2)
        {
            return (num1 * num2);
        }
        public static int Division(int num1, int num2)
        {
            if (num2 == 0) {
                Console.WriteLine("Переменная num2 = {0}. На ноль делить нельзя", num2);
                return -1;
            }
            return (num1 / num2);
        }
    }
}
