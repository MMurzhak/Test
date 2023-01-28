﻿/*Решение в группах задач:
Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы на
их квадраты.
Например, изначально массив
выглядел вот так:
                                            Новый массив будет выглядеть
1 4 7 2
5 9 2 3                                            вот так:
8 4 2 4
                                                1 4 7 2
                                                5 81 2 9
                                                8 4 2 4*/
                                                

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ChangeArray(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ChangeArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if((i % 2 != 0) && (j % 2 != 0)) inArray[i,j] = inArray[i,j] * inArray[i,j];
        }
    }
}