using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Webapp_EventosTest
{
    [TestClass]
    public class LeerExcelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int total = 29;

            //Act
            Test.Models.LeerExcel le = new Test.Models.LeerExcel();
            List<Test.Models.Miembro> lm = le.readExcel();

            //Assert
            Assert.AreEqual(total, lm.Count);
        }
    }
}
