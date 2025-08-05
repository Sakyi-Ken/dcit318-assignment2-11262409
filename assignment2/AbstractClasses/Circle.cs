using System;
namespace Assignment2.AbstractClasses
{
  public class Circle : Shape
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
}