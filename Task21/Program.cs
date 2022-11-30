// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату X первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату D первой точки");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату D второй точки");
int d2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());

int G = x2 - x1;
int B = y2 - y1;
int O = d1 - d2;

double length = Math.Sqrt(G * G + B * B + O * O);
Console.WriteLine($"Длинна {length}");