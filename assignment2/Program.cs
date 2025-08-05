using System;
namespace Assignment2
{
  class Animal
  {
    public string Name { get; set; }

    public Animal(string name)
    {
      Name = name;
    }

    public virtual void MakeSound()
    {
      Console.WriteLine($"{Name} makes a sound.");
    }
  }

  class Dog : Animal
  {
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
      Console.WriteLine("Bark");
    }
  }

  class Cat : Animal
  {
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
      Console.WriteLine("Meow");
    }
  }

  abstract class Shape
  {
    public abstract double GetArea();
  }

  class Circle : Shape
  {
    public double Radius { get; set; }

    public Circle(double radius)
    {
      Radius = radius;
    }

    public override double GetArea()
    {
      return Math.PI * Radius * Radius;
    }
  }

  class Rectangle : Shape
  {
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
      Width = width;
      Height = height;
    }

    public override double GetArea()
    {
      return Width * Height;
    }
  }

  interface IMovable
  {
    void Move();
  }

  class Car : IMovable
  {
    public void Move()
    {
      Console.WriteLine("Car is moving.");
    }
  }

  class Bicycle : IMovable
  {
    public void Move()
    {
      Console.WriteLine("Bicycle is moving.");
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
      Animal genericAnimal = new Animal("Generic Animal");
      Animal dog = new Dog("Puppie");
      Animal cat = new Cat("Kitty");

      Console.WriteLine($"{genericAnimal.Name} says:");
      genericAnimal.MakeSound();

      Console.WriteLine($"{dog.Name} says:");
      dog.MakeSound();

      Console.WriteLine($"{cat.Name} says:");
      cat.MakeSound();
    }

    static void RunAbstractClass()
    {
      Console.WriteLine("\n---Running Abstract Class---");
      Shape circle = new Circle(5);
      Shape rectangle = new Rectangle(4, 5);

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
