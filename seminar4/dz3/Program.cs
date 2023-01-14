/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/


Console.Clear();

int[] arr = {1,2,3,4,5,6,7,8};

void printArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for(int i = 0; i < count; i++)
    {
        
        Console.Write($"{array[i]}");
        if(i < 7) Console.Write(",");
    }
    Console.Write("]");
    
}
printArray(arr);
