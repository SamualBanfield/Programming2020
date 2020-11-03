using System;

namespace RPS.models
{
  public class GameResult
  {
    public string playerChoice { get; set; }
    public string computerChoice { get; set; }
    public string result { get; set; }

    public GameResult(string playerChoice)
    {
      this.playerChoice = playerChoice;
      this.computerChoice = "paper";
      this.result = "win";
    }

    // public GameResult(string playerChoice)
    // {
    //   this.playerChoice = playerChoice;
    //   GenerateComputerChoice();
    //   GenerateResult();
    // }

    // public void GenerateComputerChoice()
    // {
    //   string[] options = new string[] { "rock", "paper", "scissors" };
    //   Random rand = new Random();
    //   this.computerChoice = options[rand.Next(0, 2)];
    // }

    // public void GenerateResult()
    // {
    //   switch (this.playerChoice)
    //   {
    //     case "rock":
    //       if (this.computerChoice == "rock")
    //       {
    //         this.result = "tie";
    //       }
    //       else if (this.computerChoice == "paper")
    //       {
    //         this.result = "loss";
    //       }
    //       else if (this.computerChoice == "scissors")
    //       {
    //         this.result = "win";
    //       }
    //       break;
    //     case "paper":
    //       if (this.computerChoice == "rock")
    //       {
    //         this.result = "win";
    //       }
    //       else if (this.computerChoice == "paper")
    //       {
    //         this.result = "tie";
    //       }
    //       else if (this.computerChoice == "scissors")
    //       {
    //         this.result = "loss";
    //       }
    //       break;
    //     case "scissors":
    //       if (this.computerChoice == "rock")
    //       {
    //         this.result = "loss";
    //       }
    //       else if (this.computerChoice == "paper")
    //       {
    //         this.result = "win";
    //       }
    //       else if (this.computerChoice == "scissors")
    //       {
    //         this.result = "tie";
    //       }
    //       break;
    //     default:
    //       break;
    //   }
    // }
  }
}