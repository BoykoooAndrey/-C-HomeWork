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
int[,] numbers = GenerateArray(4, 4);
int number = 1;
void Completion(int row, int column)
{
    if ((row < numbers.GetLength(0) && column < numbers.GetLength(1)) && (row >= 0 && column >= 0))
    {
        if (numbers[row, column] == 0)
        {
            if (number < numbers.GetLength(1))
            {
                numbers[row, column] = number;
                number++;
                Completion(row, column + 1);
            }
            if (numbers.GetLength(1) - 1 < number && number < 2 * numbers.GetLength(0) - 1)
            {
                numbers[row, column] = number;
                number++;
                Completion(row + 1, column);
            }
            if (6 < number && number < 10)
            {
                numbers[row, column] = number;
                number++;
                Completion(row, column - 1);
            }
            if (9 < number && number < 12)
            {
                numbers[row, column] = number;
                number++;
                Completion(row - 1, column);
            }
            if (11 < number && number < 14)
            {
                numbers[row, column] = number;
                number++;
                Completion(row, column + 1);
            }
            if (13 < number && number < 15)
            {
                numbers[row, column] = number;
                number++;
                Completion(row + 1, column);
            }
            if (14 < number && number < 16)
            {
                numbers[row, column] = number;
                number++;
                Completion(row, column - 1);
            }
            if (15 < number && number < 17)
            {
                numbers[row, column] = number;
                number++;
                Completion(row, column);
            }
        }
    }
}
Completion(0, 0);
PrintArray(numbers);
