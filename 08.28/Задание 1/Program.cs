// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int Prompt(string message)
{
    System.Console.Write(message);                 // Вывод приглашения
    string strValue = Console.ReadLine() ?? "0";  // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);             // Преобразование строки в целое число
    return value;
}
int val1 = Prompt("Введите первое число:");
int val2 = Prompt("Введите второе число:");

if (val1 < val2)
    {
    System.Console.WriteLine($"Первое число {val1} меньше второго {val2}");
    }
else
    {        
    System.Console.WriteLine($"Перsвое число {val1} больше второго {val2}");
    }    
