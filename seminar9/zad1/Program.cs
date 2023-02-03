﻿/*Задача 63: Задайте значение N. Напишите программу, которая
выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"*/

Console.Clear();

int N = GetNumberFromUser("Введите число N: ","Ошибка ввода!");
findSequence(1, N);
Console.Write(findSequence(1, N));

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

string findSequence(int start, int end)
{
    if (start == end) return end.ToString();
    else return start + " " + findSequence(start + 1, end);  
    
}
