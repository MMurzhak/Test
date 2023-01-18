/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();

int[] array = GetRandomArray(10, 100, 1000);
int maxDig = maxDigArr(array);
int minDig = minDigArr(array);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"{maxDig} - {minDig} -> {maxDig - minDig}");

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

int maxDigArr(int[] arr)
{
    int max = arr[0];
    for(int i = 0; i < arr.Length; i ++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

int minDigArr(int[] arr)
{
    int min = arr[0];
    for(int i = 0; i < arr.Length; i ++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}