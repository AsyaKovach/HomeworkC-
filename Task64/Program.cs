// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" N={N} -> {Posled(N)}");

string Posled(int N)
{
    if (N == 1) return Convert.ToString(N);
    else return Convert.ToString(N) + ", " + Posled(N - 1);
}