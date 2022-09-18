// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
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
int[] GenerateArray()
{
    System.Console.WriteLine("Для остановки введите 0");
    int size = 1;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        int number = Prompt($"Введите число {i + 1}:");
        if (0 > number || number > 0)
        {
            array[i] = number;
            size++;
            Array.Resize(ref array, size);
        }
        else
        {
            Array.Resize(ref array, size - 1);
            break;
        }
    }
    return array;

}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            System.Console.Write(array[i]);
        }
        else
        {
            System.Console.Write(array[i] + ",");
        }
    }
}
int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int[] numbers = GenerateArray();
PrintArray(numbers);
System.Console.WriteLine($" -> {Count(numbers)}");
