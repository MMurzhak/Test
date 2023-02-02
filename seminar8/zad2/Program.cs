/*Задача 55: Задайте двумерный массив. Напишите
программу, которая заменяет строки на столбцы. В
случае, если это невозможно, программа должна
вывести сообщение для пользователя.*/
Console.Clear();


int rows = GetNumberFromUser("Введите количество строк массива: ","Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ","Ошибка ввода!");

int[,] array = GetArray(rows, columns, 0, 10);
ChangeArray(array);
int[,] ChArray = ChangeArray(array);

PrintArray(array);
Console.WriteLine();
PrintChangeArray(ChArray);


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


int[,] ChangeArray(int [,] inArray)
{
    int[,] result = new int[inArray.GetLength(1),inArray.GetLength(0)];
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            result[j,i]=inArray[i,j]; 
        }
    }
    return result;
}

void PrintChangeArray(int[,] inArray)
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
