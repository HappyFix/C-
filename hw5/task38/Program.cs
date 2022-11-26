// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];
	
Random rand = new Random();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

for (int x = 0; x < size; x++)
{
    numbers[x] = rand.Next(2, 50);
    Console.Write(numbers[x] + " ");
}

int max = 0;
int min = 100;

for (int i = 0; i < size; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
for (int j = 0; j < size; j++)
{
    if (numbers[j] < min)
    {
        min = numbers[j];
    }
}
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");