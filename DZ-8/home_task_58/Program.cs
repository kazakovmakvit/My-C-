﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



int m = new Random().Next(3,6);
int n = new Random().Next(3,6);
int p = new Random().Next(3,6);


int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:\n");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
GetArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:\n");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение матриц №1 и №2:\n");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 21);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
  }
}