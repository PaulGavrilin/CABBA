/*
using System;
namespace Hello
{
    class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
------------------------------------------------------------------------------------------
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) &&
{
    Console.WriteLine("Число 1 больше");
}
else
{
    Console.WriteLine("Число 2 больше");
}
----------------------------------------------------------------------------------------------------
Console.WriteLine("Введите значение x не равное нулю: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение y не равное нулю: ");
int y = int.Parse(Console.ReadLine()!);
if ( x > 0 && y > 0)
{
    Console.WriteLine("Первая четверть");
}
else if ( x < 0 && y > 0)
{
    Console.WriteLine("Вторая четверть");
}
else if ( x > 0 && y < 0)
{
    Console.WriteLine("Третья четверть");
}
else if ( x < 0 && y < 0)
{
    Console.WriteLine("Четвёртая четверть");
}
else
{
    Console.WriteLine("Неверное значение");
}
*/
Console.WriteLine("Введите значение: ");
int a = int.Parse(Console.ReadLine()!);
if ( a % 4 == 0)
{
    if ( a % 3 == 0)
    {
        if ( a % 2 == 0)
        {
            Console.WriteLine("Число кратно четырём, трём и двум");
        }
    }
}
else
{
    Console.WriteLine("Число не кратно четырём, трём и двум");
}