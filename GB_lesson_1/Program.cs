//Задача 2
//Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, 
//а какое меньшее.
Console.WriteLine("ЗАДАЧА 2");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Первое число {num1} больше, чем второе число {num2}");
}
else
{
    Console.WriteLine($"Второе число {num2} больше, чем первое число {num1}");
}

//Задача 4
//Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.
Console.WriteLine("ЗАДАЧА 4");
Console.Write("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numb3 = Convert.ToInt32(Console.ReadLine());
if (numb1 > numb2 && numb1 > numb3)
{
    Console.WriteLine($"Первое число {numb1} больше двух других");
}
else if (numb2 > numb1 && numb2 > numb3)
{
    Console.WriteLine($"Второе число {numb2} больше двух других");
}
else
{
    Console.WriteLine($"Третье число {numb3} больше двух других");
}

//Задача 6: Напишите программу, которая на вход принимает число и 
//выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("ЗАДАЧА 6");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 2) == 0)
{
    Console.WriteLine($"Число {number} является четным");
}
else
{
    Console.WriteLine($"Число {number} является нечетным");
}

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("ЗАДАЧА 8");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    Console.Write("Введите положительное число");
}
else
{
    while (num > 1)
    {
        if ((num % 2) == 0)
        {
            Console.Write(num + ";");
        }
        num = num - 1;
    }
}