//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int numbers = num / 10;
int result = numbers % 10;
Console.WriteLine(result);