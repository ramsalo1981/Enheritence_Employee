using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAEnheritance
{
    public class Maintenance : Employee
    {
        private const decimal Hardship = 100m;

        public Maintenance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {

        }
        protected override decimal Calculate()
        {
            return base.Calculate() + Hardship;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"\nHardship: ${Math.Round(Hardship, 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.Calculate(), 2):N0}";
        }
    }
}
