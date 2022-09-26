using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    internal class Enter
    {
        public int Input()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void FillArray(int[] num)
        {
            Random random = new Random();

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(-100, 100);
            }
        }
        public void PrintArray(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }

        public string BeautuLine()
        {
            string beautuLine = "------------------------------------------";
            Console.WriteLine(beautuLine);
            return beautuLine;
        }
    }
}
