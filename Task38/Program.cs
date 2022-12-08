// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Укажите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double[] arg = new double[num];
Massiv(arg);
double min=arg[0];
double max=arg[0];
for (int i = 0; i <arg.Length; i++)
{
    if (arg[i]>max) max=arg[i];
    else if (arg[i]<min) min=arg[i];
}
Console.WriteLine($"Разница между максимумом {Math.Round (max,2)} и минимумом {Math.Round (min,2)} равна {Math.Round ((max-min),2)}");
double[] Massiv(double[] a)
{
for (int i = 0; i <arg.Length; i++)
{
   a[i]= new Random().NextDouble();
}
return a;
}
