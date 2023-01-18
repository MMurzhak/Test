﻿//задайте массив из 12 элементов, заполненный случайными числами из промежутка[-9,9].Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

Console.Clear();
// I/O
Console.WriteLine("Выполняется создание массива.....");

//Logic
int[] array = GetRandomArray(12, -9, 10);
int sumPositives = GetSumPositives(array);
int sumNegatives = GetSumNegatives(array);

// I/O
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Сумма положительных чисел : {sumPositives}");
Console.WriteLine($"Сумма отрицательных чисел : {sumNegatives}");

 
 
int GetSumPositives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}
 
int GetSumNegatives(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum += (array[i] < 0) ? array[i] : 0; //тернарный оператор!!!!
    }
    return sum;
 } 

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for(int i =0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }
    return result;
}