using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InheritanceClasses
{
  // 1) derived class
  // 2) base class
  //            1       2
  public class Cat : Animal
  {
    public Cat(double clawLength, int numberOfLegs, bool isMammal, bool hasFur, DietType typeOfDiet) : base(numberOfLegs, isMammal, hasFur, typeOfDiet)
    {
      ClawLength = clawLength;

      Console.WriteLine("This is the Cat constructor.");
    }
    public double ClawLength { get; set; }
    public virtual void MakeSound()
    {
      Console.WriteLine("Meow.");
    }

    // Access the base class's Move method
    public override void Move()
    {
      base.Move(); // This {Type.Name} moves.
      Console.WriteLine("It moves quickly!");
    }
  }

  public class RagdollCat : Cat
  {
    public RagdollCat(double clawLength, int numberOfLegs, bool isMammal, bool hasFur, DietType typeOfDiet) : base(clawLength, numberOfLegs, isMammal, hasFur, typeOfDiet)
    {
      Console.WriteLine("This is the RagdollCat constructor.");
    }
    public override void MakeSound()
    {
      Console.WriteLine("Purrrr.");
    }

    // public override void Move()
    // {
    //   Console.WriteLine($"The {GetType().Name} meanders across the floor.");
    // }
  }

}