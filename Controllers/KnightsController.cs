using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RealmCommander.Models;

namespace RealmCommander.Controllers
{
  [Route("/[controller]")]
  [ApiController]
  public class KnightsController : ControllerBase
  {
    // Get All
    [HttpGet]
    public ActionResult<IEnumerable<Quest>> Get()
    {
      return Ok(new Quest[] { new Quest() });
    }

    // Get One
    [HttpGet("{id}")]
    public void Get(int id)
    {

    }

    // Create One
    [HttpPost]
    public void Create()
    {

    }

    // Edit One
    [HttpPut("{id}")]
    public void Update(int id)
    {

    }
    // Delete One
    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }

  }
}