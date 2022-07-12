int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


if (a % b == 0)
{
    Console.WriteLine("Кртано 2-м");
}
else
{
    Console.WriteLine(a % b + a / b + " Остаток");
}



