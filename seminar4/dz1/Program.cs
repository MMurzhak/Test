/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();

int numA = GetNumberA("Введите целое число: ","Ошибка Ввода!");
int numB = GetNumberB("Введите целое число: ","Ошибка Ввода!");
int degAB = DegreeAB(numA);

Console.Write($"{numA} {numB} -> {degAB}");
int GetNumberA(string message, string errorMessage)
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
int GetNumberB(string message, string errorMessage)
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

int DegreeAB(int number)
{
    int result = 1;
    for(int i = 1; i <=numB; i++)
    {
        result = result * numA;
    }
    return result;
}