// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число ");
int chisloA = int.Parse(Console.ReadLine());
int sum = 0;
int constatnaTEN = 10;

for (int i = 1; chisloA > 0; i++)
{
    sum = sum + chisloA % 10;
    chisloA = chisloA / 10;
}
Console.WriteLine(sum);