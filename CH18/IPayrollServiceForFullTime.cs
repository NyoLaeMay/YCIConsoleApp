using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH18
{
    public interface IPayrollServiceForFullTime
    {
        double CalculatePayroll (int basicPay, int workingDays,int attendanceDays,int benefit,int deduction);        

    }
}
