using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// SUM VALUES TEST
        /// </summary>
        [TestMethod]
        public void SumValues()
        {
            //AAA

            //Arrange
            ApplicationCore.Services.Sum sum = new ApplicationCore.Services.Sum();

            //Act
            var result = sum.SumValues(3,4);

            //Assert
            Assert.AreEqual(7, result);
        }
    }
}
