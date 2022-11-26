// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Введите число: ");
string target = Console.ReadLine();
int len = target.Length;

if (len == 5)
{
    if (target[0] == target[4] && target[1] == target[3])
    {
        Console.WriteLine($"{target} - Да");
    }
    else
    {
        Console.WriteLine($"{target} - Нет");
    }
}
else
{
    Console.WriteLine($"{target} - не является пятизначным");
}