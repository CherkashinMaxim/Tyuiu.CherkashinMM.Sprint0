using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.CherkashinMM.Sprint0.Task6.V0.Lib;

namespace Tyuiu.CherkashinMM.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static int AdditionArray(int[] numbers)
        {
            var total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
        public static int SubtractionArray(int[] numbers)
        {
            var total = 0;
            var index = 0;

            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }
        public static int MultArray(int[] numbers)
        {
            var total = 1;
            var index = 0;

            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }
    }
}
