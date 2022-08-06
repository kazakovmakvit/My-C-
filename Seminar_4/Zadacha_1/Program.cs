// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] getArray(int n)
{
    int[] array = new int[n];
    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        array[i] = rand.Next(-9, 10);
    }
    return array;
}


int[] array = getArray(12);
int sum = 0;
int raznost = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
    if (array[i] > 0)
    {
        sum = sum + array[i];
    }
    else
    {
        raznost = raznost + array[i];
    }
    i++;
}


Console.WriteLine(sum + " " + raznost);
