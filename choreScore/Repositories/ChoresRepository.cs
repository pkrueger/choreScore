namespace choreScore.Repositories;

public class ChoresRepository
{
  private readonly IDbConnection _db;

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }

  /// <summary>
  /// Get Chores by <paramref name="creatorId"/>
  /// </summary>
  public List<Chore> Get(string creatorId)
  {
    var sql = "SELECT * FROM chores WHERE creatorId = @creatorId";
    return _db.Query<Chore>(sql, new { creatorId }).ToList();
  }
  public Chore Get(int id)
  {
    var sql = "SELECT * FROM chores WHERE id = @id";
    return _db.QueryFirstOrDefault<Chore>(sql, new { id });
  }
}