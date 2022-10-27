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
    var sql = "SELECT * FROM chores WHERE creatorId = @creatorId;";
    return _db.Query<Chore>(sql, new { creatorId }).ToList();
  }

  /// <summary>
  /// Get Chore by <paramref name="id"/>
  /// </summary>
  public Chore Get(int id)
  {
    var sql = "SELECT * FROM chores WHERE id = @id;";
    return _db.QueryFirstOrDefault<Chore>(sql, new { id });
  }

  /// <summary>
  /// Create Chore
  /// </summary>
  public Chore Create(Chore choreData)
  {
    var sql = @"
      INSERT INTO chores (name, day, priority) 
      VALUES (@Name, @Day, @Priority);
      SELECT LAST_INSERT_ID();
    ";
    choreData.Id = _db.ExecuteScalar<int>(sql, choreData);
    return choreData;
  }

  /// <summary>
  /// Delete Chores by <paramref name="id"/>
  /// </summary>
  public string Delete(int id)
  {
    var sql = "DELETE FROM chores WHERE id = @id;";
    _db.Execute(sql, new { id });
    return "Chore has been deleted.";
  }

  /// <summary>
  /// Edit Chores by <paramref name="choreData"/>
  /// </summary>
  public void Edit(Chore choreData)
  {
    var sql = @"
    UPDATE chores SET 
      name = @Name, isComplete = @IsComplete, day = @Day, priority = @priority
    WHERE id = @Id;
    ";
    _db.Execute(sql, choreData);
  }
}