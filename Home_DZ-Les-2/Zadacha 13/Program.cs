/*
Задача 13: 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число N");
int num = int.Parse(Console.ReadLine());
int count = 1;                                   //значения счетчика может быть больше чем сама цифра (по этому использую сount = 1 для остановки)                       
int[] Massiv = new int[10];

if (num > 99)
{
    for (int indexCount = 0; num >= count; indexCount++)
    {
        Massiv[indexCount] = num % 10;
        num /= 10;
    }

    Array.Reverse(Massiv);                      // Простите я не хотел

    for (int i = 0; i < 10; i++)
    {
        while (Massiv[i] > 0)
        {
            i += 2;
            Console.WriteLine(Massiv[i]);
            return;                             
        }
    }
}
else
{
    Console.WriteLine("Число " + num + " не является 3-х значным числом (3 цифры нет)");
}


//Напишите комент по поводу кода для этой задачи, все ок или костыль ?
