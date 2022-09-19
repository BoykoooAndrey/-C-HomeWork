// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
const int MINVAL = -10;
const int MAXVAL = 10;
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
double[,] GenerateArray(int row, int column, int minVal, int maxVal)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minVal, maxVal) + Math.Round(rnd.NextDouble(), 1, MidpointRounding.AwayFromZero);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int row = Promt("Введите количество строк:");
int column = Promt("Введите количество столбцов:");
double[,] numbers = GenerateArray(row, column, MINVAL, MAXVAL);
PrintArray(numbers);