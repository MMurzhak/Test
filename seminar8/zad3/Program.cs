/*Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.*/

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ","Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ","Ошибка ввода!");

int[,] array = GetArray(rows, columns, 0, 10);
//int[] countArray = countArr(array);
PrintArray(array);
PrintResult(array);

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

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int countElement(int num,int[,] array)
{
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(num == array[i,j]) result++;
        }
    }
    return result;
}

void PrintResult(int[,] array)
{
    for(int i = 0; i < 11; i++)
    {
        int num = countElement(i, array);
        if(num !=0)
        Console.WriteLine($"{i} встречается {num} раз(а)");
    }
}