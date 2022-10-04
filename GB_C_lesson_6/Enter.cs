using System;
using ConsoleApp6;

namespace ConsoleApp6
{
    internal class Enter
    {

        public int InputMessage(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public double InputMessageDouble(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public string BeautuLine()
        {
            string beautuLine = "------------------------------------------";
            Console.WriteLine(beautuLine);
            Console.WriteLine("***нажмите любую кнопку***");
            Console.ReadKey();
            return beautuLine;
        }

        public (double, double) Intersection(double b1, double k1, double b2, double k2)
        {
            double x = Math.Round((b2 - b1) / (k1 - k2), 2);
            double y = Math.Round(k1 * x + b1, 2);
            Console.WriteLine($"Пересечение в точке: ({x};{y})");
            return (x, y);
        }

        public void FillArrAndPrintSumChet(int[] arr, int count = 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = InputMessage($"Введите {i + 1} цифру: ");
                if (arr[i] > 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Введенные цифры: ");
            PrintArray(arr);
            Console.WriteLine($"Цифр больше нуля = {count}");
        }

        public void PrintArray(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }


    }
}