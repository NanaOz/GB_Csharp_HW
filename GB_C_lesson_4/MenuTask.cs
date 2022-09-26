using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class MenuTask
    {
        Enter enter = new Enter();
        Task task = new Task();

        public void MenuSelect()
        {
            Console.WriteLine("***WELCOME*** \n Выберите задачу, которую хотите решить:\n\t1 - Задача 25 \n\t2 - Задача 27 \n\t3 - Задача 29 \n\t4 - Меню \n\t0 - Выход");
            NewMenuTask();
        }

        private void MenuExit() {
             Console.WriteLine("Завершено!");
        }
        private void NewMenuTask()
        {
            int num = enter.Input();

            switch (num)
            {
                case 1:
                    task.task_25();
                    MenuSelect();
                    break;
                case 2:
                    task.task_27();
                    MenuSelect();
                    break;
                case 3:
                    task.task_29();
                    MenuSelect();
                    break;
                case 4:
                    MenuSelect();
                    break;
                case 0:
                    MenuExit();
                    break;
                default:
                    Console.WriteLine("ошибка - такой задачи не существует!");
                    break;
            }
        }
    }
}