int a = new Random().Next (100, 1000);
Console.WriteLine (a);

int result = deleteSecondNumber (a);
Console.WriteLine (result);

int deleteSecondNumber (int number)
{
    int digitOne = number / 100;
    int digitThird = number % 10;
    int resultDouble = digitOne * 10 + digitThird;
    return resultDouble;
}
