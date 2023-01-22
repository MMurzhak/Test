/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45->101101
3->11
2->10
*/

Console.Clear();
Console.WriteLine($" -> {Decimal()}");

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

string Decimal()
{
    int num = GetNumberFromUser();
    string result = String.Empty;
    if(num == 0) return "0";
    while(num > 0)
    {
        result =(num % 2).ToString() + result;
        num = num / 2;
    }
    return result;
}