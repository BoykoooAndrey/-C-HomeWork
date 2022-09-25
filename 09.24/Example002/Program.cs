// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] GenerateArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int[] SummRows(int[,] array)
{
    int[] SummRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SummRows[i] = SummRows[i] + array[i, j];
        }
    }
    return SummRows;
}
int FindMinSummRows(int[] array)
{
    int minNum = array[0];
    int indexMinNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (minNum > array[i])
        {
            minNum = array[i];
            indexMinNum = i;
        }
    }
    return indexMinNum + 1;
}
int[,] numbers = GenerateArray(4, 4);
PrintArray(numbers);
int[] summRows = SummRows(numbers);
int numberRow = FindMinSummRows(summRows);
System.Console.WriteLine($"В строке {numberRow} наименьшая сумма элементов.");