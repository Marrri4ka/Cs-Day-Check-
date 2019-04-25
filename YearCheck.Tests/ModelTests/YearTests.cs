using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Year.Models;

namespace Year.Tests
{
  [TestClass]
  public class DateTest
  {
    [TestMethod]
    public void DateTest()
    {
      //Arrange
      DateTime newDateTime = new DateTime (9,9,9);

      //Act
      string result = newDateTime.GetDay();
      // Assert

      Assert.AreEqual (result, "")

    }
  }
}
