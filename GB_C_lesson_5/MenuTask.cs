using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class MenuTask
    {
        Input input = new Input();
        Task task = new Task();

        public void MenuSelect()
        {
            Console.WriteLine("****** \n Выберите задачу, которую хотите решить:\n\t1 - Задача 34 \n\t2 - Задача 36 \n\t3 - Задача 38 \n\t0 - Выход");
            NewMenuTask();
        }

        private void MenuExit()
        {
            Console.WriteLine("Завершено!");
        }
        private void NewMenuTask()
        {
            int num = input.InputNum();

            switch (num)
            {
                case 1:
                    task.task_34();
                    MenuSelect();
                    break;
                case 2:
                    task.task_36();
                    MenuSelect();
                    break;
                case 3:
                    task.task_38();
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
