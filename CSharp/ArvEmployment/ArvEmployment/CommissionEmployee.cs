using System;
using System.Collections.Generic;
using System.Text;

namespace ArvEmployment
{
    class CommissionEmployee : Employee
    {
        protected double commission;
        protected double sales;

        public CommissionEmployee(string name, double commission, double sales) : base(name)
        {
            this.commission = commission;
            this.sales = sales;
        }

        protected override double CalculateSalary()
        {
            return (commission / 100) * sales;
        }

        public override string ToString()
        {
            return name + "\nCommission Employee" + "\nCommission: " + commission + "%" + "\nSales: " + sales
                + "\nSalery: " + CalculateSalary();
        }
    }
}
