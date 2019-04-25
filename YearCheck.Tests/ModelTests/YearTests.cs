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
    public void MyDateTest()
    {
      //Arrange
         MyDate newDateTime = new MyDate (1991, 07, 30);

      //Act
      string result = newDateTime.GetDay();
      // Assert

      Assert.AreEqual (result, "Monday");

    }
  }
}
