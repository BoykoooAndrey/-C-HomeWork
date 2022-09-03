// Задача 5 *: Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет, кратны ли эти числа предварительно 
// введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет
// 15 -> нет
// 12 -> да
int Prompt(string message)
{
    System.Console.Write(message);        // Вывод приглашения
    string strValue;                      // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);      // Преобразование строки в целое число
    return value;
}
int divider = Prompt("Введите делитель для проверки кратности:");
while (true)
{
    int number = new Random().Next(1, 1000);
    if (number% divider == 0)
    {
        System.Console.WriteLine($"{number} -> да");
        break;
    }
    else
    {
        System.Console.WriteLine($"{number} -> нет");
    }
}