// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[] UniqueNumbersForArray(int row, int column, int size)
{
    int[] uniqueNumbers = new int[row * column * size];
    for (int i = 0; i < uniqueNumbers.Length; i++)
    {
        uniqueNumbers[i] = new Random().Next(0, 100);
    }
    int count = 0;
    for (int i = 0; i < uniqueNumbers.Length; i++)
    {
        for (int j = 0; j < uniqueNumbers.Length; j++)
        {
            if (uniqueNumbers[i] == uniqueNumbers[j] && i != j)
            {
                count++;
            }
        }
        if (count > 0)
        {
            uniqueNumbers[i] = new Random().Next(0, 100);
            i = 0;
            count = 0;
        }
    }
    return uniqueNumbers;
}
int[,,] GenerateArray(int row, int column, int size)
{
    int[] uniqueNumbers = UniqueNumbersForArray(row, column, size);
    int[,,] array = new int[row, column, size];
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                array[k, j, i] = uniqueNumbers[4 * i + 2 * j + k];
            }
        }
    }
    return array;
}
void PrintArrayThree(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                System.Console.Write($"{array[k, j, i]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
    System.Console.WriteLine();
}
int[,,] numbers = GenerateArray(2, 2, 2);
PrintArrayThree(numbers);