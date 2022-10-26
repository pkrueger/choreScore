using System.Text.Json.Serialization;

namespace chore_score.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DayOfTheWeek
{
  Sunday,
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
  Saturday
}