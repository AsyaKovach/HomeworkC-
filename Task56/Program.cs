// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int row = new Random().Next(3, 10);
int column = new Random().Next(3, 10);
int min = 0;
int sum = 0;
int[,] arg = new int[row, column];
int[] sums = new int[row];
Console.WriteLine($"Строк {row} и столбцов {column} в массиве");
FillArray(arg);
Console.WriteLine();
StringSum(arg);
int temp = sums[0];
Console.WriteLine();
MinString(sums);

int[,] FillArray(int[,] k)
{
    for (int i = 0; i < k.GetLength(0); i++)
    {
        for (int j = 0; j < k.GetLength(1); j++)
        {
            k[i, j] = new Random().Next(0, 100);
            Console.Write($"{k[i, j]} ");
        }
        Console.WriteLine();
    }
    return k;
}
void StringSum(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            sum = sum + a[i, j];
        }
        sums[i] = sum;
        Console.WriteLine($"{i} -  {sum}");
    }
}

void MinString(int[] a)
{
    for (int i = 0; i < a.Length - 1; i++)
    {
        if (temp < a[i])
        {
            Console.WriteLine($"{i} - {temp} ");
        }
        else
        {
            temp = a[i];
            min = i;
        }
    }
    Console.WriteLine($"Массив суммы; -  min  {min}");
}
