using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Model;
using System.Collections.Generic;
using System;

namespace Catalog.Controllers
{
  [ApiController]
  [Route("items")]
  public class ItemsController : ControllerBase
  {
    private readonly InMemItemsRepository inMemItemsRepository;

    public ItemsController()
    {
      this.inMemItemsRepository = new InMemItemsRepository();
    }

    // GET /items
    [HttpGet]
    public IEnumerable<Item> GetItems()
    {
      return inMemItemsRepository.GetAllItems();
    }

    // Template (an arg in Http requests are ways for you to get the params in a URL)
    // GET /items/{id}
    [HttpGet("{id}")]
    public ActionResult<Item> GetItem(Guid id)
    {
      Item item = inMemItemsRepository.GetItem(id);

      if (item is null)
      {
        return NotFound();
      }

      return item;
    }

  }
}