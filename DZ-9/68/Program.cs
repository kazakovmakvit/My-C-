//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Akerman(n, m);

static int Akerman(int m, int n)
{
    if (m == 0) 
    return n + 1;

    if (m != 0 && n == 0)
    return Akerman(m - 1, 1);

    if (m > 0 && n > 0) 
    return Akerman(m - 1, Akerman(m, n - 1));
    return Akerman(m, n);
} 
System.Console.WriteLine(Akerman(m, n));

