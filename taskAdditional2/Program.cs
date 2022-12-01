Console.WriteLine("Сколько программистов?");
int number = Convert.ToInt32(Console.ReadLine());
string x1 = Convert.ToString("программист");
string x2 = Convert.ToString("а");
string x3 = Convert.ToString("ов");

if (number % 10 == 0 || number % 10 == 5 || number % 10 == 6 || number % 10 == 7 || number % 10 == 8 || number % 10 == 9)
{
    Console.WriteLine($"{number} {x1}{x3}");
}

else if ( number % 100 == 11 || number % 100 == 12 || number % 100 == 13 || number % 100 == 14)
{
    Console.WriteLine($"{number} {x1}{x3}");
}

else if (number % 10 == 2 || number % 10 == 3 || number % 10 == 4)
{
    Console.WriteLine($"{number} {x1}{x2}");
}

else if (number % 10 == 1)
{
    Console.WriteLine($"{number} {x1}");
}

