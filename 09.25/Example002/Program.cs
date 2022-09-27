// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
int Summ(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    int sum = m + Summ(m + 1, n);
    return sum;
}
int m = Promt("Введите число M:");
int n = Promt("Введите число N:");
int summ = Summ(m, n);
System.Console.WriteLine(summ);