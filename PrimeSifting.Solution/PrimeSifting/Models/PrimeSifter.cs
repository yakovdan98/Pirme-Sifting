using System;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class PrimeSifter
  {
    // properties, constructors, methods, etc. go here
    public int Number {get; set;}

    // constructor
    public PrimeSifter(int userInput)
    {
      Number = userInput;
    }

    // get primes
    public List<int> GetPrimes()
    {
      // logic
      int n = Number;
      List<int> result = new List<int> {};
      for (int i = 2; i <= n; i++)
      {
        // if(i % 2 == 0 && i != 2)
        // {
        //   continue;
        // }
        // else if (i % 3 == 0 && i != 3) 
        // {
        //   continue;
        // }
        // else if (i % 5 == 0 && i != 5)
        // {
        //   continue;
        // }
        // else if (i % 7 == 0 && i != 7) 
        // {
        //   continue;
        // }
        result.Add(i);
      }
      
      return result;
    }
  }
}
