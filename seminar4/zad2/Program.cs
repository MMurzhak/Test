// напишите программу, которая принимает на вход число и выдает количество цифр в числе. 456->3  78->2

Console.Clear();
int num = GetNumberFromUser("Введите целое число А: ","Ошибка Ввода!");
int digNumber = GetDigitNumbers(num);
Console.WriteLine($"{num} -> {digNumber}");

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

int GetDigitNumbers(int number)
{
    int result = 0;
    while(number > 0)
    {
        number = number / 10;
        result ++;
    }
    return result;
}