// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

using System;
using static System.Console;
Clear();

int m = new Random().Next(3, 10);
int n = new Random().Next(3,10);

int[,] array= GetArray(m,n, 0, 10);
PrintArray(array);
WriteLine();

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

int [,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j]=new Random().Next(min, max+1);
        }
    }
    return result;
}



for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{Math.Round(sum / m, 1)} ");
}
Console.ReadLine();