﻿/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите пятизначное число N");
int num = int.Parse(Console.ReadLine());


if (num < 100000 && num > 10000)
{
    if (num % 10 == num / 10000 % 10 && num / 10 % 10 == num / 1000 % 10)
    {
        Console.WriteLine("число " + num + " является палиндромом");
    }
    else
    {
        Console.WriteLine("число " + num + " не является палиндромом");
    }
}
else
    Console.WriteLine("Введенное число не соответствует условию, попробуйте ввести другое число");
