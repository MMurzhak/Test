/*Задайте массив.Напишите программу, которая определяет 
присутсвует ли заданное число в массиве.
*/

Console.Clear();

int[] array = GetRandomArray(5, -10, 10);
Console.WriteLine($"[{String.Join(",", array)}]");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) 
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

bool check(int x, int[] arr)
{
    int i=0;
    bool f=false;
    while((f==false) & (i < arr.Length))
    {
        if(x == arr[i]) f = true;
        i++;
    }
    return f;
}
int n = GetNumberFromUser($"Введите число: ","Ошибка ввода!");
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



if (check(n, array)) Console.WriteLine("да");
    else
    {
        Console.WriteLine("нет");
    }