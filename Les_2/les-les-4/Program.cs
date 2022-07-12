/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

int a = int.Parse(Console.ReadLine());
KratnoeChislo (a);

void KratnoeChislo(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число " + number + " является кратным 7 и 23");
    }
    else
    {
        Console.WriteLine("Число " + number + " не является кратным 7 и 23");
    }
}




