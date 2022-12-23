// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int num1 = 2;
int num2 = 2;
int num3 = 2;
int[,,] arg3 = new int[num1, num2, num3];
int maxRandom = 9;
int[] argShuffle = new int[maxRandom];
FillArray(arg3, Shuffle(argShuffle));

int[,,] FillArray(int[,,] k, int[] v)
{
    Console.WriteLine();
    for (int i = 0; i < k.GetLength(0); i++)
    {
        for (int j = 0; j < k.GetLength(1); j++)
        {
            for (int b = 0; b < k.GetLength(1); b++)
            {
                k[i, j, b] = v[j];
                int temp = v[j];
                v[j] = v[v.Length - 1];
                v[v.Length - 1] = temp;
                Array.Resize(ref v, v.Length - 1);
                Console.Write($"{k[i, j, b]} {(i, j, b)} ");
            }
        }
        Console.WriteLine();
    }
    return k;
}

int[] Shuffle(int[] a)
{
    for (int i = 0; i < maxRandom; i++)
    {
        a[i] = i;
        Console.Write($"{a[i]} ");
    }
    return a;
}