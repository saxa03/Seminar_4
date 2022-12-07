﻿//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.Clear();
int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetBinaryArray(int size)
{
    int[] result = new int  [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}