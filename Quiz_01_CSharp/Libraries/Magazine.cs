using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz_01_CSharp.Libraries;

public class Magazine : LibraryItem
{
    public Magazine(string name, string genre)
    {
        Name = name;
        Genre = genre;
    }
    public string Genre { get; set; }
    public override void Display()
    {
        Console.WriteLine(JsonSerializer.Serialize(this));
    }
}
