using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int mid = n / 2;
            int[] array = new int[n];
            Random random = new Random();
            for(int i = 0; i < n; i++) {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            for(int i = 0; i < mid - 1; i++) {
                for(int j = i + 1; j < mid; j++) {
                    if(array[i] > array[j]) {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                    if(array[n - i - 1] > array[n - j - 1]) {
                        int t = array[n - i - 1];
                        array[n - i - 1] = array[n - j - 1];
                        array[n - j - 1] = t;
                    }
                }
            }
            Console.WriteLine();
            for(int i = 0; i < n; i++) {
                Console.Write("{0} ", array[i]);
            }

            Console.ReadKey();
        }
    }
}
