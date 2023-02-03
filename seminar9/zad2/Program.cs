/*Задача 65: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.Clear();

int M = GetNumberFromUser("Введите число M: ","Ошибка ввода!");
int N = GetNumberFromUser("Введите число N: ","Ошибка ввода!");

findSequence(M, N);
Console.Write(findSequence(M, N));

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

