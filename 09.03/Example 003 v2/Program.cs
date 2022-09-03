// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}
int number = Prompt("Введите число от 100 до 100000:");
if (number > 99 && number < 1000)
{
    int result = number % 10;
    System.Console.WriteLine(result);
}
if (number > 999 && number < 10000)
{
    int result = number / 10 % 10;
    System.Console.WriteLine(result);
}
if (number > 9999 && number < 100000)
{
    int result = number / 100 % 10;
    System.Console.WriteLine(result);
}
else
{
    if (number < 99)
    {
        System.Console.WriteLine("Число либо меньше 100, третьей цифры нет.");
    }
    else
    {
        System.Console.WriteLine("Число больше 100000");
    }
}