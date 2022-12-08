// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int rool = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int coole = Convert.ToInt32(Console.ReadLine());
int res=1;

Degree(rool, coole);
Console.WriteLine(res);


int Degree(int a, int b)
{
 for(int i=1; i<=b;i++)
 {
    res=res*a;
 }
 return res;
}