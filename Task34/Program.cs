// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Write("Укажите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arg = new int[num];
int count=0;
Massiv(arg);
int [] Massiv(int[] a)
{
for (int i = 0; i <arg.Length; i++)
{
   a[i]= new Random().Next(100, 1000);
   if(a[i] % 2 ==0) count++;
}
return a;
}
Console.WriteLine($"В массиве {count}  четных числа ");