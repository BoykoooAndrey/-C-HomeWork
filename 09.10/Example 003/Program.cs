// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 100);
    }
    return numbers;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            System.Console.Write(array[i]+ " -> ");
        }
        else
        {
            System.Console.Write(array[i] + ",");
        }
    }
}
void PrintArrayV2(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            System.Console.Write(array[i]+ "]");
        }
        else
        {
            System.Console.Write(array[i] + ",");
        }
    }
}
int size = Promt("Введите размер массива");
int[] array = GenerateArray(size);
PrintArray(array);
PrintArrayV2(array);
