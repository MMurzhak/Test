/*Задача 53: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.*/

Console.Clear();

//Console.Write("Введите количество строк массива: ");
//int rows = int.Parse(Console.ReadLine() ?? "");
int rows = GetNumberFromUser("Введите количество строк массива: ","Ошибка ввода!");

//Console.Write("Введите количество столбцов массива: ");
//int columns = int.Parse(Console.ReadLine() ?? "");
int columns = GetNumberFromUser("Введите количество столбцов массива: ","Ошибка ввода!");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ChangeArray(array);
Console.WriteLine();
PrintArray(array);


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

void ChangeArray(int [,] inArray)
{
    for(int j = 0; j < inArray.GetLength(1); j++)
    {
        int ch = 0;
        ch = inArray[0,j];
        inArray[0,j] = inArray[inArray.GetLength(0)-1,j];
        inArray[inArray.GetLength(0)-1,j] = ch;
        //(inArray[0,j], inArray[inArray.GetLength(0)-1,j]) = (inArray[inArray.GetLength(0)-1,j], inArray[0,j]); Рабочий метод №2
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