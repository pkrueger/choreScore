using chore_score.Data;

namespace chore_score.Services;

public class ChoresService
{
  private readonly FakeDb _db;
  public ChoresService(FakeDb db)
  {
    _db = db;
  }

  public List<Chore> GetChores()
  {
    return _db.Chores;
  }
}