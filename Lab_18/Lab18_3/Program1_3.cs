using System;
using System.Collections.Generic;
class Task3_Variant2_Fibonacci
{
    static int InputInt(string prompt, int defaultVal)
    {
        Console.Write($"{prompt} (Enter для {defaultVal}): ");
        string s = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(s)) return defaultVal;
        while (!int.TryParse(s, out int val) || val < 0)
        {
            Console.Write("Некоректно. Введи невід'ємне ціле число: ");
            s = Console.ReadLine();
        }
        return int.Parse(s);
    }

    static Dictionary<int, long> memo = new Dictionary<int, long>() { { 0, 0 }, { 1, 1 } };

    static long Fib(int n)
    {
        if (memo.ContainsKey(n)) return memo[n];
        long val = Fib(n - 1) + Fib(n - 2);
        memo[n] = val;
        return val;
    }

    static void Main()
    {
        Console.WriteLine("Лаб. №18 — Завдання 3 (варіант 2). Рекурсія: n-те число Фібоначчі.");
        int n = InputInt("Введи n (порядковий номер, n >= 0)", 10);
        long result = Fib(n);
        Console.WriteLine($"\nF({n}) = {result}");
    }
}
