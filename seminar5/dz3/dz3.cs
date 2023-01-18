/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();

double[] array = GetRandomArray(10, 100, 1000);
double maxDig = maxDigArr(array);
double minDig = minDigArr(array);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"{maxDig} - {minDig} -> {maxDig - minDig}");

double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    var rnd = new Random();
    for(int i =0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

double maxDigArr(double[] arr)
{
    double max = arr[0];
    for(int i = 0; i < arr.Length; i ++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double minDigArr(double[] arr)
{
    double min = arr[0];
    for(int i = 0; i < arr.Length; i ++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}