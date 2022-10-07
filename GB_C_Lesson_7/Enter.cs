using System;
using ConsoleApp7;

namespace ConsoleApp7
{
    internal class Enter
    {
        public void ArithmeticMean(int[,] arr, double[] mass)
        {
            Console.WriteLine();
            for (int i = 0, k = 0; i < arr.GetLength(1); i++)
            {
                double summa = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    summa += arr[j, i];
                }
                mass[k] = Math.Round(summa / arr.GetLength(0), 1);
                Console.Write(mass[k] + "\t");
                k++;
            }
           
            Console.WriteLine(" - Среднее арифметическое столбцов");
        }

        public void FindingElement(int[,] arr)
        {
            int posRow = InputMessage("Введите номер строки: ");
            int posColumn = InputMessage("Введите номер столбца: ");
            if (posRow < arr.GetLength(0))
            {
                Console.WriteLine($"Значение элемента = {arr[posRow, posColumn]}");
            }
            else
            {
                Console.WriteLine("Такого элемента не существует!");
            }
        }

        public void FillArrayDoubleTwoArr(double[,] num)  
        {
            Random random = new Random();

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = random.NextDouble() * 200 - 100;
                    num[i, j] = Math.Round(num[i, j], 1);
                }
            }

        }

        public void PrintArrayDoubleTwoArr(double[,] num)  
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void FillArray(int[,] num, int minValue = 0, int maxValue = 100)  
        {
            maxValue++;
            Random random = new Random();

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        public void PrintArray(int[,] num) 
        {
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int InputMessage(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public int InputRandom()
        {
            Random random = new Random();
            return random.Next(2, 10);
        }

        public int InputNum()
        {
            return Convert.ToInt32(Console.ReadLine());
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