using System;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Triangel triangel = new Triangel();
            Round round = new Round();
            Shape[] shapes = new Shape[3] { square, triangel, round };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"This is {shape.Name()}. CLR Type is {shape.GetType()}. Square is {shape.Scale()}");
            } 
        }
    }
}
  