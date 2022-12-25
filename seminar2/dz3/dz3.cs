/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if((number == 6) || (number == 7)) Console.WriteLine("Выходной день");
    else if((number >0) && (number < 6)) Console.WriteLine("Увы, рабочий день");
        else Console.WriteLine("не корректная дата");