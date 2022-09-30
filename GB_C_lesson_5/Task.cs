using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5;

namespace ConsoleApp5
{
    internal class Task
    {
        Input input = new Input();

        public void task_34()
        {
            Console.WriteLine("ЗАДАЧА 34: Задайте массив заполненный случайными положительными трёхзначными числами. \nНапишите программу, которая покажет количество чётных чисел в массиве.");
            Console.WriteLine("Введите размер массива: ");
            int size = input.InputNum();
            int[] numbers = new int[size];
            input.FillArray(numbers, 100, 999);
            input.PrintArray(numbers);
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    sum = sum + 1;
            }
            Console.WriteLine($"Колличество четных чисел в массиве = {sum}");
            input.BeautuLine();

        }

        public void task_36()
        {
            Console.WriteLine("ЗАДАЧА 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.");
            Console.WriteLine("Введите размер массива: ");
            int size = input.InputNum();
            int[] numbers = new int[size];
            input.FillArray(numbers);
            input.PrintArray(numbers);
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1)
                    sum = sum + numbers[i];
            }
            Console.WriteLine($"Сумма элементов с нечётными индексами = {sum}");
            input.BeautuLine();

        }

        public void task_38()
        {
            Console.WriteLine("ЗАДАЧА 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
            Console.WriteLine("Введите размер массива: ");
            int size = input.InputNum();
            double[] numbers = new double[size];
            input.ArrayDouble(numbers);
            double min = input.MinElement(numbers);
            Console.WriteLine($"Минимальный элемент в массиве = {min}");
            double max = input.MaxElement(numbers);
            Console.WriteLine($"Максимальный элемент в массиве = {max}");
            double difference =Math.Round(Math.Abs(max) - Math.Abs(min), 2);
            Console.WriteLine($"Разница между максимальным и минимальным элементами = {difference}");
            input.BeautuLine();
        }
    }
}
