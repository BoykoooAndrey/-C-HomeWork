// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Summ(int number)
{
    int summ = 0;
    while (0 < number)
    {
        int figure = number % 10;
        summ = summ + figure;
        number = number / 10;
    }
    return summ;
}
int number = Prompt("Введите число:");
int result = Summ(number);
System.Console.WriteLine($"{number} -> {result}");