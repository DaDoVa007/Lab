using System;
class Task1_Variant2
{
    static double InputDouble(string prompt, double defaultVal)
    {
        Console.Write($"{prompt} (натисни Enter для значення за замовчуванням {defaultVal}): ");
        string s = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(s)) return defaultVal;
        while (!double.TryParse(s.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double val))
        {
            Console.Write("Некоректно. Введи число: ");
            s = Console.ReadLine();
        }
        return double.Parse(s.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture);
    }

    //ЗАМІНИТЬ ТУТ ФОРМУЛУ НА ТОЧНУ З PDF (варіант 2)
    static double ComputeS(double x, double y, double z)
    {
        // ПОКИ ЩО — приклад: просто комбінуємо деякі елементи.
        // Замініть цю реалізацію на точну формулу з варіанту 2.
        // Наприклад (псевдо-формула):
        // S = 3.1 + Math.Tan(1) + Math.Log10(Math.Abs(y)) + (54.7)/(34 + Math.Pow(Math.Tan(2),2));
        // Поки повернемо цю демонстраційну формулу:
        double part1 = 3.1 + Math.Tan(1.0);
        double part2 = (y != 0) ? Math.Log10(Math.Abs(y)) : 0.0;
        double part3 = 54.7 / (34.0 + Math.Pow(Math.Tan(2.0), 2));
        return part1 + part2 + part3;
    }

    static void Main()
    {
        Console.WriteLine("Лаб. №18 — Завдання 1 (варіант 2). Введи x,y,z або натисни Enter для значень за замовчуванням x=1.5,y=0.1,z=0.5");
        double x = InputDouble("x", 1.5);
        double y = InputDouble("y", 0.1);
        double z = InputDouble("z", 0.5);

        double S = ComputeS(x, y, z);

        Console.WriteLine($"\nРезультат: S = {S}");
        Console.WriteLine("\nПримітка: формула в файлі частково нечітка. Якщо пришлеш текст/зображення формули — я заміню ComputeS на точну реалізацію.");

        Console.WriteLine("Натисніть _Enter_ для закынчення програми");
        Console.ReadLine();

    }
}
