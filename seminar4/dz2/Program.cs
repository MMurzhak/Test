/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();

int num = GetNumberFromUser("Введите целое число: ","Ошибка Ввода!");
int digAmount = GetAmountNumbers(num);
Console.WriteLine($"{num} -> {digAmount}");

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

int GetAmountNumbers(int number)
{
    int result = 0;
    while(number > 0)
    {
        int a = number % 10;
        result +=a;
        number = number / 10;
    }
    return result;
}