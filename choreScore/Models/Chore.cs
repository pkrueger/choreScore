using choreScore.Enums;

namespace choreScore.Models;

public class Chore
{
  public int Id { get; set; }
  public string Name { get; set; }
  public bool IsComplete { get; set; }
  public DayOfTheWeek Day { get; set; }
  public int Priority { get; set; }
  public string creatorId { get; set; }

  // public Chore(string name, DayOfTheWeek day, int priority)
  // {
  //   Id = Guid.NewGuid().ToString();
  //   Name = name;
  //   IsComplete = false;
  //   Day = day;
  //   Priority = priority;
  // }
}