// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int size = ReadInt("Введите размерность массива: ");
int[] array = new int[size];
int countEven = 0;
int countNotEven = 0;

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) countEven = countEven + 1;
    else countNotEven = countNotEven + 1;
}
Console.Write("Четных чисел в массиве: " + countEven);
Console.WriteLine();
Console.Write("Нечетные чисел в массиве: " + countNotEven);
