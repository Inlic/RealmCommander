using RealmCommander.Repositories;

namespace RealmCommander.Services
{
  public class QuestsService
  {
    private readonly QuestsRepository _repo;

    public QuestsService(QuestsRepository repo)
    {
      _repo = repo;
    }
  }
}