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
    return null;
  }
}