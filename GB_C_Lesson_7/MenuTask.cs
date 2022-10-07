using System;
using ConsoleApp7;

namespace ConsoleApp7
{
    internal class MenuTask
    {
        Task task = new Task();
        Enter enter = new Enter();
        public void MenuSelect()
        {
            Console.WriteLine("************ \n Выберите задачу, которую хотите решить:\n\t1 - Задача 47 \n\t2 - Задача 50 \n\t3 - Задача 52 \n\t0 - Выход");
            NewMenuTask();
        }
        
        private void NewMenuTask()
        {
            int num = enter.InputNum();

            switch (num)
            {
                case 1:
                    task.task_47();
                    MenuSelect();
                    break;
                case 2:
                    task.task_50();
                    MenuSelect();
                    break;
                case 3:
                    task.task_52();
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