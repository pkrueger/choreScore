using chore_score.Enums;

namespace chore_score.Models;

public class Chore
{
  public string Id { get; private set; }
  public string Name { get; private set; }
  public bool IsComplete { get; private set; }
  public DayOfTheWeek Day { get; private set; }

  public Chore(string name, DayOfTheWeek day)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    IsComplete = false;
    Day = day;
  }

}