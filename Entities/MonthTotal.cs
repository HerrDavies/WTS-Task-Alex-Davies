namespace Common.Entities
{
    public class MonthTotal
    {
        int year { get; set; }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        int month { get; set; }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }


        string monthName { get; set; }

        public string MonthName
        {
            get { return monthName; }
            set { monthName = value; }
        }


        int hours { get; set; }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
    }
}
