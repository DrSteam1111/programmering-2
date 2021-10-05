using System;
using System.Collections.Generic;
using System.Text;

namespace ArvEmployment
{
    class FullTimeEmployee : Employee
    {
        protected double monthlySalary;

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            this.monthlySalary = monthlySalary;
        }
        protected override double CalculateSalary()
        {
            return monthlySalary;
        }

        public override string ToString()
        {
            return name + "\nFull Time Employee" + "\nSalary: " + monthlySalary;
        }
    }
}
