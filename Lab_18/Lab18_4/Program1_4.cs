using System;
using System.Collections.Generic;
class Task4_Variant2_Perfects
{
    static int InputInt(string prompt, int defaultVal)
    {
        Console.Write($"{prompt} (Enter для {defaultVal}): ");
        string s = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(s)) return defaultVal;
        while (!int.TryParse(s, out int val) || val <= 0)
        {
            Console.Write("Некоректно. Введи натуральне число (>0): ");
            s = Console.ReadLine();
        }
        return int.Parse(s);
    }

    static bool IsPerfect(int n)
    {
        if (n < 2) return false;
        int sum = 1;
        int limit = (int)Math.Sqrt(n);
        for (int d = 2; d <= limit; d++)
        {
            if (n % d == 0)
            {
                sum += d;
                int other = n / d;
                if (other != d) sum += other;
            }
        }
        return sum == n;
    }

    static void Main()
    {
        Console.WriteLine("Лаб. №18 — Завдання 4 (варіант 2). Знайти досконалі числа в послідовності.");
        int count = InputInt("Скільки чисел вводити?", 6);

        List<int> arr = new List<int>();
        for (int i = 0; i < count; i++)
        {
            Console.Write($"a[{i}] = ");
            string s = Console.ReadLine();
            while (!int.TryParse(s, out int val) || val <= 0)
            {
                Console.Write("Некоректно. Введи натуральне число (>0): ");
                s = Console.ReadLine();
            }
            arr.Add(int.Parse(s));
        }

        List<int> perfects = new List<int>();
        foreach (int v in arr)
            if (IsPerfect(v)) perfects.Add(v);

        Console.WriteLine("\nДосконалі числа серед введених:");
        if (perfects.Count == 0) Console.WriteLine("Немає досконалих чисел у послідовності.");
        else Console.WriteLine(string.Join(", ", perfects));
    }
}
