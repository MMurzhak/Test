/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.   x=(b2-b1)/(k1-k2);
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();

double[] array = new double[4];
FillArray(array);

double xy1 = CheckXY(array);
double xy2 = CheckXY(array);
Console.Write($"[{String.Join(",", array)}] ->");

Console.Write($"({String.Join(",", xy1)})");
Console.Write($"({String.Join(",", xy2)})");


void FillArray(double[] collection)
{
    int lengthArray = collection.Length;
    for(int i = 0; i < lengthArray; i++)
    {
        while(true)
        {
            Console.Write($"Введите {i+1}-ю координату точки: ");
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

double CheckXY(double[] arr)
{
    double x = (arr[2]-arr[0])/(arr[1]-arr[3]);   
    double y = arr[1] * x + arr[0];                           
    return y;   
}

