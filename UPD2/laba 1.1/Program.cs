using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите любые буквы:");
        string J = Console.ReadLine();
        string S = "любые символы"; 

        int count = 0; 

        foreach (char c in S)
        {
            if (J.Contains(c.ToString()))
            {
                count++;
            }
        }

        Console.WriteLine($"Количество символов из S, являющихся драгоценностями: {count}");
    }
}