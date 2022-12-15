// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int row = new Random().Next(0, 10);
int column = new Random().Next(0, 10);
int[,] arg = new int[row, column];
double[] sum = new double[column];
MidSum(FillArray(arg), sum);

int[,] FillArray(int[,] k)
{
    for (int i = 0; i < k.GetLength(0); i++)
    {
        for (int j = 0; j < k.GetLength(1); j++)
        {
            k[i, j] = new Random().Next(0, 10);
            Console.Write($"{k[i, j]} ");
        }
        Console.WriteLine();
    }
    return k;

}
void MidSum(int[,] a, double[] b)
{
    for (int j = 0; j < arg.GetLength(1); j++)
    {
        for (int i = 0; i < arg.GetLength(0); i++)
        {

            b[j] = b[j] + a[i, j];

        }
        b[j]= Math.Round(b[j]/row, 2);
         Console.WriteLine($"Среднее арифметическое столбцов{j} - {b[j]} ");

    }
}