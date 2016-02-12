// Project: Spring2016CS-Polymorphism01
// FileName: BasePlusCommissionEmployee.cs
// Author: F. Moses
// Date: Feb 11, 2016
// Purpose: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr2016CS_Polymorphism01
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary;     // base salary per week

        // Constructor
        // 6-parameter derived class constructor
        public BasePlusCommissionEmployee(string first, string last, string ssn,
            decimal sales, decimal rate, decimal salary) :
            base(first, last, ssn, sales, rate)
        {
            baseSalary = salary;            // validate base salary via the property
        }   // end constructor

        // Property that gets and sets the salary
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }   // end get
            set
            {
                if (value >= 0)
                    baseSalary = value;
                else
                    throw new ArgumentOutOfRangeException(
                        "BaseSalary", value, "BaseSalary must be >= 0");
            }   // end set
        }   // end property BaseSalary

        // Calculate earnings
        public override decimal Earnings()
        {
            return BaseSalary + base.Earnings();
        }   // end Earnings()

        // Return string representation of BasePlusCommissionEmployee

        public override string ToString()
        {
            return string.Format("Base-salaried {0}\nBase salary: {1:C}",
                base.ToString(), BaseSalary);
        }   // end ToString()
    }   // end class
}
