// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
const int ROW = 4;
const int COLUMN = 4;
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
void PrintArrayTwo(int[,] array)
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
double[] AverageRows(int[,] array)
{
    double[] average = new double[ROW];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i, j];
        }
        average[i] = (double)summ / array.GetLength(1);
    }
    return average;
}
void PrintArrayOne(double[] array)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            System.Console.Write(array[i]);
        }
        else
        {
            System.Console.Write(array[i] + "; ");
        }

    }
}
int[,] numbers = GenerateArray(ROW, COLUMN);
PrintArrayTwo(numbers);
double[] average = AverageRows(numbers);
PrintArrayOne(average);