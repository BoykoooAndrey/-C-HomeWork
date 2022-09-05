// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
const int XCOORD = 0;
const int YCOORD = 1;
const int ZCOORD = 2;
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int[] InsertCoords()
{
    int[] temp = new int[3];
    temp[XCOORD] = Prompt("Введите х:");
    temp[YCOORD] = Prompt("Введите y:");
    temp[ZCOORD] = Prompt("Введите z:");
    return temp;
}
double Length(int[] firstCoord, int[] secondCoord)
{
     return Math.Sqrt(Math.Pow(firstCoord[XCOORD] - secondCoord[XCOORD], 2)
     + Math.Pow(firstCoord[YCOORD] - secondCoord[YCOORD], 2)
     + Math.Pow(firstCoord[ZCOORD] - secondCoord[ZCOORD], 2));
}
int[] Point1 = InsertCoords();
int[] Point2 = InsertCoords();
Length(Point1, Point2);
System.Console.WriteLine($"Длинна {Length(Point1,Point2):f2}");