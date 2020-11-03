using Microsoft.AspNetCore.Mvc;
using RPS.models;

namespace RPSApp.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class GameController : ControllerBase
  {
    [HttpPost]
    public GameResult PlayRequest([FromBody] GameRequest playRequest)
    {
      GameResult result = new GameResult("rock");
      return result;
    }
  }
}