using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RealmCommander.Models;
using RealmCommander.Services;

namespace RealmCommander.Controllers
{
  [Route("/api/[controller]")]
  [ApiController]
  public class KnightsController : ControllerBase
  {
    private readonly KnightsService _service;

    // Get All
    [HttpGet]
    public ActionResult<IEnumerable<Knight>> Get()
    {
      try
      {
        return Ok(_service.Find());
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    // Get One
    [HttpGet("{id}")]
    public ActionResult<Knight> Get(int id)
    {
      try
      {
        return Ok(_service.FindById(id));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    // Create One
    [HttpPost]
    public ActionResult<Knight> Create([FromBody] Knight knight)
    {
      try
      {
        return Ok(_service.Create(knight));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    // Edit One
    [HttpPut("{id}")]
    public ActionResult<Knight> Update([FromBody] Knight updated, int id)
    {
      try
      {
        updated.Id = id;
        return Ok(_service.Update(updated));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
    // Delete One
    [HttpDelete("{id}")]
    public ActionResult<bool> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    public KnightsController(KnightsService service)
    {
      _service = service;
    }
  }
}