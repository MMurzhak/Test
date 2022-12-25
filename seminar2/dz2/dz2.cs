/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();
/*Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");*/
int number;
int result = 0;
while(true)
{
    Console.Write("Введите первое число:");
    if(int.TryParse(Console.ReadLine(), out number))
    break;
    Console.WriteLine("error");
}    
if (number < 100) Console.WriteLine("Третьего числа нет");
else
{
    while(true)
    {
        if (number < 999) result = number %10;
        else 
            {
                if (number < 9999) result = number /10 %10;
                else if (number < 99999) result = number /10 /10 %10;
            }
        Console.WriteLine("Третья цифра числа " + result);
        break;
    }
}
