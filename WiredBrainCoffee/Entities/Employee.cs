using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.Entities
{
  public  class Employee
  {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public override string ToString()=>  $"Id: {Id}, FirstName: {FirstName}"; 
    
  }
}
