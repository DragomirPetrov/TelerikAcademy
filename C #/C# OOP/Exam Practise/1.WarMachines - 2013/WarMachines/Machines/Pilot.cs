namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Null machine cannot be added to pilot");
            }

            this.machines.Add(machine);
        }

        public string Report()
        {

            var sortedMachines = this.machines
                .OrderBy(m => m.HealthPoints)
                .ThenBy(m => m.Name);

            var noMachines = 
                this.machines.Count > 0 
                ? this.machines.Count.ToString() 
                : "no";

            var pluralMachines =
                this.machines.Count == 1
                ? "machine"
                : "machines";

            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} {2}", this.Name, noMachines, pluralMachines));

            foreach (var machine in sortedMachines)
            {
                result.AppendLine(machine.ToString());
            }

            return result.ToString().Trim();

        }
    }
}
