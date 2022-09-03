// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int Prompt(string message)
{
    System.Console.Write(message);                 // Вывод приглашения
    string strValue = Console.ReadLine() ?? "0";  // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);             // Преобразование строки в целое число
    return value;
}
int number = Prompt("Введите последнее число последовательности:");
int i = 1;
System.Console.Write($"{number} -> ");

while (i < number+1)
{
if (i%2 == 0)
        {
        System.Console.Write($"{i}, ");
        i = i +1;
        }
else
    {
    i = i +1;
    }
}