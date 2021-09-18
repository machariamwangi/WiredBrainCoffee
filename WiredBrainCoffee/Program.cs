using System;
using WiredBrainCoffee.Entities;
using WiredBrainCoffee.Repositories;

namespace WiredBrainCoffee
{
  class Program
  {
    static void Main(string[] args)
    {
      GenericRepository<Employee>? employeeRepository = new GenericRepository<Employee>();

      employeeRepository.Add(new Employee { FirstName = "Elijah" });
      employeeRepository.Add(new Employee { FirstName = "Mike" });
      employeeRepository.Add(new Employee { FirstName = "Chris" });
      employeeRepository.save();

      var organisationRepository = new GenericRepository<Organization>();
      organisationRepository.Add(new Organization { Name = "brix ltd" });
      organisationRepository.Add(new Organization { Name = "New org" });
      organisationRepository.save();

      Console.ReadLine();
    }
  }
}
