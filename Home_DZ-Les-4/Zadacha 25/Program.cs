// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введите число A, которое нужно возвести в степень");
int chisloA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень (N)");
int sqrN = int.Parse(Console.ReadLine());
//
if (sqrN >= 1)
{
    double b = Math.Pow(chisloA, sqrN);
    Console.WriteLine("Вывод числа : " + b);
}
else
{
    Console.WriteLine("Ошибка, введено не натуральное число");
}


