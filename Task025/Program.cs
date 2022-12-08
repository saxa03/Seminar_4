﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.Clear();
Console.WriteLine("Введите число А:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень B: ");
int B = int.Parse(Console.ReadLine());

Degree(A, B);


void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine($"{A} в степени {B} равно {result}");
}
