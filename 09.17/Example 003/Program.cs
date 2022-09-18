// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
int Prompt(string message)
{
    Console.Write(message);
    bool isDigit = int.TryParse(Console.ReadLine(), out int number);
    if (isDigit)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
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
int MaxSummRow(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
        summ = summ + max;

    }
    return summ;
}
int MinSummColumn(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int min = array[0,i];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            
            if (array[j, i] < min)
            {
                min = array[j, i];
            }
            
        }
        summ = summ + min;
    }
    return summ;
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
int row = Prompt("Введите количество строк: ");
int column = Prompt("Введите количество столбцов: ");
int[,] matrix = GenerateArray(row, column);
PrintArray(matrix);
System.Console.WriteLine(MaxSummRow(matrix));
System.Console.WriteLine(MinSummColumn(matrix));
System.Console.WriteLine(MaxSummRow(matrix) - MinSummColumn(matrix));
