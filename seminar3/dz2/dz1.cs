/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.Clear();
int ax = 0 , ay = 0, az = 0, bx = 0, by = 0, bz = 0;
while(true)
{
    Console.WriteLine("Введите координаты для точки А ");
    try
    {
        Console.Write("x: ");
        ax = Convert.ToInt32(Console.ReadLine());
        Console.Write("y: ");
        ay = Convert.ToInt32(Console.ReadLine());
        Console.Write("z: ");
        az = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception exc)
    {
       Console.WriteLine($"Ошибка ввода! {exc.Message}"); 
    }

}
while(true)
{
    Console.WriteLine("Введите координаты для точки B: ");
    try
    {
        Console.Write("x: ");
        bx = Convert.ToInt32(Console.ReadLine());
        Console.Write("y: ");
        by = Convert.ToInt32(Console.ReadLine());
        Console.Write("z: ");
        bz = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch(Exception exc)
    {
       Console.WriteLine($"Ошибка ввода! {exc.Message}"); 
    }

}
double result = Math.Sqrt((Math.Pow((bx-ax), 2)) + (Math.Pow((by-ay), 2)) + (Math.Pow((bz-az), 2)));
result = Math.Round(result, 2);
Console.WriteLine($"точка А({ax},{ay},{az}) и точка B({bx},{by},{bz}) -->{result}");