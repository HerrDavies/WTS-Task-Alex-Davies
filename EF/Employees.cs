using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class Employees : Interfaces.IEmployees
    {
        static WTSDatabase _dataContext = null;
        static WTSDatabase DataContext
        {
            get
            {
                if (_dataContext == null)
                {
                    _dataContext = new WTSDatabase();
                }
                return _dataContext;
            }
        }

        public List<Common.Entities.Employee> Employees_Get()
        {
            var arrEmployees = DataContext.Employees.ToList();

            return arrEmployees.Select(x => new Common.Entities.Employee()
            {
                Employee_ID = x.Employee_ID,
                FirstName = x.FirstName,
                Surname = x.Surname,
                Shifts = x.Shifts.Select(s => new Common.Entities.Shift()
                {
                    ShiftID = s.Shift_ID,
                    ShiftName = s.Shift_Name,
                    Start = s.Shift_Start,
                    End = s.Shift_End
                }).ToList()
            }).ToList();
        }
    }
}
