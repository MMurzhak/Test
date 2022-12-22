//находит макс число из 2х рандомных чисел
var rnd = new Random();
int num = rnd.Next(10,100);

int a1 =num / 10;
int a2 =num % 10;
int max = a1;
if (max < a2) max = a2;

Console.WriteLine($"{num} {max}");