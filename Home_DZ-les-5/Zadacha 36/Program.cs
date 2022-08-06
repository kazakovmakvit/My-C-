// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


System.Console.Write("Введите размерность одномерного массива: ");
int razmerArr = int.Parse(Console.ReadLine());

int[] GetArr(int razmerArr)
{
    Random rnd = new Random();
    int[] arr = new int[razmerArr];

    for (int i = 0; razmerArr > i; i++)
    {
        arr[i] = rnd.Next(-10, 11);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; arr.Length > i; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
    return;
}


int sum = 0;
int[] array = GetArr(razmerArr);

PrintArray(array);

for (int i = 1; razmerArr > i; i += 2)
{
    sum = array[i] + sum;
}
System.Console.Write("Сумма элементов, стоящих на нечётных позициях равна: " + sum);