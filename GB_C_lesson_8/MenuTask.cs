using System;
using ConsoleApp8;

namespace ConsoleApp8
{
    internal class MenuTask
    {
        Enter enter = new Enter();
        Task task = new Task();

        public void MenuSelect()
        {
            Console.WriteLine("************ \n Выберите задачу, которую хотите решить:\n\t1 - Задача 54 \n\t2 - Задача 56 \n\t3 - Задача 58 \n\t4 - Задача 60* \n\t0 - Выход");
            NewMenuTask();
        }

        private void NewMenuTask()
        {
            int num = enter.InputNum();

            switch (num)
            {
                case 1:
                    task.task_54();
                    MenuSelect();
                    break;
                case 2:
                    task.task_56();
                    MenuSelect();
                    break;
                case 3:
                    task.task_58();
                    MenuSelect();
                    break;
                case 4:
                    task.task_60();
                    MenuSelect();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("ошибка - такой задачи не существует!");
                    break;
            }
        }
    }
}