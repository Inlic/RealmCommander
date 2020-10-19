using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RealmCommander.Models;
using RealmCommander.Services;

namespace RealmCommander.Controllers
{
  [Route("/api/[controller]")]
  [ApiController]
  public class QuestsController : ControllerBase
  {
    private readonly QuestsService _service;

    [HttpGet]
    public ActionResult<IEnumerable<Quest>> Get()
    {
      return Ok(_service.Find());
    }
    [HttpGet("{id}")]
    public ActionResult<Quest> Get(int id)
    {
      return Ok(_service.FindById(id));
    }
    [HttpPost]
    public ActionResult<Quest> Create([FromBody] Quest q)
    {
      return Ok(_service.Create(q));
    }
    [HttpPut("{id}")]
    public void Update(int id)
    {

    }
    [HttpDelete("{id}")]
    public ActionResult<bool> Delete(int id)
    {
      return Ok(_service.Delete(id));
    }
    public QuestsController(QuestsService service)
    {
      _service = service;
    }
  }
}