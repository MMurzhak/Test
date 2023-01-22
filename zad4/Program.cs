/*Не используя рекурсию,выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N =5 -> 0 1 1 2 3
Если N =3 -> 0 1 1 
Если N =7 -> 0 1 1 2 3 5 8
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
GetNumberFibanacci(num);

int GetNumberFromUser(string message, string errorMessage)
{
     
        while(true)
        {
            Console.Write(message);
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if(isCorrect)
            {
                return userNumber;
            }
            else Console.WriteLine(errorMessage);
        }
    
}

void GetNumberFibanacci(int num)
{
    Console.Write($"0");
    int f1 = 0;
    int f2 = 1;
    int f = 0;
    for(int i = 0; i < num - 1; i++)
    {
        f = f1 + f2;
        f2 = f1;
        f1 = f;
        Console.Write($" {f}");
    }
}