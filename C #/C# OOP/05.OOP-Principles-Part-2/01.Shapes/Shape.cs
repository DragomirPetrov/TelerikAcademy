﻿namespace Shapes
{
    using System;

    public abstract class Shape
    {

        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than zero");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than zero");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

    }
}
