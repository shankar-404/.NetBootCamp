using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class TCS:GovtRules
    {
        int empid { get; set; }
        string name { get; set; }
        string dept { get; set; }
        string desg { get; set; }
        int salary { get; set; }

        public TCS(int empid, string name, string dept, string desg, int salary)
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
            double pfEmployer = (8.33 / 100) * this.salary;
            double pensionFund = (3.67 / 100) * this.salary;
            return pfEmployee + pfEmployer;
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity;
            if (serviceCompleted < 5)
            {
                gratuity = 0;
            }
            else if (serviceCompleted > 5)
            {
                gratuity = basicSalary;
            }
            else if (serviceCompleted > 10)
            {
                gratuity = 2 * basicSalary;
            }
            else
            {
                gratuity = 3 * basicSalary;
            }
            return gratuity;
        }

        public string LeaveDetails()
        {
            int casual = 1;
            int sick = 12;
            int privelage = 10;

            return $"Casual:{casual} || Sick:{sick} || Privelage:{privelage}";
        }
    }
}
