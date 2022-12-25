/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.Clear();
Console.Write("Введите трехзначное число число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;

    if ((number > 100) && (number <1000)) result = number /10 %10;
        else Console.WriteLine("Не корректное число");

Console.WriteLine("Вторая цифра числа " + result);