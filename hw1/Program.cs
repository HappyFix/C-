Console.Clear();

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Задача 2: Поиск максимального из двух чисел.");

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Числа равны.");
}

if (a > b)
{
    Console.WriteLine("Первое число больше второго.");
}
if (a < b)
{
    Console.WriteLine("Второе число больше первого.");
}



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача 4: Поиск максимального из трёх чисел.");

Console.Write("Введите первое число: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int d = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int e = Convert.ToInt32(Console.ReadLine());

int max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.WriteLine("Самое большое число: " + max);



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача 6: Определение чётности числа.");

Console.Write("Введите число: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f % 2 == 0 ? "Это четное число." : "Это не четное число.");



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Задача 6: Поиск всех чётных чисел до N.");

Console.Write("Введите число N: ");
int j = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= j; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}