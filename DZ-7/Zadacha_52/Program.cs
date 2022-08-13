﻿Random rnd = new Random();
int strokaDlyaMassiva = rnd.Next(2, 5);
int stolbDlyaMassiva = rnd.Next(2, 5);

int[,] GetArr(int strokaDlyaMassiva, int stolbDlyaMassiva)
{
    int[,] arr = new int[strokaDlyaMassiva, stolbDlyaMassiva];
    Random rnd = new Random();

    for (int i = 0; arr.GetLength(0) > i; i++)
    {
        for (int j = 0; arr.GetLength(1) > j; j++)
        {
            arr[i, j] = rnd.Next(1, 50);
        }

    }
    return arr;
}

void PrintArr(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}

int[,] arr = GetArr(strokaDlyaMassiva, stolbDlyaMassiva);
PrintArr(arr);

double sredZnach = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sredZnach = (arr[i, j] + sredZnach);
    }
    sredZnach = sredZnach / arr.GetLength(1);
    System.Console.WriteLine(string.Format("Среднее значение " + i + " строки: " + "{0:F1}", sredZnach));
}