/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
int n;
while(true)
{
Console.Write("Введите число N: ");
try
    {
        n = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception exc)
    {
       Console.WriteLine($"Ошибка ввода! {exc.Message}"); 
    }
}
for(int i = 1; i <= n ; i++)
{
    Console.Write($"{i * i * i}\t");
}
