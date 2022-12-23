//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int row = new Random().Next(3, 10);
int column = new Random().Next(3, 10);
int[,] arg = new int[row, column];
Console.WriteLine($"Строк {row} и столбцов {column} в массиве");
FillArray(arg);
Console.WriteLine();
MinMax(arg);
Console.WriteLine();
PrintArray(arg);

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
int[,] MinMax(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int b = 0; b < a.GetLength(1) - 1; b++)
            {
                if (a[i, b] < a[i, b + 1])
                {
                    int temp = a[i, b + 1];
                    a[i, b + 1] = a[i, b];
                    a[i, b] = temp;
                }
            }
        }
    }
    return a;
}

int [,] PrintArray(int[,] k)
{
for (int i = 0; i < k.GetLength(0); i++)
    {
        for (int j = 0; j < k.GetLength(1); j++)
        {
            Console.Write($"{k[i,j]}  ");
        }
        Console.WriteLine();
}
return k;
}