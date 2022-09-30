using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Input
    {
        public int InputNum()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void FillArray(int[] num, int minValue = 0, int maxValue = 100)  //создание массива
        {
            maxValue++;
            Random random = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(minValue, maxValue);
            }
        }

        public void ArrayDouble(double[] num)  //создание и вывод массива вещественного
        {
            Random random = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.NextDouble() * 100;
                num[i] = Math.Round(num[i], 2);
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintArray(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintArrayDouble(double[] num)  //печать массива вещественного
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }

        public double MinElement(double[] array)  //поиск минимального в массиве
        {
            double minElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {

                if (minElement > array[i])
                {
                    minElement = array[i];
                }

            }
            return minElement;
        }

        public double MaxElement(double[] array)  //поиск максимального в массиве
        {
            double maxElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {

                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }

            }
            return maxElement;
        }

        public string BeautuLine()
        {
            string beautuLine = "------------------------------------------";
            Console.WriteLine(beautuLine);
            Console.WriteLine("***нажмите любую кнопку***");
            Console.ReadKey();
            return beautuLine;
        }
    }
}
