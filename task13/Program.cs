// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

List<int> list = new List<int>();
        Console.WriteLine("Введите число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        while (n > 0) {
            int res = n % 10;
            n = n / 10;
            list.Add(res);
        }
        int[] terms = list.ToArray();
        Array.Reverse(terms);
        if(2 < terms.Length) {
            Console.WriteLine(terms[2]);
        } else {
            Console.WriteLine("Третьей цифры числа нет");
        }
