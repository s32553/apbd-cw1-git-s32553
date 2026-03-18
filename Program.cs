using System;

class Program
{
    static void Main()
    {
<<<<<<< HEAD
        Console.WriteLine("Wprowadź liczby oddzielone przecinkami (main)");
=======
        Console.WriteLine("Wprowadź liczby oddzielone spacją (feature-conflict2)");
>>>>>>> feature-conflict2
        var input = Console.ReadLine();
        try
        {
            var numbers = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.WriteLine("Podane liczby: " + string.Join(", ", numbers));

            double average = APBD_CW1.StatisticsHelper.CalculateAverage(numbers);
            Console.WriteLine("Średnia wczytanych liczb: " + average);
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd: Podano nieprawidłowe dane.");
        }
    }
}