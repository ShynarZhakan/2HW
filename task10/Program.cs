// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>=100 && num<1000)
{
    int x1 = num / 100;
    int x2 = (num % 100) / 10;
    int x3 = num % 10;
    Console.WriteLine($"Вторая цифра вашего числа равно {x2}");
}
else Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку.");

