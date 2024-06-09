using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public abstract class Shape {
        public abstract double getArea();
    }

    public class Circle : Shape {
        double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public override double getArea() {
            return 3.14 * Math.Pow(radius, 2);
        }
    }

    public class Rectangle : Shape {
        double length;
        double width;

        public Rectangle(double length, double width) {
            this.length = length;
            this.width  = width;
        }

        public override double getArea() {
            return length * width;
        }
    }

    internal class Program_03
    {
        //static void Main(string[] args)
        //{

        //    Stack<Shape> stack = new Stack<Shape>();

        //    Circle circle = new Circle(5);
        //    Rectangle rectangle = new Rectangle(2, 5);

        //    stack.Push(circle);
        //    stack.Push(rectangle);

        //    while (stack.Count > 0)
        //    {
        //        Shape shape = stack.Pop();
        //        Console.WriteLine($"Shape Area : {shape.getArea()}");
        //    }

        //    while (true) ;
        //}
    }

}
