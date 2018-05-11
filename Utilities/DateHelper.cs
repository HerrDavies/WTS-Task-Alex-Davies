using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utilities
{
    public class DateHelper
    {
        public static int HoursDifference_Calculate(DateTime start, DateTime end)
        {
            return (end - start).Hours;
        }
    }
}
