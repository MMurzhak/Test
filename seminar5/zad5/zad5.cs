/*задайте одномерный массив из 123 случайных чисел.Найдите количество элементов
массива, значения которых лежат в отрезке [10,99]
*/
Console.Clear();

int[] array = GetRandomArray(123, -100, 150);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.Write("Количество элементов из отрезка [10,99] ->");
Console.Write(countArray(array));

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
        if((arr[i] > 9) && (arr[i] < 100)) count++;
    }
    return count;
}
