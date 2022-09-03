// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int Prompt(string message)
{
    System.Console.Write(message);                 // Вывод приглашения
    string strValue = Console.ReadLine() ?? "0";  // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);             // Преобразование строки в целое число
    return value;
}
int number = Prompt("Введите число:");

if (number%2 == 0){
    System.Console.WriteLine($"{number} -> да");
    }
else
    {
    System.Console.WriteLine($"{number} -> нет");
    }
    
