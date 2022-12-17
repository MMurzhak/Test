// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите целое число: ");
int numberA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число: ");
int numberB = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число: ");
int numberC = int.Parse(Console.ReadLine() ?? "");

if (numberA > numberB)
     if (numberA > numberC) Console.Write($"{numberA}");
     else Console.Write($"{numberC}");
else if (numberB > numberC) Console.Write($"{numberB}");
         else Console.Write($"{numberC}");
