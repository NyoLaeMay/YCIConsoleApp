using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH18
{
    public interface IPayrollServiceForPartTime
    {
        double CalculatePayrollForPartTime(int AmountOfPerHour, int WorkingHours, int benefit);
    }
}
