// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);                 // Вывод приглашения
    string strValue = Console.ReadLine() ?? "0";  // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue);             // Преобразование строки в целое число
    return value;
}
int number = Prompt("Введите порядковый номер числа фибоначи:");
int fib1 = 1;
int fib2 = 1;
int fibn = 0;
for (int i = 2; i < number; i++)
{
    int fib3 = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib3;
    fibn = fib3;
}
System.Console.WriteLine($"{fibn}");