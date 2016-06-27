namespace Shapes
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Triangle triangleOne = new Triangle(5.2, 11.8);
            Triangle triangleTwo = new Triangle(3, 9.6);

            Square squareOne = new Square(8.1, 4.4);
            Square squareTwo = new Square(3.9, 14.5);

            Rectangle rectangleOne = new Rectangle(6.6, 9.8);
            Rectangle rectangleTwo = new Rectangle(23.3, 7.2);

            Console.WriteLine("Triangle with parameters: 5.2, 11.8 - Result: {0}", triangleOne.CalculateSurface());
            Console.WriteLine("Triangle with parameters: 3, 9.6 - Result: {0}", triangleTwo.CalculateSurface());
            Console.WriteLine();

            Console.WriteLine("Square with parameters: 8.1, 4.4 - Result: {0}", squareOne.CalculateSurface());
            Console.WriteLine("Square with parameters: 3.9, 14.5 - Result: {0}", squareTwo.CalculateSurface());
            Console.WriteLine();

            Console.WriteLine("Rectangle with parameters: 6.6, 9.8 - Result: {0}", rectangleOne.CalculateSurface());
            Console.WriteLine("Rectangle with parameters: 23.3, 7.2 - Result: {0}", rectangleTwo.CalculateSurface());

        }
    }
}
