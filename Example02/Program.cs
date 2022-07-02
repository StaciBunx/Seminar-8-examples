// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя

using System;
using static System.Console;
Clear();

int[,] array = new int[3, 3];
FillArray(array);
PrintArray(array);
WriteLine();
if (array.GetLength(0) == array.GetLength(1))
{
    PrintArray(Change(array));
}
else WriteLine("Ошибка");


int[,] Change(int[,] newArr)
{
    int[,] result = new int[newArr.GetLength(0), newArr.GetLength(0)];

    for (int i = 0; i < newArr.GetLength(0); i++)
    {
        for (int j = 0; j < newArr.GetLength(1); j++)
        {
            result[j, i] = newArr[i, j];
        }
    }
    return result;
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
