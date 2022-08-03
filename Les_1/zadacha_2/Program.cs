// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача №2");


/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/





Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());  /// число a

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());  /// число b

Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());  /// число c


if (a > b)
{
    if (a > c)
    {
        Console.Write("Число a = " + a + ", является максимальным");
    }
    else
    {
        Console.Write("Число c = " + c + ", является максимальным");
    }
}
else
{
    if (b > c)
    {
        Console.Write("Число b = " + b + ", является максимальным");
    }
    else
    {
        Console.Write("Число c = " + c + ", является максимальным");
    }
}