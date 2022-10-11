using System;
using ConsoleApp8;

namespace ConsoleApp8
{
    internal class Enter
    {
        public void MultiplyArr(int[,] arrOne, int[,] arrTwo, int[,] arrResult)
        {

            int rowsResult = arrResult.GetLength(0);
            int columnsResult = arrResult.GetLength(1);
            int columnsOneArr = arrOne.GetLength(1);
            
            for (int i = 0; i < rowsResult; i++)
            {
                for (int j = 0; j < columnsResult; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < columnsOneArr; k++)
                    {
                        sum += arrOne[i, k] * arrTwo[k, j];
                    }
                    arrResult[i, j] = sum;
                }
            }
        }

        public void FillSpirallAray(int[,] arr)
        {
            int prod = arr.GetLength(0) * arr.GetLength(1);
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            int temp = 1;
            int i = 0;
            int j = 0;

            while (temp <= prod)
            {
                arr[i, j] = temp;
                temp++;
                if (i <= j + 1 && i + j < columns - 1)
                { j++; }
                else if (i < j && i + j >= rows - 1)
                { i++; }
                else if (i >= j && i + j > columns - 1)
                { j--; }
                else
                { i--; }
            }
            PrintArray(arr);

        }

        public void SummElementRows(int[,] arr)
        {
            int minSumm = 0;
            int sumRows = SumElements(arr, 0);
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                int temp = SumElements(arr, i);
                if (sumRows > temp)
                {
                    sumRows = temp;
                    minSumm = i;
                }
            }
            Console.WriteLine($"Наименьшая сумма элементов = {sumRows}, находится в {minSumm + 1} строке.");
        }
        private int SumElements(int[,] array, int i)
        {
            int summ = array[i, 0];
            for (int j = 1; j < array.GetLength(1); j++)
            {
                summ += array[i, j];
            }
            return summ;
        }
        public void SortArrRows(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    for (int k = 0; k < columns; k++)
                    {
                        if (arr[i, j] <= arr[i, k]) continue;
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }

            Console.WriteLine();
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