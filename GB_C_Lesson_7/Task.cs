using System;
using ConsoleApp7;

namespace ConsoleApp7
{
    internal class Task
    {
        Enter enter = new Enter();
        //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
        public void task_47()
        {
            Console.Clear();
            Console.WriteLine("***ЗАДАЧА 47***");
            int m = enter.InputMessage("Введите колличество строк: ");
            int n = enter.InputMessage("Введите колличество столбцов: ");
            double[,] arr = new double[m, n];
            enter.FillArrayDoubleTwoArr(arr);
            enter.PrintArrayDoubleTwoArr(arr);
            enter.BeautuLine();
        }


        //Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
        //и возвращает значение этого элемента или же указание, что такого элемента нет.
        public void task_50()
        {
            Console.Clear();
            Console.WriteLine("***ЗАДАЧА 50***");
            int m = enter.InputRandom();
            int n = enter.InputRandom();
            int[,] arr = new int[m, n];
            enter.FillArray(arr);
            enter.PrintArray(arr);
            enter.FindingElement(arr);
            enter.BeautuLine();
        }

        //Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
        public void task_52()
        {
            Console.Clear();
            Console.WriteLine("***ЗАДАЧА 52***");
            int m = enter.InputRandom();
            int n = enter.InputRandom();
            int[,] a = new int[m, n];
            double[] b = new double[n];
            enter.FillArray(a);
            enter.PrintArray(a);
            enter.ArithmeticMean(a, b);
            enter.BeautuLine();
        }
    }
}