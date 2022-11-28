// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите первое число (M): ");
int numberM = int.Parse(Console.ReadLine());

Console.Write("Введите второе число (N): ");
int numberN = int.Parse(Console.ReadLine());

void AdderNum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine();
        Console.WriteLine($"Сумма чисел от M до N = {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    AdderNum(numberM, numberN, sum);
}

AdderNum(numberM, numberN, 0);
Console.WriteLine();