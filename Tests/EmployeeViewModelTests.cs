using Core;
using Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class EmployeeViewModelTests
    {
        private EmployeeViewTests o;

        [TestInitialize]
        public void TestInitialize()
        {
            o = new EmployeeViewModel(null);
        }

        [TestMethod]
        public void SalaryColorIsRedByDefaultTest()
        {
            Assert.AreEqual("red", o.SalaryColor);
        }

        [TestMethod]
        public void SalaryColorIsRedIfSetColorArgumentIsNullTest()
        {
            o.setColor(null);
            Assert.AreEqual("red", o.SalaryColor);
        }

        [TestMethod]
        public void SalaryColorIsYellowForHighSalariesTest()
        {
            o.setColor(new Employee(null, null, 15001));
            Assert.AreEqual("yellow", o.SalaryColor);
        }
    }
}
