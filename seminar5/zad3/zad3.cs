/* Напишите программу замены элементов массива: положительные замените на 
отрцательные и наооборот
[-4,-8,8,2]->[4,8,-8,-2]*/
Console.Clear();
 
int[] array = GetRandomArray(4, -10, 10);
Console.WriteLine($"[{String.Join(",", array)}]");

changeArray(array);
Console.WriteLine($"[{String.Join(",", array)}]");


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

void changeArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i]=-arr[i];
    }
}