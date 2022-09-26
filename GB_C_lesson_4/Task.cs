using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Task
    {

        Enter enter = new Enter();

        //Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
        public void task_25()
        {
            Console.WriteLine("ЗАДАЧА 25");
            Console.WriteLine("Введите первое число: ");
            int one = enter.Input();
            Console.WriteLine("Введите второе число: ");
            int two = enter.Input();
            int degree = 1;
            for (int i = 0; i < two; i++)
            {
                degree *= one;
            }
            Console.WriteLine($"Число {one} в степень {two} = {degree}");
            enter.BeautuLine();
        }

        //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
        public void task_27()
        {
            Console.WriteLine("ЗАДАЧА 27");
            Console.WriteLine("Введите число: ");
            int num = enter.Input();

            int sum = 0;
            for (int i = 3; i >= 0; i--)
            {
                sum += num / (int)Math.Pow(10.0, i);
                num = num % (int)Math.Pow(10.0, i);
            }
            Console.WriteLine($"Сумма введенных Вами цифр = {sum}");
            enter.BeautuLine();
        }

        //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
        public void task_29()
        {
            Console.WriteLine("ЗАДАЧА 29");
            Random random = new Random();
            int size = 8;
            int[] arr = new int[size];
            enter.FillArray(arr);
            Console.WriteLine("Массив: ");
            enter.PrintArray(arr);
            Console.WriteLine("Сортировка массива была выпонена методом пузырька:  ");
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
            enter.PrintArray(arr);
            enter.BeautuLine();
        }
    }
}
