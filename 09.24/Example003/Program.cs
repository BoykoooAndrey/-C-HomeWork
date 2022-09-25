// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] GenerateArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 5);
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
int[,] Composition(int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            resultArray[i, j] = (firstArray[i, firstArray.GetLength(0) - 2]
                              * secondArray[secondArray.GetLength(0) - 2, j])
                              + (firstArray[i, firstArray.GetLength(0) - 1]
                              * secondArray[secondArray.GetLength(0) - 1, j]);
        }
    }
    return resultArray;
}
int[,] firstMatrix = GenerateArray(2, 2);
int[,] secondMatrix = GenerateArray(2, 2);
PrintArray(firstMatrix);
System.Console.WriteLine();
PrintArray(secondMatrix);
System.Console.WriteLine();
int[,] resultArray = Composition(firstMatrix, secondMatrix);
PrintArray(resultArray);