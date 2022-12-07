//Задача 28: Напишите программу,
//которая принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120\

Console.Clear();
Console.Write("Введите  число:");
int limit = int.Parse (Console.ReadLine());
Console.WriteLine($"произведение чисел от 1 до {limit} равно {GetSum(limit)}");
 int GetSum(int limit)
 {
    int sum = 1;
    for (int i = 1; i <= limit; i++)
    
        sum = sum * i;
    return sum;
 }
