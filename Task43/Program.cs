//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
double k = 0;
double b = 0;

if ((k1 == k2) && (b1 == b2))
    Console.WriteLine($"Прямые совпадают");
else if (k1 == k2)
    Console.WriteLine($"Прямые параллельны");
else
{
    k = (b1 - b2) / (k2 - k1);
    b = k1 * k + b1;
    k = Math.Round(k, 3);
    b = Math.Round(b, 3);
    Console.WriteLine($"Пересечение в точке: ({k};{b})");
}
