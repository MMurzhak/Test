/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.Clear();
int num;
while(true)
{
Console.Write("Введите пятизначное число : ");
try
    {
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception exc)
    {
       Console.WriteLine($"Ошибка ввода! {exc.Message}"); 
    }
}
int num1 = num / 10000;
int num5 = num % 10;
int num2 = num / 1000 % 10;
int num4 = num % 100 /10;
if(num1 != num5)  
{
    Console.WriteLine($"число {num} не является палиндромом");
}
else 
{    
    if (num2 != num4) 
    {
        Console.WriteLine($"число {num} не является палиндромом");
    }
    else
    {
        Console.WriteLine($"число {num} является палиндромом");
    }
}