// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
const int ROW = 4;
const int COLUMN = 4;
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
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
int[] Position()
{
    int[] position = new int[2] { Promt("Введите номер строки:"), Promt("Введите номер столбца:") };
    return position;
}
void FindNumber(int[,] array, int[] position)
{
    if (position[0] <= array.GetLength(0) && position[1] <= array.GetLength(1))
    {
        System.Console.WriteLine(array[position[0] - 1, position[1] - 1]);
    }
    else
    {
        System.Console.WriteLine($"{position[0]},{position[1]} -> такого числа в массиве нет");
    }
}
int[,] numbers = GenerateArray(ROW, COLUMN);
PrintArray(numbers);
int[] position = Position();
FindNumber(numbers, position);