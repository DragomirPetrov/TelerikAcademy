using System;

namespace _10.PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            bool circle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (r * r);
            bool rectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            if ((circle == true) && (rectangle == true))
            {
                Console.WriteLine("inside circle" + " " + "inside rectangle");
            }
            else if (!(circle == true) && (rectangle == true))
            {
                Console.WriteLine("outside circle" + " " + "inside rectangle");
            }
            else if ((circle == true) && !(rectangle == true))
            {
                Console.WriteLine("inside circle" + " " + "outside rectangle");
            }
            else if (!(circle == true) && !(rectangle == true))
            {
                Console.WriteLine("outside circle" + " " + "outside rectangle");
            }
        }
    }
}
