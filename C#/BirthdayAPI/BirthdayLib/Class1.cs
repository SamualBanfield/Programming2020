using System;

namespace BirthdayLib
{
  public class Birthdays
  {
    [JsonPropertyName("name")]
    public string firstName { get; set; }
    [JsonPropertyName("name")]
    public string lastName { get; set; }
    [JsonPropertyName("date")]
    public DateTime date { get; set; }

    public Birthdays(string firstName, string lastName, DateTime date)
    {
      this.firstName = firstName;
      this.LastName = LastName;
      this.date = date;
    }
  }
}
