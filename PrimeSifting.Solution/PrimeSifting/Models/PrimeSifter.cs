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
