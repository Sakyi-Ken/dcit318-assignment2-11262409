using System;
namespace Assignment2
{
  public class Inheritance
  {
   
    public class Animal 
    {
      public string Name { get; set; }

      public Animal(string name)
      {
        Name = name;
      }

      public virtual void MakeSound() 
      {
        Console.WriteLine($"{Name} makes Some generic sound.");
      }
    }

    public class Dog : Animal
    {
      public Dog(string name) : base(name) { }

      public override void MakeSound()
      {
        Console.WriteLine($"{Name} barks.");
      }
    }

    public class Cat : Animal
    {
      public Cat(string name) : base(name) { }

      public override void MakeSound()
      {
        Console.WriteLine($"{Name} cries Meow.");
      }
    }
  }
}