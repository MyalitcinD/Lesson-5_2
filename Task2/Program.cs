using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15, min = 50, max = 0;
            int[] array = new int[n];
            Random random = new Random();
            for(int i = 0; i < n; i++) {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
                min = (min > array[i]) ? array[i] : min;
                max = (max < array[i]) ? array[i] : max;
            }
            Console.WriteLine();
            int res = min + max;
            Console.WriteLine("Сумма максимального и минимального элементов массива равна {0}", res);
            Console.ReadKey();

        }
    }
}
