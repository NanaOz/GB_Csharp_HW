using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_GB_sem2
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

        // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
        public void task_10()
        {
            Console.WriteLine("ЗАДАЧА №10");
            Console.WriteLine("Введите трехзначное число: ");
            int num = Input();
            if (num > 99 && num < 1000) 
            { 
            int two = num / 10 % 10;
            Console.WriteLine($"Вторая цифра вашего число: {two}");
            }
            else
            {
                Console.WriteLine("Неправльная размерность числа");
            }

            BeautuLine();
        }

        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        public void task_13()
        {
            Console.WriteLine("ЗАДАЧА №13");
            Console.WriteLine("Введите любое число: ");
            int num = Math.Abs(Input());

            string numTxt = Convert.ToString(num);
            if (numTxt.Length > 2)
            {
                Console.WriteLine($"Третья цифра: {numTxt[2]}");
            }
            else
            {
                Console.WriteLine("Третьей цифры нет!");
            }
            BeautuLine();
        }

        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
        public void task_15()
        {
            Console.WriteLine("ЗАДАЧА №15");
            Console.Write("Введите номер дня недели:");
            int num = Input();
            if (num >=1 && num <=5)
            {
                Console.WriteLine($"{DayWeek(num)}! Это будний день!");
            }
            else if (num == 6 || num == 7)
            {
                Console.WriteLine($"{DayWeek(num)}! Ура! Это выходной день!");
            }
            else
            {
                Console.WriteLine("Введите корректное значение от 1 до 7!");
            }
            BeautuLine();
        }

        static string DayWeek(int num)
        {
            string dayWeek = "";
            if (num == 1)
            {
                dayWeek = "Понедельник";
                return dayWeek;
            }
            else if (num == 2)
            {
                dayWeek = "Вторник";
                return dayWeek;
            }
            else if (num == 3)
            {
                dayWeek = "Среда";
                return dayWeek;
            }
            else if (num == 4)
            {
                dayWeek = "Четверг";
                return dayWeek;
            }
            else if (num == 5)
            {
                dayWeek = "Пятница";
                return dayWeek;
            }
            else if (num == 6)
            {
                dayWeek = "Суббота";
                return dayWeek;
            }
            else if (num == 7)
            {
                dayWeek = "Воскресение";
                return dayWeek;
            }
            else
            {
                dayWeek = "Введитет число от 1 до 7!!!";
                return dayWeek;
            }
        }
    }
}
