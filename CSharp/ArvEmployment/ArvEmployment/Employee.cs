using System;
using System.Collections.Generic;
using System.Text;

namespace ArvEmployment
{
    abstract class Employee
    {
        protected string name;

        public Employee(string name)
        {
            this.name = name;
        }

        protected abstract double CalculateSalary();
        public override abstract string ToString();
    }
}
