// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер недели");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1: Console.WriteLine("Понедельник-рабочий день");
    break;
    case 2: Console.WriteLine("Вторник-рабочий день");
    break;
    case 3: Console.WriteLine("Среда-рабочий день");
    break;
    case 4: Console.WriteLine("Четверг-рабочий день");
    break;
    case 5: Console.WriteLine("Пятница-рабочий день");
    break;
    case 6: Console.WriteLine("ПСуббота-наконе-то выходной день");
    break;
    case 7: Console.WriteLine("Понедельник-наконе-то выходной день");
    break;
    default: Console.WriteLine("Кому-то пора в отпуск");
    break;
}
