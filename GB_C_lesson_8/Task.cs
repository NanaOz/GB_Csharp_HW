using System;
using ConsoleApp8;

namespace ConsoleApp8
{
    internal class Task
    {
        Enter enter = new Enter();

        //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
        public void task_54()
        {
            Console.Clear();
            Console.WriteLine("***ЗАДАЧА 54***");
            int m = enter.InputMessage("Введите колличество строк: ");
            int n = enter.InputMessage("Введите колличество столбцов: ");
            int[,] arr = new int[m, n];
            enter.FillArray(arr);
            enter.PrintArray(arr);
            enter.SortArrRows(arr);
            enter.PrintArray(arr);
            enter.BeautuLine();
        }

        //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
        public void task_56()
        {
            Console.Clear();
            Console.WriteLine("***ЗАДАЧА 56***");
            int m = enter.InputMessage("Введите колличество строк: ");
            int n = enter.InputMessage("Введите колличество столбцов: ");
            if (m > n)
            {
                int[,] arr = new int[m, n];
                enter.FillArray(arr);
                enter.PrintArray(arr);
                enter.SummElementRows(arr);
            }
            else
            {
                Console.WriteLine("Массив должен быть прямоугольным. \nКоличество строк должно быть больше, чем колличество столбцов!");
            }
            enter.BeautuLine();
        }

        //Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4
        public void task_58()
        {
            Console.Clear();
            Console.WriteLine("***ЗАДАЧА 58***");
            Console.WriteLine("Массив заполненный спиралью: ");
            int m = 4;
            int[,] arr = new int[m, m];
            enter.FillSpirallAray(arr);
            enter.BeautuLine();
        }



        //Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
        public void task_60()
        {
            Console.Clear();
            Console.WriteLine("***ЗАДАЧА 60***");
            int m = enter.InputRandom();
            int n = enter.InputRandom();
            int k = enter.InputRandom();
            int[,] arrOne = new int[m, n];
            int[,] arrTwo = new int[n, k];
            enter.FillArray(arrOne);
            enter.FillArray(arrTwo);
            enter.PrintArray(arrOne);
            Console.WriteLine();
            enter.PrintArray(arrTwo);
            int[,] arrMultiplier = new int[m, k];
            enter.MultiplyArr(arrOne, arrTwo, arrMultiplier);
            Console.WriteLine("Произведение первой и второй матриц: ");
            enter.PrintArray(arrMultiplier);
            enter.BeautuLine();
        }

    }

}
