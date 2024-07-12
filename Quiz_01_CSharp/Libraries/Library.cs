using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_01_CSharp.Libraries;

public class Library<T> where T : LibraryItem
{
    private readonly List<T> items = new List<T> ();

    public void Add(T item)
    {
        items.Add (item);
    }
    public void Remove(Guid id)
    {
        var item = items.FirstOrDefault(i => i.Id == id);

        if(item == null)
        {
            throw new InvalidOperationException("Item not found");
        }

        items.Remove(item);
    }

    public List<T> Search(Guid id)
    {
        return items.Where(i => i.Id == id).ToList();
    }
    public List<T> Search(string name)
    {
        return items.Where(i => i.Name.Contains(name)).ToList();
    }

    public void DisplayAll()
    {
        foreach (var item in items)
        {
            item.Display();
        }
    }
}
