namespace ConsoleApp1
{
    // write a class and inside it write a method 
    // that gets a filename and prints the extension of that file
    public class FileName
    {
        public void PrintFileExtension(string fileName)
        {
            string[] fileParts = fileName.Split('.');
            string extension = fileParts[fileParts.Length - 1];
            Console.WriteLine(extension);
        }
    }
}
