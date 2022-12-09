// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц, 
//если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

int[] arg1 = new int[8];
int count =0;
int count1=0;
Zero(arg1);
One(arg1);

int [] Zero(int [] arg)
{
for (int i = 0; i < 8; i++)
{
    arg[i]= new Random().Next(0, 2);
    Console.WriteLine($"Элементы массива:  {arg[i]}");
}
return arg;
}

int [] One(int [] a)
{
for (int i = 0; i < 8; i++)
if(a[i]==0)
{
    count++;
}
else
{
    count1++;
}
if (count1>count)
{
   Console.WriteLine($"TRUE");
}
else
{
  Console.WriteLine($"False");
}
return arg1;
}