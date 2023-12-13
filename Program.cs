using LibraryManagement;
using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main()
    {
        Console.Title = "Library Manager";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("**********************************");
        Console.WriteLine("* Welcome to the digital Library *");
        Console.WriteLine("**********************************");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Choose an Option");
        Console.WriteLine("1) Show list of Books");
        Console.WriteLine("2) Show list of Authors");
        Console.WriteLine("3) Add a Book");
        var Option = Console.ReadKey();
        switch (Option.Key)
        {
            case ConsoleKey.D1:
                Console.Write("");
                break;
            default:
                Console.Write("");
                break;
        }


        var author = Console.ReadLine();
        var title = Console.ReadLine();
        var newBook = new Book(author, "asdffsda", 2020, false);
    }
}
