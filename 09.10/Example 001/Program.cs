// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Square(int num1, int num2)
{
    int degree = 1;
    for (int i = 0; i < num2; i++)
    {
        degree = degree * num1;
    }
    return degree;
}
void PrintResult (int result)
{
    System.Console.WriteLine(result);
}
int val1 = Prompt("Введите число A:");
int val2 = Prompt("Введите число B:");
int result = Square(val1, val2);
PrintResult(result);