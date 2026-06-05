namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Marita Kharshiladze");
            Console.WriteLine("---------------------");

            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"You entered: {userInput}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
