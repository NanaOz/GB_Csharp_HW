using System;

namespace ConsoleApp9
{
    class Task
    {

        Enter enter = new Enter();

        //Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
        //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        public void task_64()
        {
            Console.WriteLine("***ЗАДАЧА 64***");
            int m = enter.InputMessage("Введите число M: ");
            int n = enter.InputMessage("Введите число N: ");
            if (m > n)
            {
                Console.WriteLine("M не моджет быть больше N!!!");
            }
            else
            {
                enter.TaskMultiple(m, n);
            }
            enter.BeautuLine();
        }


        //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        public void task_66()
        {
            Console.WriteLine("***ЗАДАЧА 66***");
            int m = enter.InputMessage("Введите число M: ");
            int n = enter.InputMessage("Введите число N: ");
            if (m > n)
            {
                Console.WriteLine("M не моджет быть больше N!!!");
            }
            else
            {
                Console.WriteLine(enter.TaskNaturSum(m, n));
            }
            enter.BeautuLine();

        }

        //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        public void task_68()
        {
            Console.WriteLine("***ЗАДАЧА 68***");
            int m = enter.InputMessage("Введите число M: ");
            int n = enter.InputMessage("Введите число N: ");
            if (m < 0 && n < 0)
            {
                Console.WriteLine("M и N должны быть положительные!!!");
            }
            else
            {
                Console.WriteLine(enter.TaskAkkerman(m, n));
            }
            enter.BeautuLine();
        }
    }
}