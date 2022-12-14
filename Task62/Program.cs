// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размерность: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arg = new int[n, n];
InitArrg(arg);
PrintArray(arg);
Console.WriteLine();


void InitArrg(int[,] array)
{
    int i = 0,
        j = 0,
        count = 1,
        n = array.GetLength(0);
    double fi = 0;
    int y = (int)Math.Sin(fi),
        x = (int)Math.Cos(fi);

    while (count <= n * n)
    {
        array[i, j] = count++;
        if (i + x < 0
           | i + x >= n
           | j + y < 0
           | j + y >= n)
        {
            ChangeDirection(ref x, ref y, ref fi);
        }
        else if (array[i + x, j + y] > 0)
        {
            ChangeDirection(ref x, ref y, ref fi);
        }
        i += x;
        j += y;
    }
}

void ChangeDirection(ref int x, ref int y, ref double k)
{
    k = k + Math.PI / 2;
    y = (int)Math.Sin(k);
    x = (int)Math.Cos(k);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, -3}", array[j, i]);
        }
        Console.WriteLine();
    }
}