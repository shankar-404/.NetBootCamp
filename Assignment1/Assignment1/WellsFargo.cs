using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class WellsFargo : GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        int salary;

        public WellsFargo(int empid, string name, string dept, string desg, int salary) 
        {
            this.empid = empid;
            this.name = name;   
            this.dept = dept;
            this.desg = desg;   
            this.salary = salary;   
        }

        
        public double EmployeePF()
        {
            double pfEmployee = (12 / 100) * this.salary;
            double pfEmployer = (12 / 100) * this.salary;
            double pensionFund = (3.67 / 100) * this.salary;
            return pfEmployee + pfEmployer;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity = 0;
            return gratuity;
        }

        public string LeaveDetails()
        {
            int casual = 2;
            int sick = 5;
            int privelage = 5;

            return $"Casual:{casual} || Sick:{sick} || Privelage:{privelage}";
        }
    }
}
