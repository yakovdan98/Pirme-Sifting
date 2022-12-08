using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeSifting.Models
{
  public class Dog : IAnimal
  {
    public string IAm()
    {
      return "dog";
    }
  }
}