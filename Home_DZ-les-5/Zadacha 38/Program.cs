// Задайте массив "ВЕЩЕСТВЕННЫХ" чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76 если по примеру, то можно инт использовать ??


System.Console.Write("Введите размер массива: ");
int razmerArr = int.Parse(Console.ReadLine());

double[] GetArr(int razmerArr)
{
    double[] arr = new double[razmerArr];
    Random rnd = new Random();

    for (int i = 0; razmerArr > i; i++)
    {
        arr[i] = rnd.NextDouble();
    }
    return arr;
}

void PrintArr(double[] arr)
{
    for (int i = 0; arr.Length > i; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
    return;
}

double[] arr = GetArr(razmerArr);

PrintArr(arr);

double min = arr[0];
double max = arr[0];

for (int i = 1; arr.Length > i; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }

    if (arr[i] < min)
    {
        min = arr[i];
    }
}
double razn = max - min;
System.Console.WriteLine("\nMax значение массива: "+max+ " \nMin значение массива: " +min + " \n\nРазница Max и Min элемента массива составляет: " + razn);