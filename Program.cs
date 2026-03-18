using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Witaj! Podaj liczby oddzielone spacją:");
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