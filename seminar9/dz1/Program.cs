/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();

int N = GetNumberFromUser("Введите число N: ","Ошибка ввода!");
Console.Write($"N = {N} ->");
find(N);


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

void find(int num)
{
    Console.Write($" {num} ");
    if (num == 1) return;
    else find(num - 1);    
}
