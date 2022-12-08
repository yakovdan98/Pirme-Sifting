using System.Collections.Generic;
using PrimeSifting.Models;
using System;

class Sample
{
  public static void Main()
  {
    List<IAnimal> animals = new List<IAnimal>();
    animals.Add(new Dog());
    animals.Add(new Cat());
    animals.Add(new Dog());
    animals.Add(new Cat());
    animals.Add(new Dog());
    animals.Add(new Cat());
    foreach (var item in animals)
    {
        Console.WriteLine(item.IAm());
    }
  }

}