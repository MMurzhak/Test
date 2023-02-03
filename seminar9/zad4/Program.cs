/*Задача 69: Напишите программу, которая на вход принимает два
числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.Clear();

int numA = GetNumberFromUser("Введите число A: ","Ошибка ввода!");
int numB = GetNumberFromUser("Введите число B: ","Ошибка ввода!");
findSequence(numA,numB);
Console.Write(findSequence(numA,numB));

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

int findSequence(int numberA, int numberB)
{
    if (numberB == 1) return numberA;
    else return numberA * findSequence(numberA,numberB - 1);  
    
}