/*Задача 67: Напишите программу, которая будет принимать на вход
число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/

Console.Clear();

int num = GetNumberFromUser("Введите число : ","Ошибка ввода!");
findSequence(num);
Console.Write(findSequence(num));

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

int findSequence(int number)
{
    if (number == 0) return 0;
    else return number % 10 + findSequence(number / 10);  
    
}

