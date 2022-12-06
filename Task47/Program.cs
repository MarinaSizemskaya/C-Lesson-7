// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();

Write("Введите значение m: ");
int m = int.Parse(ReadLine());
Write("Введите значение n: ");
int n = int.Parse(ReadLine());

double[,] array= GetArray(m,n, -10, 10);
PrintArray(array);

double [,] GetArray(int rows, int columns, int min, int max)
{
    double[,] result = new double [rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            // result[i,j]=new Random().Next(-10, 10)+new Random().NextDouble();
            // result[i,j]=Math.Round(result[i,j], 1); - сократила код, соединив две строки в одну
            result[i,j]=Math.Round(new Random().Next(-10, 10)+new Random().NextDouble(), 1);
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}