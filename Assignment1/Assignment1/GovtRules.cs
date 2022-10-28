using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal interface GovtRules
    {
        public double EmployeePF();
        public string LeaveDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }
}
