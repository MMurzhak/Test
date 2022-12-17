// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите целое число: ");
string userInputA = Console.ReadLine() ?? "";
int numberA = int.Parse(userInputA);

Console.Write("Введите целое число: ");
string userInputB = Console.ReadLine() ?? "";
int numberB = int.Parse(userInputB);

if (numberA > numberB) Console.Write($"{numberA} большее число");
    else Console.Write($"{numberB} большее число");