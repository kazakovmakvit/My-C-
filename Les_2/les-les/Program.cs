int num = new Random().Next(10, 100);
Console.WriteLine("Рандомное число " + num);


int first = num / 10;
int second = num % 10;

if (first > second)
{ 
    Console.WriteLine("Максимальная цифра " + first);
}
else
{
    Console.WriteLine("Максимальная цифра " + second);
}