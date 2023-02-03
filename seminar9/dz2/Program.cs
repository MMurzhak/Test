/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

int M = GetNumberFromUser("Введите число M: ","Ошибка ввода!");
int N = GetNumberFromUser("Введите число N: ","Ошибка ввода!");

find(M, N);
Console.Write($"M={M}; N={N} -> ");
Console.Write(find(M, N));

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

int find(int start, int end)
{
    int sum = 0;
    if (start == end) return end;
    else return sum = start + find(start + 1, end);  
    
}
