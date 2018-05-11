using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Business.BLL.Tests
{
    [TestClass]
    public class EmployeesTests
    {
        [TestMethod]
        public void HoursCalculateForMonthIsCorrect()
        {
            #region One Shift - Jan 2017

            var Test1Expected = new List<Common.Entities.MonthTotal>() {
                new Common.Entities.MonthTotal()
                {
                     Hours = 3,
                      Month = 1,
                       Year=2017
                }
            };

            var Test1Actual = Business.BLL.Employees.MonthlyTotals_Generate(new System.Collections.Generic.List<Common.Entities.Shift>()
            {
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                      ShiftName="Test",
                       Start=new DateTime(2017,1,1,9,0,0),
                       End=new DateTime(2017,1,1,12,0,0)
                }
            });

            Assert.AreEqual(Test1Expected[0].Hours, Test1Actual[0].Hours);
            Assert.AreEqual(Test1Expected[0].Month, Test1Actual[0].Month);
            Assert.AreEqual(Test1Expected[0].Year, Test1Actual[0].Year);

            #endregion

            #region Three Shifts - April 2017

            var Test2Expected = new List<Common.Entities.MonthTotal>() {
                new Common.Entities.MonthTotal()
                {
                     Hours = 19,
                      Month = 4,
                       Year=2017
                }
            };

            var Test2Actual = Business.BLL.Employees.MonthlyTotals_Generate(new System.Collections.Generic.List<Common.Entities.Shift>()
            {
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                      ShiftName="Test",
                       Start=new DateTime(2017,4,3,9,0,0),
                       End=new DateTime(2017,4,3,17,0,0)
                },
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                      ShiftName="Test",
                       Start=new DateTime(2017,4,20,9,0,0),
                       End=new DateTime(2017,4,20,17,0,0)
                },
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                      ShiftName="Test",
                       Start=new DateTime(2017,4,21,9,0,0),
                       End=new DateTime(2017,4,21,12,0,0)
                }
            });

            Assert.AreEqual(Test2Expected[0].Hours, Test2Actual[0].Hours);
            Assert.AreEqual(Test2Expected[0].Month, Test2Actual[0].Month);
            Assert.AreEqual(Test2Expected[0].Year, Test2Actual[0].Year);

            #endregion

            #region Two Months, Five Shifts - Jun/Jul 2017

            var Test3Expected = new List<Common.Entities.MonthTotal>() {
                new Common.Entities.MonthTotal()
                {
                     Hours = 19,
                     Month = 6,
                     Year = 2017
                },
                new Common.Entities.MonthTotal()
                {
                     Hours = 6,
                     Month = 7,
                     Year = 2017
                }
            };

            var Test3Actual = Business.BLL.Employees.MonthlyTotals_Generate(new System.Collections.Generic.List<Common.Entities.Shift>()
            {
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                     ShiftName="Test",
                     Start=new DateTime(2017,6,27,9,0,0),
                     End=new DateTime(2017,6,27,17,0,0)
                },
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                     ShiftName="Test",
                     Start=new DateTime(2017,6,20,9,0,0),
                     End=new DateTime(2017,6,20,17,0,0)
                },
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                     ShiftName="Test",
                     Start=new DateTime(2017,7,21,9,0,0),
                     End=new DateTime(2017,7,21,12,0,0)
                },
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                     ShiftName="Test",
                     Start=new DateTime(2017,6,21,9,0,0),
                     End=new DateTime(2017,6,21,12,0,0)
                },
                new Common.Entities.Shift()
                {
                     ShiftID = 0,
                     ShiftName="Test",
                     Start=new DateTime(2017,7,1,9,0,0),
                     End=new DateTime(2017,7,1,12,0,0)
                }
            });

            Assert.AreEqual(Test3Expected[0].Hours, Test3Actual[0].Hours);
            Assert.AreEqual(Test3Expected[0].Month, Test3Actual[0].Month);
            Assert.AreEqual(Test3Expected[0].Year, Test3Actual[0].Year);

            Assert.AreEqual(Test3Expected[1].Hours, Test3Actual[1].Hours);
            Assert.AreEqual(Test3Expected[1].Month, Test3Actual[1].Month);
            Assert.AreEqual(Test3Expected[1].Year, Test3Actual[1].Year);

            #endregion
        }
    }
}