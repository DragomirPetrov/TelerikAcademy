namespace Mobile
{
    using System.Text;

    public class Display
    {
        private double? size;
        private uint? numberOfColors;

        public Display()
        {
            this.Size = null;
            this.NumberOfColors = null;
        }

        public Display(double? size)

        {
            this.Size = size;
        }

        public Display(double? size = null, uint? numberOfColors = null)

        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get { return size; }
            set { size = value; }
        }
        public uint? NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Display size: {this.Size}")
                  .Append($"Number of colours: {this.NumberOfColors}");

            return result.ToString();
        }
    }
}
