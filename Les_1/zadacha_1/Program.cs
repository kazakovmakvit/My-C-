// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());  /// int.Parse() переводит вводимые значения в числа (пользователь всегда вводит строку)

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());  /// int.Parse() переводит вводимые значения в числа (пользователь всегда вводит строку)
if(a > b) 
{
    Console.WriteLine("Вывод: a больше b, а = " + a);
}
else
{
    Console.WriteLine("Вывод: a меньше b, b =  " + b);
}
