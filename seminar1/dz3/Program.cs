//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите целое число: ");

int numberA = int.Parse(Console.ReadLine() ?? "");

if (numberA % 2 ==0) Console.Write($"{numberA} четное число" );
else Console.Write($"{numberA} нечетное число" );