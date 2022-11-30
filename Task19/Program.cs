// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);

void CheckPalindromicNumber(int number)
{
    if (number >= 10000)
    {
        int num1 = (number / 10000) % 10;
        int reg1 = number % 10;

        if (num1 == reg1)
        {
            number = number / 10;
            int num2 = (number / 100) % 10;
            int reg2 = number % 10;
            if (num2 == reg2)
            {
                Console.WriteLine("Является полиндромом");
            }
        }
        else
            Console.WriteLine("Не является полиндромом");
    }
}