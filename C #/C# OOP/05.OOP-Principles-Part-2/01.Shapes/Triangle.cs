namespace Shapes 
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            base.Width = width;
            base.Height = height;
        }

        public override double CalculateSurface()
        {

            return (base.Width / 2) * base.Height;

        }
    }
}
