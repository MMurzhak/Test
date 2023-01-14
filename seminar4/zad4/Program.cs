/* Напишите программуЮ которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
[1,0,1,1,0,1,0,0]
*/

Console.Clear();
printArray();
void printArray()
{
    Console.Write("[");
    for (int i = 0; i < 7; i++)
    {
        Console.Write($"{new Random().Next(0,2)}, ");
    }
    Console.Write($"{new Random().Next(0,2)}");
    Console.Write("]");

}