// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int A(int m, int n)
{
    int summ = 0;
    
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        summ = A(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        summ =  A(m - 1, A(m, n - 1));
    }
    return summ;

}
int result = A(3, 3);
System.Console.WriteLine(result);