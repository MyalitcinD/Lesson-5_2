using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7, s = 0;
            int[] array = new int[n];
            Console.WriteLine("Введите числа массива");
            for(int i = 0; i < n; i++) {
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
            }
            double res_mean = (double)s / n;
            Console.WriteLine("Среднее арифметическое равно {0}", res_mean);
            Console.ReadKey();
        }
    }
}
