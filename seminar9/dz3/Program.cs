/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

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

int find(int numM, int numN)
{
  if (numM == 0) return numN + 1;
  else if (numN == 0) return find(numM - 1, 1);
  else return find(numM - 1, find(numM, numN - 1));
}