// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных)
// 8 1 2 4 4 5 3 1 -> 5
const int SIZE = 8;
int[] GenerateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 10);
    }
    return numbers;
}
int SecondMax(int[] numbers)
{
    int max = numbers[0];
    int secmax = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > secmax && numbers[i] != max)
        {
            secmax = numbers[i];
        }
        if (max == secmax)
        {
            secmax = numbers[i + 1];
        }
    }
    return secmax;
}
void PrintArray(int[] array, int secmax)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            System.Console.Write(array[i] + " -> " + secmax);
        }
        else
        {
            System.Console.Write(array[i] + " ");
        }
    }
    System.Console.WriteLine();
}
int[] numbers = GenerateArray(SIZE);
int secmax = SecondMax(numbers);
PrintArray(numbers, secmax);

