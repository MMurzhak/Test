// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до A
//4->10 (1+2+3+4=10)
//7->28

Console.Clear();
int num = GetNumberFromUser("Введите целое число А: ","Ошибка Ввода!");
int sumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {sumNumbers}");

//Выводит в консоль сообщение message,
//преобразовывыет введеную пользователем строку в число типа int.
//в случае ошибки выводит в консоль сообщение errorMessage

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
//возвращаем сумму чисел от 1 до number

int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum +=number;
        number--;
    }
    return sum;
}