using chore_score.Enums;

namespace chore_score.Data;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Wash the dishes", DayOfTheWeek.Monday),
    new Chore("Take out the trash", DayOfTheWeek.Thursday),
    new Chore("Clean room", DayOfTheWeek.Tuesday)
  };
}