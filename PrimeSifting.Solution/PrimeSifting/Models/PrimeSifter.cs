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
    public static List<int> GetPrimes()
    {
      // logic
      List<int> result = new List<int> {};
      return result;
    }
  }
}
