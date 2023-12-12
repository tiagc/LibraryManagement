using LibraryManagement;

public class Program
{
    public static void Main()
    {
        Console.Title = "Library Manager";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("**********************************");
        Console.WriteLine("* Welcome to the digital Library *");
        Console.WriteLine("**********************************");

        var author = Console.ReadLine();
        var title = Console.ReadLine();
        var newBook = new Book(author, "asdffsda", 2020, false);
    }
}
