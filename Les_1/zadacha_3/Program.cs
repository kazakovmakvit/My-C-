// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача №3");


                                    /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

                                    4 -> да
                                    -3 -> нет
                                    7 -> нет

                                    */

Console.WriteLine("Введите число для проверки на четность");
int a = int.Parse(Console.ReadLine());

if( a % 2 == 0 )
    {
        Console.WriteLine( "Число a = " + a + ", Является четным");
        
    }
else
    {
        Console.WriteLine( "Число a = " + a + ", Не является четным");
    }