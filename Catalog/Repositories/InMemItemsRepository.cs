using System.Collections.Generic;
using System.Linq;
using Catalog.Model;

// Handles data with getting info from our inMemory DB 
namespace Catalog.Repositories
{
  public class InMemItemsRepository
  {

    // This will initialize out DB with a list of items available for us to interact with
    private readonly List<Item> items = new()
    {
      new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedAt = DateTimeOffset.UtcNow },
      new Item { Id = Guid.NewGuid(), Name = "Iron Sowrd", Price = 20, CreatedAt = DateTimeOffset.UtcNow },
      new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 15, CreatedAt = DateTimeOffset.UtcNow }
    };

    // return a collection of items 
    public IEnumerable<Item> GetAllItems()
    {
      return items;
    }

    public Item GetItem(Guid id)
    {
      return items.Where(item => item.Id == id).SingleOrDefault();
    }
  }

}