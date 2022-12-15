// SЗадача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write($"Укажите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Укажите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arg = new double[m, n];
Array();
void Array()
{
for (int i = 0; i < arg.GetLength(0); i++)
{
    for (int j = 0; j < arg.GetLength(1); j++)
    {
        arg[i, j] = new Random().NextDouble();
        Console.Write($"{Math.Round(arg[i, j], 2)}");
    }
    Console.WriteLine();
}
}
