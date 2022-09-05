// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите пятизначное число:");
int Palindrome(int number)
{
    int result = 0;
    if (number > 9999 && number < 100000)
    {
        int number1 = number / 10000;
        int number2 = number / 1000 % 10;
        int number4 = number / 10 % 10;
        int number5 = number % 10;
        if (number1 == number5 && number2 == number4)
        {
            result = 1;

        }
        else
        {
            result = 0;
        }

    }
    else
    {
        result = 2;
    }
    return result;
}
int result = Palindrome(number);
void Print(int result, int number)
{
    if (result == 0)
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
    if (result == 1)
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    if (result == 2)
    {
        System.Console.WriteLine($"Число {number} не пятизначное");
    }
}
Print(result, number);