/*Задайте массив заполненный случайными положительными трехзначными числами.
Напишите программу, которая покажет количество четных чисел в массиве.
*/

Console.Clear();

int[] array = GetRandomArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.Write($"Количество положительных элементов массива -> {countArray(array)}");


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for(int i =0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

int countArray(int[] arr)
{
    int count=0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0) count++;
    }
    return count;
}