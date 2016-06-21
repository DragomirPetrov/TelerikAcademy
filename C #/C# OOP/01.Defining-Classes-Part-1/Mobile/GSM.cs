namespace Mobile
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class GSM
    {
        //Class Fields//
        private static GSM iPhone4S;

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        //Constructors//
        static GSM()
        {
            iPhone4S = new GSM(
                "iPhone 4S",
                "Apple", 10000.0,
                "Some weird kid",
                new Battery("AppleBattery", 1, 2, BatteryType.NiCd),
                new Display() { Size = 4, NumberOfColors = 16 });
        }

        public GSM(string model, string manufacturer,
            double? price = null, string owner = null)
            : this(model, manufacturer)
        {
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, double price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, string owner)
            : this(model, manufacturer)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer, owner)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery batery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = batery;
            this.Display = display;
        }

        //Properties//
        public static GSM IPhone4S { get { return iPhone4S; } }

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
            set
            {
                if (this.callHistory == null)
                {
                    this.callHistory = new List<Call>();
                }

                this.callHistory.Clear();
                this.callHistory = value;
            }
        }

        public Display Display
        {
            get { return display; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid display info");
                }

                this.display = value;
            }
        }

        public Battery Battery
        {
            get { return battery; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid battery type");
                }

                this.battery = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid owner's name");
                }

                owner = value;
            }
        }

        public double? Price
        {
            get { return price; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid price");
                }

                this.price = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model");
                }

                this.model = value;
            }
        }

        //Methods//
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public void CalculateTotalCost(double fixedPrice)
        {
            ulong totalDuration = 0;
            foreach (Call call in this.callHistory)
            {
                totalDuration += (ulong)call.Duration;
            }

            var result = fixedPrice * (double)(totalDuration / 60);
            Console.WriteLine();
            Console.WriteLine($"The price is: {result} leva.");
            Console.WriteLine();
        }

        public void DisplayCallHistory()
        {
            foreach (var call in callHistory)
            {
                Console.WriteLine(call);
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Model: {0}", this.Model));
            sb.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            sb.AppendLine(string.Format("Price: {0}", this.Price));
            sb.AppendLine(string.Format("Owner: {0}", this.Owner));
            sb.AppendLine(string.Format("Battery: {0}", this.Battery));
            sb.AppendLine(string.Format("Display: {0}", this.Display));

            return sb.ToString();
        }
    }
}
