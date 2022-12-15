//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Укажите колличество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
ManyNambers(num);
Console.WriteLine($"Пользователь ввел {count} положительных чисел");
int ManyNambers(int k)
{
    for (int i = 1; i <= k; i++)
    {
        Console.Write($"Введите число {i}:  ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
        Console.WriteLine();
    }
    return count;
}