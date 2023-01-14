/* Напишите программу, которая принмает число N и выдает произведение чисел от 1 до N.
4->24
5->120  */


Console.Clear();
int num = GetNumberFromUser("Введите целое число N: ","Ошибка Ввода!");
int ProductNumber = GetProductNumbers(num);
Console.WriteLine($"{num} -> {ProductNumber}");

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

int GetProductNumbers(int number)
{
    int mult = 1;
    for(int i = 1; i <= number; i++)
    {
        mult = mult * i;
    }
    return mult;
}