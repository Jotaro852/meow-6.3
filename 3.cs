using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine("Число " + number + " является четным и кратным 10.");
        }
        else
        {
            Console.WriteLine("Число " + number + " не является четным и кратным 10.");
        }
    }
}
