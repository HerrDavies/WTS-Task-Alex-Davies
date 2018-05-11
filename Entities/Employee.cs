using System.Collections.Generic;

namespace Common.Entities
{
    public class Employee
    {
        int employee_ID { get; set; }

        public int Employee_ID
        {
            get { return employee_ID; }
            set { employee_ID = value; }
        }


        string firstName { get; set; }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        string surname { get; set; }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }


        List<Shift> shifts { get; set; }

        [Newtonsoft.Json.JsonIgnore] // don't send this to the client
        public List<Shift> Shifts
        {
            get { return shifts; }
            set { shifts = value; }
        }


        List<MonthTotal> monthTotals { get; set; }

        public List<MonthTotal> MonthTotals
        {
            get { return monthTotals; }
            set { monthTotals = value; }
        }
    }
}
