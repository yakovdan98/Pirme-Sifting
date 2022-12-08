using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class PrimeSifter
  {
    // properties, constructors, methods, etc. go here
    public int Number { get; set; }

    // constructor
    public PrimeSifter(int userInput)
    {
      Number = userInput;
    }

    // get primes
    public static string RockPaperScissors(string player1, string player2)
    {
      player1 = player1.ToLower();
      player2 = player2.ToLower();
      if(player1 == player2)
      {
        return "It's a tie";
      } else if(player1 == "rock" && player2 == "paper" || player1 == "paper" && player2 == "scissors" || player1 == "scissors" && player2 == "rock")
      {
        return "Player 2 wins";
      } else if(player2 == "rock" && player1 == "paper" || player2 == "paper" && player1 == "scissors" || player2 == "scissors" && player1 == "rock")
      {
        return "Player 1 wins";
      } else 
      {
        return "";
      }
    }
    public List<int> GetPrimes()
    {
      // logic
      int n = Number;
      bool add = true;
      List<int> primeList = new List<int> { 2, 3, 5, 7 };
      List<int> result = new List<int> { };
      for (int i = 2; i <= n; i++)
      {
        add = true;
        foreach (int num in primeList)
        {
          if (i % num == 0 && i != num)
          {
            add = false;
            break;
          }
        }
        if (add)
        {
          result.Add(i);
        }
      }

      return result;
    }
  }
}
