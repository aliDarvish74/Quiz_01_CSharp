using Quiz_01_CSharp.Libraries;

namespace Quiz_01_CSharp;

public class Program
{
    static void Main(string[] args)
    {
        var books = new Library<Book>();
        var magazines = new Library<Magazine>();

        var TheIdealTeamPlayer = new Book("The Ideal Team Player", "Patric Lenchoni");
        var AtomcHobits = new Book("Atomic Hobits", "Nemidoonam Ki bood");

        var Jadval = new Magazine("Jadval", "Entertainment");

        books.Add(TheIdealTeamPlayer);
        books.Add(AtomcHobits);
        Console.WriteLine("Books Before Deletion:");
        books.DisplayAll();

        magazines.Add(Jadval);
        Console.WriteLine("Magazines:");
        magazines.DisplayAll();


        books.Remove(AtomcHobits.Id);
        Console.WriteLine($"Books After Deleting {AtomcHobits.Name}:");
        books.DisplayAll();

        var foundBooks= books.Search("Team");
        Console.WriteLine($"Found items for name team:");
        foreach (var item in foundBooks)
        {
            item.Display();
        }

        var foundMagazines = magazines.Search(Jadval.Id);
        Console.WriteLine($"Found items for jadval Id:");

        foreach (var item in foundMagazines)
        {
            item.Display();
        }

        var invalidSearch = books.Search(Jadval.Id);
        if(!invalidSearch.Any())
        {
            Console.WriteLine("Nothin found");
        }
        else
        {
            foreach (var item in invalidSearch)
            {
                item.Display();
            }
        }
        Console.WriteLine("**************************************");
        Practice.BMI(100, 183);
        
    }
}
