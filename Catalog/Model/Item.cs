namespace Catalog.Model
{
  // Record type - good for immutable objects, with expressions support, value based equality
  public record Item
  {
    // set value only during initialization
    public Guid Id { get; init; }
    public string Name { get; init; }
    public decimal Price { get; init; }
    public DateTimeOffset CreatedAt { get; init; }

  }

}