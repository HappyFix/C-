﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

void RecursionDown(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        RecursionDown(n, count + 1);
        Console.Write(count + " ");
    }
    
}
RecursionDown(number, count);

Console.WriteLine();