using System;

namespace APBD_CW1
{
    public static class StatisticsHelper
    {
        // Metoda oblicza minimalną wartość w tablicy liczb całkowitych
        // Zgłasza wyjątek, jeśli tablica jest pusta
        public static int CalculateMin(int[] values)
        {
            if (values.Length == 0)
            {
                // Wyjątek informujący o braku danych
                throw new ArgumentException("Brak danych do obliczenia min");
            }

            // Inicjalizacja minimalnej wartości pierwszym elementem
            int min = values[0];

            // Pętla sprawdzająca każdy element tablicy
            foreach (var v in values)
            {
                if (v < min)
                {
                    min = v; // Aktualizacja minimalnej wartości
                }
            }

            return min; // Zwracamy najmniejszą wartość
        }
    }
}