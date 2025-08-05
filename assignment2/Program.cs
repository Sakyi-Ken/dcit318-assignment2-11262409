using System;
using Assignment2.AbstractClasses;

namespace Assignment2
{
  interface IMovable
  {
    void Move();
  }

  class Car : IMovable
  {
    public void Move()
    {
      Console.WriteLine("Car is moving");
    }
  }

  class Bicycle: IMovable
  {
    public void Move()
    {
      Console.WriteLine("Bicycle is moving");
    }
  }

  class Program
  {
    static void Main()
    {
      Console.WriteLine("n===Assignment 2 Menu ====");
      Console.WriteLine("1. Inheritance & Method Overriding");
      Console.WriteLine("2. Abstract Class");
      Console.WriteLine("3. Interface");
      Console.WriteLine("4. Exit");
      Console.WriteLine("Choose an option: ");

      string? choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          RunInheritance();
          break;
        case "2":
          RunAbstractClass();
          break;
        case "3":
          RunInterface();
          break;
        case "4":
          return;
        default:
          Console.WriteLine("Invalid choice. Please try again.");
          break;
      }
    }

    
    static void RunInheritance()
    {
      Console.WriteLine("\n---Running Inheritance & Method Overriding---");
      Inheritance.Animal animal = new Inheritance.Animal("Domestic Animal");
      Inheritance.Animal dog = new Inheritance.Dog("Puppy");
      Inheritance.Animal cat = new Inheritance.Cat("Kitty");

      animal.MakeSound();
      dog.MakeSound();
      cat.MakeSound();
    }

    static void RunAbstractClass()
    {
      Console.WriteLine("\n---Running Abstract Class---");
      Shape circle = new Circle(3);
      Shape rectangle = new Rectangle(8, 4);

      Console.WriteLine($"Circle area: {circle.GetArea()}");
      Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
    }

    static void RunInterface()
    {
      Console.WriteLine("\n---Running Interface---");
      IMovable car = new Car();
      IMovable bicycle = new Bicycle();

      car.Move();
      bicycle.Move();
    }
  }
}
