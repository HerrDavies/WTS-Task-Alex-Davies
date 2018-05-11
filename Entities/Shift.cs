using System;

namespace Common.Entities
{
    public class Shift
    {
        int shiftID { get; set; }

        public int ShiftID
        {
            get { return shiftID; }
            set { shiftID = value; }
        }


        string shiftName { get; set; }

        public string ShiftName
        {
            get { return shiftName; }
            set { shiftName = value; }
        }


        DateTime start { get; set; }

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }


        DateTime end { get; set; }

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }
    }
}
