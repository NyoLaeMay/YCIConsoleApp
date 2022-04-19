using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH18
{
    public class FullTimeStaff:Staff,IPayrollServiceForFullTime

    {
        public double CalculatePayroll(int basicPay, int workingDays, int attendanceDays, int benefit, int deduction)
        {
            double payrollFull = ((basicPay / workingDays) * attendanceDays) + benefit - deduction;
            return payrollFull;
        }
    }
}
