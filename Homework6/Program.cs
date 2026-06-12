using System;
using System.Collections.Generic;
using System.Linq;

class HomeWork_Week6
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Task1();
        Task2();
        Task3();
        Task4();
    }

    // Task 1
    static void Task1()
    {
        Console.WriteLine("Task 1: Even / Odd Filter");
        Console.Write("Enter array size: ");

        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Invalid size!");
            return;
        }

        Console.Write("Enter numbers separated by space: ");
        var parts = Console.ReadLine()?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

        var numbers = new List<int>();
        foreach (var part in parts)
        {
            if (int.TryParse(part, out int parsed))
                numbers.Add(parsed);
        }

        numbers = numbers.Take(size).ToList();

        var evens = numbers.Where(x => x % 2 == 0).ToArray();
        var odds = numbers.Where(x => x % 2 != 0).ToArray();

        Console.WriteLine("მასივი#1 : " + string.Join(" ", evens));
        Console.WriteLine("მასივი#2: " + string.Join(" ", odds));
    }

    // Task 2: Contacts App
    static void Task2()
    {
        Console.WriteLine("\nTask 2: Contacts App");
        var contacts = new Dictionary<string, string>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Add   2. Delete   3. Update   4. Show All   5. Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    Console.Write("Name: ");
                    string addName = Console.ReadLine()?.Trim();
                    Console.Write("Phone: ");
                    string addPhone = Console.ReadLine()?.Trim();

                    if (string.IsNullOrEmpty(addName) || string.IsNullOrEmpty(addPhone))
                    {
                        Console.WriteLine("Name and phone cannot be empty!");
                        break;
                    }
                    if (contacts.ContainsKey(addName))
                    {
                        Console.WriteLine("Contact already exists!");
                        break;
                    }
                    contacts[addName] = addPhone;
                    Console.WriteLine($"'{addName}' added.");
                    break;

                case "2":
                    Console.Write("Name to delete: ");
                    string delName = Console.ReadLine()?.Trim();
                    if (contacts.Remove(delName))
                        Console.WriteLine($"'{delName}' deleted.");
                    else
                        Console.WriteLine("Contact not found!");
                    break;

                case "3":
                    Console.Write("Name to update: ");
                    string updName = Console.ReadLine()?.Trim();
                    if (!contacts.ContainsKey(updName))
                    {
                        Console.WriteLine("Contact not found!");
                        break;
                    }
                    Console.Write("New phone: ");
                    string newPhone = Console.ReadLine()?.Trim();
                    if (string.IsNullOrEmpty(newPhone))
                    {
                        Console.WriteLine("Phone cannot be empty!");
                        break;
                    }
                    contacts[updName] = newPhone;
                    Console.WriteLine($"'{updName}' updated.");
                    break;

                case "4":
                    if (!contacts.Any())
                    {
                        Console.WriteLine("No contacts yet.");
                        break;
                    }
                    foreach (var c in contacts)
                        Console.WriteLine($"  {c.Key} -> {c.Value}");
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        Console.WriteLine("Exiting Contacts App...");
    }

    // Task 3
    static void Task3()
    {
        Console.WriteLine("\nTask 3: Element Count & Sum");
        Console.Write("Enter array size: ");

        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Invalid size!");
            return;
        }

        Console.Write("Enter numbers separated by space: ");
        var parts = Console.ReadLine()?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

        var numbers = new List<int>();
        foreach (var p in parts)
        {
            if (int.TryParse(p, out int val))
                numbers.Add(val);
        }

        numbers = numbers.Take(size).ToList();

        var grouped = numbers
            .GroupBy(x => x)
            .OrderBy(g => g.Key);

        foreach (var group in grouped)
        {
            int count = group.Count();
            int sum = group.Key * count;
            Console.WriteLine($"{group.Key} appears {count} times sum {sum}");
        }
    }

    // Task 4
    static void Task4()
    {
        Console.WriteLine("\nTask 4: Top N Results");

        int[] scores = { 5, 2, 8, 1, 9, 3, 7, 4, 6, 10 };

        Console.Write("Enter N (how many top results): ");
        if (!int.TryParse(Console.ReadLine(), out int topN) || topN <= 0 || topN > scores.Length)
        {
            Console.WriteLine("Invalid N!");
            return;
        }

        var top = scores.OrderByDescending(x => x).Take(topN).OrderBy(x => x).ToArray();
        Console.WriteLine(string.Join(" ", top));
    }
}