using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Task
    {
        static int Input()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static string BeautuLine()
        {
            string beautuLine = "------------------------------------------";
            Console.WriteLine(beautuLine);
            return beautuLine;
        }

        //Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        public void task_19_var1()
        {
            Console.WriteLine("ЗАДАЧА №19 (первый вариант решения задачи)");
            Console.WriteLine("Введите пятизначное число: ");
            string num = Console.ReadLine() !;
            int len = num.Length;

            if (len == 5)
            {
                if (num[0] == num[4] && num[1] == num[3])
                {
                    Console.WriteLine($"{num} - Палиндром");
                }
                else
                {
                    Console.WriteLine($"{num} - Не палиндром");
                }
            }
            else
            {
                Console.WriteLine($"{num} - нужно вести пятизначное число");
            }
            BeautuLine();

        }

        //второй вариант(математический) решения задачи №19
         public void task_19_var2()
        {
            Console.WriteLine("ЗАДАЧА №19(второй вариант кода):D");
            Console.WriteLine("Введите пятизначное число: ");
            int num = Math.Abs(Input());

            int one = num / 10000 %10;
            int two = num / 1000 % 10;
            int three = num / 100 % 10;
            int four = num / 10 % 10;
            int five = num % 10;
            

            if (num > 9999 && num < 100000)
            {
                if (one == five && two == four)
                {
                    Console.WriteLine($"{num} - Палиндром");
                }
                else
                {
                    Console.WriteLine($"{num} - Не палиндром");
                }
            }
            else
            {
                Console.WriteLine($"{num} - нужно вести пятизначное число");
            }
            BeautuLine();

        }

        //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
        public void task_21()
        {
            Console.WriteLine("ЗАДАЧА №21");
            Console.WriteLine("Введите координату X первой точки: ");
            int x1 = Input();
            Console.WriteLine("Введите координату Y первой точки: ");
            int y1 = Input();
            Console.WriteLine("Введите координату Z первой точки: ");
            int z1 = Input();
            Console.WriteLine("Введите координату X второй точки: ");
            int x2 = Input();
            Console.WriteLine("Введите координату Y второй точки: ");
            int y2 = Input();
            Console.WriteLine("Введите координату Z второй точки: ");
            int z2 = Input();

            int A = x2 - x1;
            int B = y2 - y1;
            int C = z1 - z2;

            double length = Math.Sqrt(A * A + B * B + C * C);
            length = Math.Round(length, 2);
            Console.WriteLine($"Длинна отрезка {length}");

            BeautuLine();

        }
        

        //Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        public void task_23()
        {
            Console.WriteLine("ЗАДАЧА №23");
            Console.WriteLine("Введите число: ");
            int number = Input();

            Console.WriteLine("Число\tКуб");

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i,3));
            }

        }

    }
}
