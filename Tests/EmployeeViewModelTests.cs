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
    }
}
