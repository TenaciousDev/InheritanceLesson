using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceClasses
{
  public enum DietType { Herbivore = 1, Omnivore = 5, Carnivore = 3 }
  public class Animal
  {
    public Animal() { }
    public Animal(int numberOfLegs, bool isMammal, bool hasFur, DietType typeOfDiet)
    {
      NumberOfLegs = numberOfLegs;
      IsMammal = isMammal;
      HasFur = hasFur;
      TypeOfDiet = typeOfDiet;

      Console.WriteLine("This is the Animal constructor.");
    }
    public int NumberOfLegs { get; set; }
    public bool IsMammal { get; set; }
    public bool HasFur { get; set; }
    public DietType TypeOfDiet { get; set; }

    public virtual void Move()
    {
      Console.WriteLine($"This {GetType().Name} moves."); // This Animal moves.
    }

  }
}