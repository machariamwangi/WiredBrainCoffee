using System;
using System.Collections.Generic;
using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
  public class GenericRepository<T>
  {
    //public Tkey? Key { get; set; }
    protected readonly List<T> _items = new();
    public void Add(T item)
    {
      _items.Add(item);
    }

    public void Remove(T item)
    {
      _items.Remove(item);
    }
    public void save()
    {
      foreach (var item in _items)
      {
       Console.WriteLine(item);
      }
    }
  }

}
