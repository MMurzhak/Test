/*Напишите программу, которая принимает на вход три числа и проверяет, может ли
существовать треугольник с сторонами так длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.Clear();

int[] array = new int[3];

FillArray(array);
bool result = CheckArray(array);
Console.WriteLine($"Треугольник со сторонами заданной длины существует: {(result ? "да" : "нет")}");

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

bool CheckArray(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    int size = arr.Length;
    if(((arr[0] + arr[1]) > arr[2]) && ((arr[1] + arr[2]) > arr[0]) && ((arr[2] + arr[0]) > arr[1])) return true;
    else return false;
}