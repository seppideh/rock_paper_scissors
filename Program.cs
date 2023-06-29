using System;

namespace rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to this playing");
      Console.WriteLine("rock_paper_scissors playing");
      bool playAgain = false;
      int Game_Counter = 0;
      int userWin = 0;
      int computerWin = 0;
      int equality = 0;

      do
      {
        string[] playActions = { "rock", "paper", "scissors" };
        string computer_action;
        string user_action;
        var result = "";


        do
        {
          // computer action
          Random rand = new Random();
          computer_action = playActions[rand.Next(playActions.Length)];

          // user action
          Console.WriteLine("Select between these choises:(rock,paper,scissors)");
          user_action = Console.ReadLine();

          if (computer_action == user_action)
          {
            Console.WriteLine("you and computer select the same action so the game repeat!");
            equality++;
          }
          Game_Counter++;

        } while (computer_action == user_action);



        foreach (string computer_actions in playActions)
        {
          switch (computer_action)
          {
            case "rock":
              result = user_action == "paper" ? "the USER win" : "the COMPUTER win";
              break;
            case "paper":
              result = user_action == "scissors" ? "the USER win" : "the COMPUTER win";
              break;
            default:
              result = user_action == "rock" ? "the USER win" : "the COMPUTER win";
              break;
          }

        }
        if (result == "the USER win")
        {
          userWin++;
        }
        else
        {
          computerWin++;
        }

        Console.Clear();
        Console.WriteLine($"Computer selection: {computer_action}");
        Console.WriteLine($"User selection: {user_action}");
        Console.WriteLine(result);

        Console.WriteLine("Would you like to play again: (y/N)");
        var answer = Console.ReadLine();
        playAgain = answer.ToLower() == "y";
      } while (playAgain);

      Console.WriteLine($"the number of playing:{Game_Counter}");
      Console.WriteLine($"the number of user win:{userWin}");
      Console.WriteLine($"the number of computer win:{computerWin}");
      Console.WriteLine($"the number of equality:{equality}");

    }
  }
}
