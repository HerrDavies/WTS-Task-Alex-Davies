using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Utilities.Tests
{
    [TestClass]
    public class DateHelperTests
    {
        [TestMethod]
        public void HoursBetweenTwoDateTimesIsCorrect()
        {
            DateTime currentTime = DateTime.Now;

            // Zero hours difference
            int Test1Expected = 0;
            Assert.AreEqual(Test1Expected, Common.Utilities.DateHelper.HoursDifference_Calculate(currentTime, currentTime));


            // Three hours difference
            int Test2Expected = 3;
            Assert.AreEqual(Test2Expected, Common.Utilities.DateHelper.HoursDifference_Calculate(currentTime, currentTime.AddHours(3)));


            // Ten hours difference
            int Test3Expected = 10;
            Assert.AreEqual(Test3Expected, Common.Utilities.DateHelper.HoursDifference_Calculate(currentTime, currentTime.AddHours(10)));


            // Minus four hours difference
            int Test4Expected = -4;
            Assert.AreEqual(Test4Expected, Common.Utilities.DateHelper.HoursDifference_Calculate(currentTime.AddHours(4), currentTime));
        }
    }
}
