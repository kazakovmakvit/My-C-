//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int sum=0;
Console.Write("Введи M: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int n = Convert.ToInt16(Console.ReadLine());

for (int i = m; i <= n; i++)
    sum += i;
Console.WriteLine(sum);