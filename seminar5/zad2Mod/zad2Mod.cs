Console.Clear();
// I/O
Console.WriteLine("Выполняется создание массива.....");

//Logic
MainLogic(out int[] array, out int sumPositives, out int sumNegatives);

// I/O
MainOutPut();

void MainLogic(out int[] array, out int sumPositives, out int sumNegatives)
{
    array = GetRandomArray(12, -9, 10);
    sumPositives = GetSumPositives(array);
    sumNegatives = GetSumNegatives(array);
}

void MainOutPut()
{
    Console.WriteLine($"[{String.Join(",", array)}]");
    Console.WriteLine($"Сумма положительных чисел : {sumPositives}");
    Console.WriteLine($"Сумма отрицательных чисел : {sumNegatives}");
}

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