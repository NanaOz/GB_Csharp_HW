using System;
using ConsoleApp6;

namespace ConsoleApp6
{
    internal class Task
    {
        Enter enter = new Enter();

        //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        public void task_41()
        {
            Console.Clear();
            Console.WriteLine("ЗАДАЧА 41: ");
            int size = enter.InputMessage("Сколько чисел хотите ввести? ");
            int[] arr = new int[size];
            enter.FillArrAndPrintSumChet(arr);
            enter.BeautuLine();
        }

        //Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
        //y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
        public void task_43()
        {
            Console.Clear();
            Console.WriteLine("ЗАДАЧА 43: ");
            double b1 = enter.InputMessageDouble("Введите b1: ");
            double k1 = enter.InputMessageDouble("Введите k1: ");
            double b2 = enter.InputMessageDouble("Введите b2: ");
            double k2 = enter.InputMessageDouble("Введите k2: ");
            enter.Intersection(b1, k1, b2, k2);
            enter.BeautuLine();
        }
    }
}

