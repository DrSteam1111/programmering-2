using System;
using System.Collections.Generic;
using System.Text;

namespace ArvEmployment
{
    class EmployeeDatabase
    {
        List<Employee> employees = new List<Employee>();

        public void Run()
        {
            employees.Add(new CommissionEmployee("Ada", 5, 200000));
            employees.Add(new FullTimeEmployee("Beda", 32000));
            employees.Add(new HourlyEmployee("Babbage", 200, 40));
            employees.Add(new BaseAndCommissionEmployee("Carl", 3, 400000, 10000));

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine();
            }
        }
    }
}
