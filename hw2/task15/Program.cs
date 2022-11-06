// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int numberDay = ReadInt("Введите день недели: ");

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

string dayOfWeek(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Это выходной");
        }
        else
        {
            Console.Write("Это рабочий");
        }
    }
    else
    {
        Console.Write("Это не");
    }
    return " день.";
}

Console.WriteLine(dayOfWeek(numberDay));