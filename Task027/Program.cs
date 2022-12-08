// Задача 27: Напишите программу, которая принимает на вход число и
// выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int length = CountNumbers(number);
SumNumbers(number, length);

int CountNumbers(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}

void SumNumbers(int b, int length)
{
    int sum =0;
    for (int i = 0; i<length; i++)
    {sum = sum + b % 10;
    b = b / 10;}
    Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
}