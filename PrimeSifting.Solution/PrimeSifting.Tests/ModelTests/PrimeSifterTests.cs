using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeSifterTests
  {
    [TestMethod]
    // Test methods will go here
    public void SifterConstructor_CreatesInstanceOfSifter_Sifter()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // Template: ``` Assert.AreEqual(EXPECTED_RESULT, CODE_TO_TEST); ```
      PrimeSifter sifter = new PrimeSifter(12);
      Assert.AreEqual(typeof(PrimeSifter), sifter.GetType());
    }

    [TestMethod]
    public void GetPrimes_ReturnsEmptyList_List()
    {
      // Arrange
      List<int> controlList = new List<int> {};
      // Act
      PrimeSifter sifter = new PrimeSifter(1);
      List<int> testList = sifter.GetPrimes();
      // Assert
      CollectionAssert.AreEqual(controlList, testList); 
    }

    [TestMethod]
    public void GetPrimes_ReturnListOfNumbersUpToInput_NumbersList()
    {
      // Arrange
      List<int> controlList = new List<int> {2,3,4,5};
      // Act
      PrimeSifter sifter = new PrimeSifter(5);
      // Assert
      CollectionAssert.AreEqual(controlList, sifter.GetPrimes());
    }
  }
}