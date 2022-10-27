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
    }
    return chore;
  }

  public Chore CreateChore(Chore choreData)
  {
    return _cr.Create(choreData);
  }

  public string DeleteChore(int id, string accountId)
  {
    GetChoreById(id, accountId);
    return _cr.Delete(id);
  }

  internal Chore EditChore(Chore choreData)
  {
    Chore originalChore = GetChoreById(choreData.Id, choreData.creatorId);

    originalChore.Day = choreData.Day ?? originalChore.Day;
    originalChore.IsComplete = choreData.IsComplete ?? originalChore.IsComplete;
    originalChore.Name = choreData.Name ?? originalChore.Name;
    originalChore.Priority = choreData.Priority ?? originalChore.Priority;

    _cr.Edit(choreData);
    return originalChore;
  }
}