using System.Text.Json.Serialization;

namespace choreScore.Enums;

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