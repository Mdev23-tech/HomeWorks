using System;
using System.Linq;
using System.Collections.Generic;

class HomeWork_Week7
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }

    static void Task1()
    {
        Console.WriteLine("Task 1: Square Area Difference");
        Console.Write("Enter radius: ");

        if (!int.TryParse(Console.ReadLine(), out int r) || r <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        double result = 4 * r * r - 2 * r * r;
        Console.WriteLine($"Output: {result}");
    }

    static void Task2()
    {
        Console.WriteLine("\nTask 2: Jackpot");
        Console.Write("Enter symbols separated by space: ");
        var parts = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

        if (parts.Length == 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        bool isJackpot = parts.All(x => x == parts[0]);
        Console.WriteLine(isJackpot ? "Yes" : "No");
    }

    static void Task3()
    {
        Console.WriteLine("\nTask 3: Football Points");
        Console.Write("Enter wins: ");
        int.TryParse(Console.ReadLine(), out int wins);
        Console.Write("Enter draws: ");
        int.TryParse(Console.ReadLine(), out int draws);
        Console.Write("Enter losses: ");
        int.TryParse(Console.ReadLine(), out int losses);

        int total = wins * 3 + draws * 1 + losses * 0;
        Console.WriteLine($"Output: {total}");
    }

    static void Task4()
    {
        Console.WriteLine("\nTask 4: Weekly Salary");
        Console.Write("Enter hours for each day (7 days, separated by space): ");
        var parts = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

        if (parts.Length != 7)
        {
            Console.WriteLine("Please enter exactly 7 values!");
            return;
        }

        int[] hours = new int[7];
        for (int i = 0; i < 7; i++)
        {
            if (!int.TryParse(parts[i], out hours[i]) || hours[i] < 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }

        double totalSalary = 0;

        for (int day = 0; day < 7; day++)
        {
            int h = hours[day];

            if (day >= 5)
            {
                totalSalary += h * 20;
            }
            else
            {
                int normal = Math.Min(h, 8);
                int overtime = Math.Max(h - 8, 0);
                totalSalary += normal * 10 + overtime * 15;
            }
        }

        Console.WriteLine($"Output: {totalSalary}");
    }

    static void Task5()
    {
        Console.WriteLine("\nTask 5: Marathon Progress");
        Console.Write("Enter daily results separated by space: ");
        var parts = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

        var results = new List<int>();
        foreach (var p in parts)
        {
            if (int.TryParse(p, out int val))
                results.Add(val);
        }

        if (results.Count < 2)
        {
            Console.WriteLine("Need at least 2 days!");
            return;
        }

        int progressDays = 0;
        for (int i = 1; i < results.Count; i++)
        {
            if (results[i] > results[i - 1])
                progressDays++;
        }

        Console.WriteLine($"Output: {progressDays}");
    }

    static void Task6()
    {
        Console.WriteLine("\nTask 6: Element Length Filter");
        Console.Write("Enter N: ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Enter words separated by space: ");
        var words = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

        var result = words.Where(w => w.Length == n).ToArray();

        if (result.Length == 0)
            Console.WriteLine("No elements found");
        else
            Console.WriteLine(string.Join(", ", result));
    }
}