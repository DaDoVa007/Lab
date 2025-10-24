// UnitGupaliuk.cs
using System;
using System.Globalization;

namespace UnitGupaliuk
{
    // Клас для аналізу тексту
    public static class analizText
    {
        // Функція для підрахунку розділових знаків у рядку
        public static int rozdilZnak(string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            int count = 0;
            char[] znak = { '.', ',', ';', ':', '!', '?', '-', '—', '(', ')', '"', '\'' };

            foreach (char c in text)
            {
                foreach (char z in znak)
                {
                    if (c == z)
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }

    // Клас для перевіреного введення чисел
    public static class corectInput
    {
        // Ввід цілого числа
        public static int inputInt(string message)
        {
            int value;
            Console.Write(message);
            string s = Console.ReadLine();

            while (!int.TryParse(s, out value))
            {
                Console.Write("Помилка! Введи ціле число: ");
                s = Console.ReadLine();
            }
            return value;
        }

        // Ввід дійсного числа
        public static double inputDouble(string message)
        {
            double value;
            Console.Write(message);
            string s = Console.ReadLine();

            while (!double.TryParse(s.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                Console.Write("Помилка! Введи дійсне число: ");
                s = Console.ReadLine();
            }
            return value;
        }
    }
}
