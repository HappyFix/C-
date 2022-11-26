// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int myNumber = Convert.ToInt32(Console.ReadLine());
string target = Math.Abs(myNumber).ToString();

Console.WriteLine(target.Length > 2 ? target[2] : "Третьей цифры нет");