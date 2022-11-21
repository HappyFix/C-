// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(m, n);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.Write("Введите строку: ");
int str = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int colum = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine();

int[,] arr = new int[n, m];

    if (str < 0 || str > arr.GetLength(0) - 1 || colum < 0 || colum > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует  ");
}
    else
{
    object c = array.GetValue(str,colum);
    Console.WriteLine($"Значение элемента массива = {c}");
}
Console.WriteLine();
