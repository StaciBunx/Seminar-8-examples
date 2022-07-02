//Задача 53: Задайте двумерный массив.
//Напишите программу, которая поменяет местами первую
//и последнюю строку массива.

using System;
using static System.Console;
Clear();

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
WriteLine();
ExChange(array);
PrintArray(array);

void ExChange(int[,] newArr)
{
    int temp = 0;
    for (int i = 0; i < newArr.GetLength(1); i++)
    {
        temp = newArr [0,i];
        newArr [0,i] = newArr[newArr.GetLength(0)-1,i];
        newArr[newArr.GetLength(0)-1,i] = temp; 
    }
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Write($"{newArray[i, j]} ");
        }
        WriteLine();
    }
}

void FillArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(0, 10);
        }
    }
}
