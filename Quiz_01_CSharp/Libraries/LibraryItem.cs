using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_01_CSharp.Libraries;

public abstract class LibraryItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public abstract void Display();
}
