﻿namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IChair
    {
      public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
      {
          this.Model = model;
          this.MaterialType = materialType;
          this.Price = price;
          this.Height = height;
          this.NumberOfLegs = numberOfLegs;
      }
  
     public int NumberOfLegs { get; protected set; }

     public override string ToString()
     {
         return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}", 
             this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
     }
    }
}
