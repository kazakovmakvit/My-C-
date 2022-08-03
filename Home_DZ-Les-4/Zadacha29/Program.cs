// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] myArr = new int[8];
Random rand = new Random();

for (int i = 0; myArr.Length > i; i++)
{
    myArr[i] = rand.Next(-50,50);
    Console.Write(myArr[i]+ " ");
}


