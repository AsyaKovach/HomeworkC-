// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Укажите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arg = new int[num];
int sum=0;
Massiv(arg);
SumNum(arg);
int [] Massiv(int[] a)
{
for (int i = 0; i <arg.Length; i++)
{
   a[i]= new Random().Next(-1000, 1000);
}
return a;
}
int SumNum(int[] b)
{
    for(int j=1; j<(b.Length/2); j=j+2)
    {
        sum=sum+b[j];
    }
    return sum;
}
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях {sum} ");