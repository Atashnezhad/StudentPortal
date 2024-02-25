 namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an instance of the FileName class
            FileName fileNameHandler = new FileName();

            // Call the PrintFileExtension method with a sample filename
            fileNameHandler.PrintFileExtension("example.txt");

            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

