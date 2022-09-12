// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
const int MIN_VALUE = 0;
const int MAX_VALUE = 1000;
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size, int minval, int maxval)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minval, maxval);
    }
    return numbers;
}
int Result(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void PrintResult(int[] numbers, int result)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + ",");
    }
    System.Console.Write($"] -> {result}");
}
int size = Promt("Введите размер массива:");
int[] numbers = GenerateArray(size, MIN_VALUE, MAX_VALUE);
int result = Result(numbers);
PrintResult(numbers, result);