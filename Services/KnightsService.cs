using System.Collections.Generic;
using RealmCommander.Models;
using RealmCommander.Repositories;

namespace RealmCommander.Services
{
  public class KnightsService
  {
    private readonly KnightsRepository _repo;
    public KnightsService(KnightsRepository repo)
    {
      _repo = repo;
    }

    public Knight Create(string name)
    {
      return _repo.Create(name);
    }
    public bool Delete(int id)
    {
      return _repo.Delete(id);
    }
    public Knight FindById(int id)
    {
      return _repo.FindOneById(id);
    }
    public List<Knight> Find()
    {
      return _repo.Find();
    }
  }
}