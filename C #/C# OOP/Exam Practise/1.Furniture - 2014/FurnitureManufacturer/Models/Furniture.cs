namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less or equal to zero");
                }
                this.height = value;
            }
        }

        public virtual string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty or null");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be less than 3 symbols");
                }
                this.model = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to zero");
                }
                this.price = value;
            }
        }

        public virtual string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }
        }

        protected MaterialType MaterialType { get; set; }
    }
}
