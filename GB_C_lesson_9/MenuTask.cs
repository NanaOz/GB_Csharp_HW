using System;

namespace ConsoleApp9 {
    class MenuTask {

        Task task = new Task();
        Enter enter = new Enter();

        public void MenuSelect()
        {
            Console.WriteLine("************ \n Выберите задачу, которую хотите решить:\n\t1 - Задача 64 \n\t2 - Задача 66 \n\t3 - Задача 68 \n\t0 - Выход");
            NewMenuTask();
        }

        private void NewMenuTask()
        {
            int num = enter.InputNum();

            switch (num)
            {
                case 1:
                    task.task_64();
                    MenuSelect();
                    break;
                case 2:
                    task.task_66();
                    MenuSelect();
                    break;
                case 3:
                    task.task_68();
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