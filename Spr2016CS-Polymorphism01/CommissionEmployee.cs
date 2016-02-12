// Project: Spring2016CS-Polymorphism01
// FileName: CommissionEmployee.cs
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
    class CommissionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;             // gross weely sales
        private decimal commissionRate;         // commission percentage

        // 5-parameter constructor
        public CommissionEmployee(string first, string last, string ssn,
            decimal sales, decimal rate)
        {
            // implicit call to "object" constructor
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            grossSales = sales;                 // validate through the property
            commissionRate = rate;              // validate through the property
        }   // end constructor

        // Read-only property
        public string FirstName
        {
            get
            {
                return firstName;
            }   // end get
        }   // end property FirstName

        public string LastName
        {
            get
            {
                return lastName;
            }   // end get
        }   // end property LastName

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }   // end get
        }   // end property SocialSecurityNumber

        // Property the gets and sets commission emplyee's gross sales
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }   // end get
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException(
                        "GrossSales", value, "GrossSales must be >= 0");
            }   // end set
        }   // end property GrossSales

        // Property that gets and sets commission rate
        public decimal CommissionRate
        {
            get
            {
                return commissionRate;
            }   // end get
            set
            {
                if (value >= 0 && value < 1)
                    throw new ArgumentOutOfRangeException(
                        "CommissionRate", value,
                        "CommissionRate must be > 0 and < 1");
            }   // end set
        }   // end property CommissionRate

        // Calculate commission employee's pay
        public virtual decimal Earnings()
        {
            return commissionRate * GrossSales;
        }   // end Earnings()

        // To return string representation to CommissionEmployee object
        public override string ToString()
        {
            return string.Format(
                "{0}: {1} {2}\n{3}: {4}\n{5}: {6}\n{7}: {8:F2}",
                "CommissionEmplyee", FirstName, LastName,
                "Social securty number", SocialSecurityNumber,
                "Gross slaes", GrossSales, "Commission rate", CommissionRate);
        }   // end toString()
    }   // end class
}
