using Microsoft.AspNetCore.Mvc;
using RealmCommander.Services;

namespace RealmCommander.Controllers
{
  [Route("/[controller]")]
  [ApiController]
  public class QuestsController : ControllerBase
  {
    private readonly QuestsService _service;

    [HttpGet]
    public void Get()
    {

    }
    [HttpGet("{id")]
    public void Get(int id)
    {

    }
    [HttpPost]
    public void Create()
    {

    }
    [HttpPut]
    public void Update(int id)
    {

    }
    [HttpDelete]
    public void Delete(int id)
    {

    }
    public QuestsController(QuestsService service)
    {
      _service = service;
    }
  }
}