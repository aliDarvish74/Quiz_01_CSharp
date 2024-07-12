using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz_01_CSharp.Libraries;

public class Book : LibraryItem
{
    public Book(string name , string author)
    {
        Name = name;
        Author = author;
    }
    public string Author { get; set; }
    public override void Display()
    {
        Console.WriteLine(JsonSerializer.Serialize(this));
    }
}
