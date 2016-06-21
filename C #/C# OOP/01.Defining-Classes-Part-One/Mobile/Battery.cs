namespace Mobile
{
    using System.Text;

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType bateryType;

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType bateryType = BatteryType.LiIon)
            
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = bateryType;
        }

        public BatteryType BatteryType
        {
            get { return this.bateryType; }
            set { this.bateryType = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            if (this.Model == null)
            {
                result.Append("no batery");
            }
            else
            {
                result.AppendLine(
                    string.Format("Model: {0}", this.Model));
                result.AppendLine(
                    string.Format("Battery Type: {0}", this.BatteryType));
                result.AppendLine(
                    string.Format("Hours Idle: {0}", this.HoursIdle));
                result.Append(
                    string.Format("Hours Talk: {0}", this.HoursTalk));
            }

            return result.ToString();
        }
    }
}