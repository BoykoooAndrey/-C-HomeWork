// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}
int number = Prompt("Введите номер дня недели:");
if (number > 0 && number < 8)
{
    string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    string day = days[number - 1];
    if (number > 5 && number < 8)
    {
        System.Console.WriteLine($"День недели под номером {number} это {day}, и это выходной!");
    }
    else
    {
        System.Console.WriteLine($"День недели под номером {number} это {day}");
    }
}
else
{
    System.Console.WriteLine("Дня под таким номером нет.");
}
