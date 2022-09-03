// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Prompt(string message)
{
    System.Console.Write(message);                      // Вывод приглашения
    string strValue = Console.ReadLine() ?? "0";        // Вводим строку с консоли (с консоли можно ввести только строку)
    int number = int.Parse(strValue);                   // Преобразование строки в целое число 
    int value = int.Parse(strValue[2].ToString());      // Сохранение третьей цифры из строчного выражения в переменную  
    if (number > 99)
    {
        System.Console.WriteLine(value);
    }
    else
    {
        System.Console.WriteLine("Третьей цифры в это числе нет!");
    }
}
Prompt("Введите  число:");