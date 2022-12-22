/*Напишите программу, которая будет
принимать на вход два числа и выводить,
является ли второе число кратным первому.
Если число 2 не кратно числу 1, то программа
выводит остаток от деление.*/
int ReadNum()
{
    int ResNumb;
    while(true)
    {
        Console.Write("Введите число:");

        if (int.TryParse(Console.ReadLine(), out ResNumb))
            break;
            Console.WriteLine("Error");
    }
    return ResNumb;
}

/*
int FirstNumber;
while(true)
{
    Console.Write("Введите первое число:");
    if(int.TryParse(Console.ReadLine(), out FirstNumber))
    break;
    Console.WriteLine("error");
}

int SecondNumber;
while(true)
{
    Console.Write("Введите второе число:");
    if(int.TryParse(Console.ReadLine(), out SecondNumber))
    break;
    Console.WriteLine("error");
}
*/
int FirstNumber = ReadNum();
int SecondNumber = ReadNum();

int ost = FirstNumber % SecondNumber;

if (ost ==0) Console.WriteLine($"{FirstNumber}, {SecondNumber} -> кратно");
else Console.WriteLine($"{FirstNumber}, {SecondNumber} -> не кратно кратно, остаток {ost}");