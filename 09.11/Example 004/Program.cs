// Заполнить массив четной длины таким образом, чтобы значение элемента массива повторялось ровно 2 раза.
// 1,1,2,3,3,2,4,5,4,5
// 1,1,2,2,4,4,5,5
// 1,2,3,3,2,1
const int MIN_VALUE = 0;
const int MAX_VALUE = 10;
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] GenerateArray(int size, int minval, int maxval)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minval, maxval);
    }
    for (int i = 0; i < array.Length;)
    {
        int count = 0;
        int number = array[i];
        for (int j = 0; j < array.Length; j++)
        {
            if (number == array[j])
            {
                count++;
            }
        }
        if (count < 2 || count > 2)
        {
            array[i] = new Random().Next(minval, maxval);

        }
        else
        {
            i++;
        }
    }
    return array;
}
void PrintResult(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ",");
    }
    System.Console.WriteLine();
}
int size = Promt("Введите размер массива:");
int[] array = GenerateArray(size, MIN_VALUE, MAX_VALUE);
PrintResult(array);