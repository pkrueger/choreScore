namespace choreScore.Services;

public class ChoresService
{
  private readonly ChoresRepository _cr;
  public ChoresService(ChoresRepository cr)
  {
    _cr = cr;
  }

  public List<Chore> GetChoresByCreatorId(string creatorId)
  {
    return _cr.Get(creatorId);
  }

  public Chore GetChoreById(int id, string accountId)
  {
    Chore chore = _cr.Get(id);
    if (chore == null)
    {
      throw new Exception("Bad Id");
    }
    if (chore.creatorId != accountId)
    {
      throw new Exception("You don't own this chore.");
    };
    return chore;
  }

  public Chore CreateChore(Chore choreData)
  {
    return _cr.Create(choreData);
  }
}