using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Як тебе звати? ");
        string name = Console.ReadLine();

        GreetUser(name);

        Console.WriteLine("Натисни будь-яку клавішу для виходу...");
        Console.ReadKey();
    }

    static void GreetUser(string name)
    {
        int hour = DateTime.Now.Hour;
        string greeting;

        if (hour < 6) greeting = "Доброї ночі";
        else if (hour < 12) greeting = "Доброго ранку";
        else if (hour < 18) greeting = "Доброго дня";
        else greeting = "Доброго вечора";

        Console.WriteLine($"{greeting}, {name}! Радий тебе бачити. Гарного тобі настрою.");
    }
}


