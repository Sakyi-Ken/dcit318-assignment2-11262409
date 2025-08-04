// class Person
// {
//   // private string name;
//   // public string Name 
//   // {
//   //   get { return name; } // getter
//   //   set { name = value; } // setter
//   // }

//   // auto-implemented properties
//   public string Name { get; set; }
//   //private int age;
//   // public int Age
//   // { return age; }
//   // set 
//   // { 
//   // if (value >= 0)
//   //    age = value; 
//   // else
//   //   throw new ArgumentException("Age cannot be negative.");
//   //}
//   public int Age { get; set; }

//   public Person(string name, int age)
//   {
//     Name = name;
//     Age = age;
//   }

//   public void Introduce()
//   {
//     Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     // Without a constructor
//     // Person p1 = new Person();
//     // p1.Name = "Emman";
//     // p1.Age = 20;

//     Person p1 = new Person("Emman", 20);
//     p1.Introduce();
//   }
// }

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
      Animal genericAnimal = new Animal("Generic Animal");
      Animal dog = new Dog("Puppie");
      Animal cat = new Cat("Kitty");

      Console.WriteLine($"{genericAnimal.Name} says:");
      genericAnimal.MakeSound();

      Console.WriteLine($"{dog.Name} says:");
      dog.MakeSound();

      Console.WriteLine($"{cat.Name} says:");
      cat.MakeSound();

      Shape circle = new Circle(5);
      Shape rectangle = new Rectangle(4, 5);

      Console.WriteLine($"Circle area: {circle.GetArea()}");
      Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

      IMovable car = new Car();
      IMovable bicycle = new Bicycle();

      car.Move();
      bicycle.Move();
    }
  }
}
