﻿// Напишите программу, которая выводит на экран числа от 1 до 100. При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, то программа должна выводить слово FizzBuzz.

int num = new Random().Next(1,101);

if (num % 15 == 0) Console.WriteLine($"Сгенерировано случайное число {num} - FizzBuzz");
else if (num % 5 == 0) Console.WriteLine($"Сгенерировано случайное число {num} - Buzz");
else if (num % 3 ==0) Console.WriteLine($"Сгенерировано случайное число {num} - Fizz");
else Console.WriteLine($"Сгенерировано случайное число {num}");
