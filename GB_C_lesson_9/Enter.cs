using System;

namespace ConsoleApp9
{
    class Enter
    {

        public void TaskMultiple(int m, int n)
        {
            if (m % 3 == 0)
            {
                int tmp = m % 3;
                Console.WriteLine(m);
            }
            m++;
            if (m > n)
            {
                return;
            }
            TaskMultiple(m, n);
        }

        public int TaskNaturSum(int m, int n, int sum = 0)
        {
            if (m > n)
            {
                return sum;
            }
            sum += m;
            m++;
            return TaskNaturSum(m, n, sum);
        }

        public int TaskAkkerman(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return TaskAkkerman(m - 1, 1);
            }
            return TaskAkkerman(m - 1, TaskAkkerman(m, n - 1));
        }

        public int InputMessage(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public int InputNum()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public string BeautuLine()
        {
            string beautuLine = "------------------------------------------";
            Console.WriteLine(beautuLine);
            Console.WriteLine("***нажмите любую кнопку***");
            Console.ReadKey();
            return beautuLine;
        }
    }
}