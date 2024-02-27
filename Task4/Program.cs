using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int count = 0;
            int[] array = new int[n];
            Random random = new Random();
            for(int i = 0; i < n; i++) {
                array[i] = random.Next(-50, 50);
                Console.Write("{0}({1})", array[i],i);
                if(((i % 2) == 0) && (array[i] > 0) && ((array[i] % 2) != 0)) {
                    Console.Write("! ");
                    count++;
                }
                else { Console.Write(" "); }
            }

            Console.WriteLine();

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах равно {0} ", count);


            Console.ReadKey();
        }
    }
}
