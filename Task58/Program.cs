// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row = 3; 
int column = 3; 
int[,] argA = new int[row, column];
int[,] argB = new int[column, row];
int[,] argC = new int[row, row];
Console.WriteLine("Матрица №1");
FillArray(argA);
Console.WriteLine("Матрица №2");
FillArray(argB);
Multiplication(argA, argB);
Console.WriteLine("Результирующая матрица");
PrintArray(argC);
int[,] Multiplication(int[,] a, int[,] b)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < a.GetLength(1); k++)
            {

                sum += a[i, k] * b[k, j];
            }
            argC[i, j] = sum;
        }
    }
    return a;
}

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


int[,] PrintArray(int[,] k)
{
    for (int i = 0; i < k.GetLength(0); i++)
    {
        for (int j = 0; j < k.GetLength(1); j++)
        {
            Console.Write($"{k[i, j]}  ");
        }
        Console.WriteLine();
    }
    return k;
}