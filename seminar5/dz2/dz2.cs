/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму Элементов, стоящих на не четных позициях.
*/

Console.Clear();

int[] array = GetRandomArray(6, 1, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на не четных позициях массива -> {SumArray(array)}");


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

int SumArray(int[] arr)
{
    int sum=0;
    for(int i = 0; i < arr.Length; i += 2)
    {
        if(i % 2 == 0) sum += arr[i];
    }
    return sum;
}