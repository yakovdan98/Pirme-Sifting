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
        result.Add(i);
      }
      
      return result;
    }
  }
}
