using System;
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

    public List<Knight> Find()
    {
      return _repo.Find();
    }
    public Knight FindById(int id)
    {
      var data = _repo.FindById(id);
      if (data == null)
      {
        throw new Exception("Invalid ID");
      }
      return data;
    }
    public Knight Create(Knight knight)
    {
      return _repo.Create(knight);
    }
    public Knight Update(Knight knight)
    {
      var data = FindById(knight.Id);
      knight.Name = knight.Name != null && knight.Name.Length > 0 ? knight.Name : data.Name;
      return _repo.Update(knight);
    }
    public bool Delete(int id)
    {
      var data = FindById(id);
      _repo.Delete(id);
      return true;
    }
  }
}