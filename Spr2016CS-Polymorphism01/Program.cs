// Project: Spring2016CS-Polymorphism01
// FileName: Program.cs
// Author: F. Moses
// Date: Feb 11, 2016
// Purpose: To demonstrate the use of polymorphism in classes


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spr2016CS_Polymorphism01
{
    class Program
    {
        static void Main(string[] args)
        {
            // assign base classreference by base class variable
            CommissionEmployee commissionEmployee = new CommissionEmployee(
                "Sue", "Jones", "222-222-2222", 10000.00M, 0.6M);

            // Assign derived class reference to derived class variable
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee(
                "Bob", "Lewis", "333-33-3333", 5000.00M, 300.00M, 300.00M);

            // Invoke ToString and Earnings on base class onhect using base class variable
            Console.WriteLine("{0} {1}:\n\n{2}\n:3}: {4:C}\n",
                "Call CommissionEmployee's ToString and Earnings methods",
                "with base class referenced to base class onhect",
                commissionEmployee.ToString(), "Earnings",
                commissionEmployee.Earnings());

            // Invoke ToString and Earnings on derived class object using derived class variable
            Console.WriteLine("{0} {1}:\n\n{2}\n:3}: {4:C}\n",
                            "Call CommissionEmployee's ToString and Earnings methods",
                            "with base class referenced to base class onhect",
                            basePlusCommissionEmployee.ToString(), "Earnings",
                            basePlusCommissionEmployee.Earnings());

            // Invoke ToString and Earnings on derived class onject using base class variable
            CommissionEmployee commissionEmployee2 = new CommissionEmployee();
            Console.WriteLine("{0} {1}:\n\n{2}\n  {3}: {4:C}\n",
                            "Call BasePlusCommissionEmployee's's ToString and Earnings methods",
                            "with base class referenced to derived class onhect",
                            commissionEmployee2.ToString(), "Earnings",
                            commissionEmployee2.Earnings());


            // BasePlusCommissionEmployee bpcEmployee2 = CommissionEmployee;    
        }   // end main()
    }
}
