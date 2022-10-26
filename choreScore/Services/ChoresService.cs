namespace choreScore.Services;

public class ChoresService
{
  private readonly IDbConnection _db;
  public ChoresService(IDbConnection db)
  {
    _db = db;
  }

  public List<Chore> GetChores()
  {
    // return _db.Chores;
    return null;
  }
}