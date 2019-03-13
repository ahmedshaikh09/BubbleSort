using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[] { 8, -1, 7, 9, 4, -10, 0, 6, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Bubble Sort:");
            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
