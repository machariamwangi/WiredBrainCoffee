namespace WiredBrainCoffee.Entities
{
  public class Organizatiom
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public override string ToString() => $"Id: {Id}, FirstName: {Name}";

  }
}
