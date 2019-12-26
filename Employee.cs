using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculater
{
    public class Employee
    {

        public int Id { get; set; }
        public string Role { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public double Bonus { get => CalculateBonus(); }

        private double CalculateBonus()
        {
            switch (this.Role)
            {
                case "Executive":
                    return this.Salary * .20;
                case "Supervisor":
                    return this.Salary * .10;
                case "Manager":
                    return this.Salary * .08;
                case "Employee":
                    return this.Salary * .05;
                default:
                    return 0;
            }
        }
    }
}
