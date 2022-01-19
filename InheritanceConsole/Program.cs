using System;
using InheritanceClasses;

namespace InheritanceConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      // Animal animalOne = new Animal();
      // animalOne.Move(); // This Animal moves.

      // Cat catOne = new Cat();
      // catOne.Move();
      // catOne.MakeSound();

      // Animal catTwo = new Cat();
      // // catTwo.MakeSound(); // <-- this does not work

      // RagdollCat rome = new RagdollCat();
      // Cat whiskers = new RagdollCat();

      // Console.WriteLine("------------------");

      // Animal snickers = new RagdollCat();
      // snickers.ClawLength = 4.5;
      // // snickers.MakeSound(); // <-- this does not work

      // rome.Move();
      // whiskers.MakeSound();


      // Animal constructort (base class)
      Animal genericAnimal = new Animal(6, false, true, DietType.Omnivore);
      // Console.WriteLine(genericAnimal.NumberOfLegs);
      // genericAnimal.Move();

      // Animal secondAnimal = new Animal();

      // Cat constructor (derived from Animal)

      Cat snickers = new Cat(4.5, 4, true, true, DietType.Carnivore);
      // snickers.MakeSound();


    }
  }
}
