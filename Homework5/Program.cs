using System;

class HomeWork_5
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //  Task 1
        Console.WriteLine("Task 1: Divisible by 5");
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine(num % 5 == 0 ? "Yes" : "NO");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

        // Task 2
        Console.WriteLine("\nTask 2: Calculator");
        Console.Write("Enter X: ");
        if (!int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Enter Y: ");
        if (!int.TryParse(Console.ReadLine(), out int y))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int bigger = Math.Max(x, y);
        int smaller = Math.Min(x, y);

        Console.WriteLine($"X+Y = {x + y}");
        Console.WriteLine($"X-Y = {bigger - smaller}");
        Console.WriteLine($"X*Y = {x * y}");

        if (smaller == 0)
            Console.WriteLine("X/Y = Not Allowed To Divide By Zero");
        else
            Console.WriteLine($"X/Y = {bigger / smaller}");

        // Task 3
        Console.WriteLine("\nTask 3: Swap Variables");
        Console.Write("Enter x: ");
        if (!int.TryParse(Console.ReadLine(), out int swapX))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.Write("Enter y: ");
        if (!int.TryParse(Console.ReadLine(), out int swapY))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        int temp = swapX;
        swapX = swapY;
        swapY = temp;

        Console.WriteLine($"Output : x = {swapX} ; y = {swapY};");

        // Task 4
        Console.WriteLine("\nTask 4: Multiplication Table");
        Console.Write("input ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            for (int i = 1; i <= 9; i++)
                Console.WriteLine($"{n} * {i} = {n * i}");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

        // Task 5
        Console.WriteLine("\nTask 5: Squares of Even Numbers");
        Console.Write("Input  - ");
        if (int.TryParse(Console.ReadLine(), out int limit))
        {
            for (int i = 2; i <= limit; i += 2)
                Console.WriteLine(i * i);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
