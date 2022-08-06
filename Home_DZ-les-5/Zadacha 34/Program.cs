//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размерность массива");
int razmerArr = int.Parse(Console.ReadLine());

int[] GetArr(int razmerArr)
{
    Random rnd = new Random();
    int[] arr = new int[razmerArr];

    for (int i = 0; razmerArr > i; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

int counter = 0;

int[] array = GetArr(razmerArr);


for (int i = 0; razmerArr > i; i++)
{
    if (array[i] % 2 == 0)
    {
        counter++;
    }
     System.Console.Write(array[i] + " ");
}
Console.WriteLine();
System.Console.WriteLine("Количестов четных чисел: " + counter);