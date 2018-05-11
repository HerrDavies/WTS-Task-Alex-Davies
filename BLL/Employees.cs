using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BLL
{
    public class Employees
    {
        public static List<Common.Entities.MonthTotal> MonthlyTotals_Generate(List<Common.Entities.Shift> shifts)
        {
            List<Common.Entities.MonthTotal> arrTotals = new List<Common.Entities.MonthTotal>();
            
            arrTotals.AddRange(shifts
                .GroupBy(x => new { x.Start.Year, x.Start.Month })
                .Select(x => new Common.Entities.MonthTotal()
                {
                    Year = x.Key.Year,
                    Month = x.Key.Month,
                    MonthName = new DateTime(DateTime.Now.Year, x.Key.Month, DateTime.Now.Day).ToString("MMMM"),
                    Hours = x.Sum(y => Common.Utilities.DateHelper.HoursDifference_Calculate(y.Start, y.End))
                })
                .ToList());

            return arrTotals;
        }

        public static List<Common.Entities.Employee> test()
        {
            List<Common.Entities.Employee> arrEmployees = new EF.Employees().Employees_Get();

            foreach (var employee in arrEmployees)
            {
                employee.MonthTotals = MonthlyTotals_Generate(employee.Shifts);
            }

            return arrEmployees;
        }
    }
}
