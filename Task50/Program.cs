// Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();

int[,] array = new int [3, 4]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

PrintArray(array);
WriteLine();
Write("Введите число: ");
int m = int.Parse(ReadLine());
int indexI = -1;
int indexJ = -1;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if(m==array[i,j]) 
        {
            indexI = i;
            indexJ = j; 
             
        }
       
    }

}
if(indexI==-1 && indexJ==-1)
{
    WriteLine("Такого числа в массиве нет");
}
else
{
    WriteLine($"Индексы числа в массиве {indexI}, {indexJ}");
    
}

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



