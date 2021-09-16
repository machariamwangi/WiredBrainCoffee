using System;
using System.Collections.Generic;
using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
  public class GenericRepository<T>
  {
    private readonly List<T> items = new();
    public void Add(T item)
    {
      items.Add(item);
    }

    public void save()
    {
      foreach (var item in items)
      {
       Console.WriteLine(item);
      }
    }
  }
}
