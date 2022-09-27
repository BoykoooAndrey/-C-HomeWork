// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int firstNum = Promt("Введите число N:");
Numbers(firstNum);
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
void Numbers(int n)
{
    if (n == firstNum)
    {
        System.Console.Write($"N = {n} -> '{n},");
        Numbers(n - 1);
    }
    if (n == 1)
    {
        System.Console.Write($" {n}'");
    }
    if (n != 1 && n != firstNum)
    {
        System.Console.Write($" {n},");
        Numbers(n - 1);
    }


}
