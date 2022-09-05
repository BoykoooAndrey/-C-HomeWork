// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 121 -> да
// 2332 -> да
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число:");
int Check(int number)
{
    if (number < 0)
    {
        number = number * -1;
    }
    return number;
}
number = Check(number);
System.Console.WriteLine(number);
int Size(int number)
{
    int length = Convert.ToString(number).Length;
    return length;
}
int length = Size(number);
int[] Array(int number, int length)
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = number % 10;
        number = number / 10;
    }
    return numbers;
}
int[] numbers = Array(number, length);
bool Palindrome(int[] numbers)
{
    bool result = true;
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        if (numbers[i] == numbers[^(i + 1)])
            result = true;
        else
        {
            result = false;
            break;
        }
    }

    return result;
}
bool result = Palindrome(numbers);
void Print(bool result, int number)
{
    if (result == true)
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {number} не является палиндромом");
    }
}
Print(result, number);
