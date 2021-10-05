using System;
using System.Collections.Generic;
using System.Text;

namespace ArvEmployment
{
    class HourlyEmployee : Employee
    {
        protected double hourlySalary;
        protected double workedHours;

        public HourlyEmployee(string name, double hourlySalary, double workedHours) : base(name)
        {
            this.hourlySalary = hourlySalary;
            this.workedHours = workedHours;
        }

        protected override double CalculateSalary()
        {
            return hourlySalary * workedHours;
        }

        public override string ToString()
        {
            return name + "\nHourly Employee" + "\nHourly Salary: " + hourlySalary + "\nWorked Hours: " + workedHours
                + "\nSalary: " + CalculateSalary();
        }
    }
}
