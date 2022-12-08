// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
Console.Write($"Размерность массива:  ");
int num = Convert.ToInt32(Console.ReadLine());
int size =8;
int [] array = new int[size];

Massiv(num);

int Massiv(int arg)
{
for (int i = 0; i < 8; i++)
{
   arg= new Random().Next(1, 11);
   Console.Write($"{arg} ");
}
return arg;
}
