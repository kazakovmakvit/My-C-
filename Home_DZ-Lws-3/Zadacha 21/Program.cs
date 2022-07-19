/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double DlinnaOtrezka(int x, int y, int z, int x2, int y2, int z2)
{
    double Dlinna = Math.Sqrt((x2 - x) * (x2 - x) + (y2 - y) * (y2 - y) + (z2 - z) * (z2 - z));
    return Dlinna;
}

Console.Write("Введите координаты X ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты X_2 ");
int x2 = int.Parse(Console.ReadLine());

///

Console.Write("Введите координаты Y ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты Y_2 ");
int y2 = int.Parse(Console.ReadLine());

///

Console.Write("Введите координаты Z ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите координаты Z_2 ");
int z2 = int.Parse(Console.ReadLine());

///

Console.WriteLine("Отрезхок равен: " + DlinnaOtrezka(x1, y1, z1, x2, y2, z2));


