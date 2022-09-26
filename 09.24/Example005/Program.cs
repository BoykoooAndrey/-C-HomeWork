// // Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] GenerateArray(int row, int column)
{
    int[,] array = new int[row, column];
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                int val = array[i, j].ToString("D").Length + 1;
                System.Console.Write(array[i, j].ToString("D" + val.ToString()) + " ");
            }
            else
            {
                System.Console.Write(array[i, j] + " ");
            }
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] numbers = GenerateArray(8, 8);
int number = 1;
void Completion(int row, int column)
{
    numbers[row, column] = number;
    number++;
    if ((column < numbers.GetLength(1) - 1))
    {
        if (numbers[row, column + 1] == 0 && (row == 0 || numbers[row - 1, column] != 0))
        {

            Completion(row, column + 1);
        }
    }
    if (row < numbers.GetLength(0) - 1)
    {
        if (numbers[row + 1, column] == 0 && (column == numbers.GetLength(1) - 1 || (numbers[row - 1, column] != 0
                                                                                    && numbers[row, column + 1] != 0)))
        {

            Completion(row + 1, column);
        }
    }
    if (column > 0)
    {
        if (numbers[row, column - 1] == 0 && (row == numbers.GetLength(0) - 1 || (numbers[row + 1, column] != 0
                                                                                && numbers[row, column + 1] != 0
                                                                                && numbers[row, column - 1] == 0)))
        {
            Completion(row, column - 1);
        }
    }
    if (row > 0)
    {
        if (numbers[row - 1, column] == 0 && (column == 0 || (numbers[row + 1, column] != 0
                                                            && numbers[row, column - 1] != 0
                                                            && numbers[row - 1, column] == 0)))
        {

            Completion(row - 1, column);
        }
    }
}
Completion(0, 0);
PrintArray(numbers);
