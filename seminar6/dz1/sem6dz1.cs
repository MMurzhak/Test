/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();

int[] array = new int[GetNumberFromUser()];

FillArray(array);
int result = CheckPositiveArray(array);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Чисел больше 0: {result}");

int GetNumberFromUser()
{
     
        while(true)
        {
            Console.Write($"Введите число: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if(isCorrect)
            {
                return num;
               
            }
            else Console.WriteLine("Ошибка ввода! ");
        }
    
}

void FillArray(int[] collection)
{
    int lengthArray = collection.Length;
    for(int i = 0; i < lengthArray; i++)
    {
        while(true)
        {
            Console.Write($"Введите {i}-й элемент массива: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if(isCorrect)
            {
                collection[i] = num;
                break;
            }
            else Console.WriteLine("Ошибка ввода! ");
        }
    }
}

int CheckPositiveArray(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count ++;
    }
    return count;
}

