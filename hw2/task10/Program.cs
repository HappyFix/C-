// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int myNumber = MyInt("Введите трехзначное число: ");
int sizeNumber = myNumber.ToString().Length;

if (sizeNumber < 3 || sizeNumber > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(Target(myNumber));
}

int MyInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Target(int a)
{
    int result = ((a / 10) % 10);
    return result;
}