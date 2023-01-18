/*Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний Элемент массива, второй и предпоследний и т.д.
Результат запишите в новом массиве.
*/
Console.Clear();

int[] array = GetRandomArray(9, -10, 10);
Console.WriteLine($"[{String.Join(",", array)}]");

int [] array2 = changeArray(array);
Console.WriteLine($"[{String.Join(",", array2)}]");

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

int[] changeArray(int[] arr)
{
    int size = 0;
    if(arr.Length % 2 == 1) size=arr.Length / 2+1;
    else size = arr.Length/2;
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        if((arr.Length%2==1) && (i==size-1)) result[i]=arr[i];
        else result[i] = arr[i]*arr[arr.Length-i-1];
    }
    return result;
}