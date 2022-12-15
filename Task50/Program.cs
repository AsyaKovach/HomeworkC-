// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет

Console.Write($"Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arg = new int[m, n];
bool check = false;
FillArray(arg);
void FillArray(int[,] k)
{
    for (int i = 0; i < k.GetLength(0); i++)
    {
        for (int j = 0; j < k.GetLength(1); j++)
        {
            k[i, j] = new Random().Next(0, 41);
            Console.Write($"{k[i, j]} , ");
        }
    }
}
Console.WriteLine();

Console.Write($"Введите позицию: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < arg.GetLength(0); i++)
{
    for (int j = 0; j < arg.GetLength(1); j++)
    {

        if (a > m && a > n)
        {
            check = false;
            break;
        }

    }
}
if (check) Console.WriteLine($"Такое числа нет - {a}");
else Console.WriteLine($"Такое число есть - {a}");





