using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczby oddzielone spacją:");
        var input = Console.ReadLine();
        var numbers = Array.ConvertAll(input.Split(' '), int.Parse);

        Console.WriteLine("Wczytane liczby: " + string.Join(", ", numbers));
    }
}