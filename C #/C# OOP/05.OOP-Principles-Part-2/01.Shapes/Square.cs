namespace Shapes
{
    public class Square : Shape
    {

        public Square(double width, double height)
        {
            base.Width = width;
            base.Height = height;
        }

        public override double CalculateSurface()
        {

            return base.Width * base.Height;
            
        }
    }
}
