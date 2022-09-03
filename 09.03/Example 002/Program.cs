// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int number = new Random().Next(99, 1000);
int number3 = number % 10;
int number1 = number / 100 % 10;
System.Console.WriteLine($"{number} -> {number1}{number3}");