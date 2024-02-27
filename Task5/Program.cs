using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива NxN");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Random random = new Random();
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(((i + j) % 2) == 0) {
                        array[i, j] = 1;
                    }
                    else {
                        array[i, j] = 0;
                    }
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
