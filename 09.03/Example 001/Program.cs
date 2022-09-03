// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}
int number = Prompt("Введите трехзначное число:");
if (number > 99 && number < 1000)
{
    int result = (number / 10) % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число!");
}

