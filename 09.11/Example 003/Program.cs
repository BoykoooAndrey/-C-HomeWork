// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
const int MIN_VALUE = 0;
const int MAX_VALUE = 20;
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size, int minval, int maxval)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minval, maxval);
    }
    return array;
}
int Difference(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    int dif = max - min;
    return dif;
}
void PrintResult(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ",");
    }
    System.Console.Write($"] -> {Difference(array)}");
    System.Console.WriteLine();
}
int size = Promt("Введите размер массива:");
int[] array = GenerateArray(size, MIN_VALUE, MAX_VALUE);
PrintResult(array);


