using System;
class Task2_Variant2_Sports
{
    static int InputInt(string prompt, int defaultVal)
    {
        Console.Write($"{prompt} (Enter для {defaultVal}): ");
        string s = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(s)) return defaultVal;
        while (!int.TryParse(s, out int val))
        {
            Console.Write("Некоректно. Введи ціле число: ");
            s = Console.ReadLine();
        }
        return int.Parse(s);
    }

    static double DistanceFirst(double t) => 10.0 * t + 0.5 * t * t;
    static double DistanceSecond(double t) => 9.0 * t + 0.8 * t * t;

    static void CompareAt(double t)
    {
        double s1 = DistanceFirst(t);
        double s2 = DistanceSecond(t);
        Console.WriteLine($"\nЧерез {t} годин(и): S1 = {s1:F4}, S2 = {s2:F4}");
        if (s1 > s2) Console.WriteLine("Перший спортсмен пройшов більше.");
        else if (s2 > s1) Console.WriteLine("Другий спортсмен пройшов більше.");
        else Console.WriteLine("Пройдені відстані однакові.");
    }

    static void Main()
    {
        Console.WriteLine("Лаб. №18 — Завдання 2 (варіант 2). Порівняння двох спортсменів (формули в завданні).");
        Console.WriteLine("Можеш ввести інші моменти часу (цілі години). За замовчуванням перевіряємо t=1 та t=4.");
        int t1 = InputInt("Час 1 (години)", 1);
        int t2 = InputInt("Час 2 (години)", 4);

        CompareAt(t1);
        CompareAt(t2);
    }
}
