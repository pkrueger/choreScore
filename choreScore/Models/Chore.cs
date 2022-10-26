using choreScore.Enums;

namespace choreScore.Models;

public class Chore
{
  public string Id { get; private set; }
  public string Name { get; private set; }
  public bool IsComplete { get; private set; }
  public DayOfTheWeek Day { get; private set; }
  public int Priority { get; private set; }

  public Chore(string name, DayOfTheWeek day, int priority)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    IsComplete = false;
    Day = day;
    Priority = priority;
  }
}