namespace ArvEmployment
{
    class BaseAndCommissionEmployee : CommissionEmployee
    {
        protected double monthlySalary;

        public BaseAndCommissionEmployee(string name, double commission, double sales, double monthlySalary) 
            : base(name, commission, sales)
        {
            this.monthlySalary = monthlySalary;
        }
        protected override double CalculateSalary()
        {
            return ((commission / 100) * sales) + monthlySalary;
        }

        public override string ToString()
        {
            return name + "\nCommission Employee" + "\nCommission: " + commission + "%" + "\nSales: " + sales
                + "\nMonthly Salary: " + monthlySalary + "\nSalery: " + CalculateSalary();
        }
    }
}
