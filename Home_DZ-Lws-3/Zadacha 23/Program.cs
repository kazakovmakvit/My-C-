﻿/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.WriteLine("Введите число (N)");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Кубы чисел до N: ");
for (int i = 1; i < num + 1; i++)
{
    int kubChisla = i * i * i;
    Console.Write(" " + kubChisla);
}

