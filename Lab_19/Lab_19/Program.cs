
using System;
using UnitTest;   

namespace UseLibraryDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Демонстрація роботи власної бібліотеки UnitGupaliuk ===\n");

            // Використовуємо методи з бібліотеки
            int number = corectInput.inputInt("Введи ціле число: ");
            double value = corectInput.inputDouble("Введи дійсне число: ");

            Console.Write("Введи речення: ");
            string text = Console.ReadLine();

            int znakCount = analizText.rozdilZnak(text);

            Console.WriteLine("\nРезультати:");
            Console.WriteLine($"1) Ціле число = {number}");
            Console.WriteLine($"2) Дійсне число = {value}");
            Console.WriteLine($"3) Кількість розділових знаків = {znakCount}");

            Console.WriteLine("\nНатисни будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}
