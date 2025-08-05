using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            bool valid1 = double.TryParse(Console.ReadLine(), out double side1);
            Console.Write("Enter side 2: ");
            bool valid2 = double.TryParse(Console.ReadLine(), out double side2);
            Console.Write("Enter side 3: ");
            bool valid3 = double.TryParse(Console.ReadLine(), out double side3);

            if (valid1 && valid2 && valid3 && side1 > 0 && side2 > 0 && side3 > 0)
            {
                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. All sides must be positive numbers.");
            }
        }
    }
}
