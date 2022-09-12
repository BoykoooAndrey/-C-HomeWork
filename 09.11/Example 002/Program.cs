// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int Summ(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summ = summ + array[i];
    }
    return summ;
}
void PrintResult(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ",");
    }
    System.Console.Write($"] -> {Summ(array)}");
    System.Console.WriteLine();
}
int size = Promt("Введите размер массива:");
int[] array = GenerateArray(size, MIN_VALUE, MAX_VALUE);
PrintResult(array);



