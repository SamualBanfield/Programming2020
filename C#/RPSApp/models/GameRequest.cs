namespace RPS.models
{
  public class GameRequest
  {
    [JsonProperty("playerChoice")]
    public string playerChoice { get; set; }

    GameRequest(string playerChoice)
    {
      this.playerChoice = playerChoice;
    }
  }
}