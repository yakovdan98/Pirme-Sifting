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
      List<int> controlList = new List<int> {2,3};
      // Act
      PrimeSifter sifter = new PrimeSifter(3);
      // Assert
      CollectionAssert.AreEqual(controlList, sifter.GetPrimes());
    }

    [TestMethod]
    public void GetPrimes_ReturnListOfPrimes_NumbersList()
    {
      // Arrange
      List<int> controlList = new List<int> {2,3,5,7,11,13,17,19};
      // Act
      PrimeSifter sifter = new PrimeSifter(20);
      // Assert
      CollectionAssert.AreEqual(controlList, sifter.GetPrimes());
    }

    [TestMethod]
    public void RockPaperScissors_ReturnIfItsaDraw_True()
    {
      // Arrange
      string player1 = "rock";
      string player2 = "rock";
      // Act
      string result = PrimeSifter.RockPaperScissors(player1, player2);
      // Assert
      Assert.AreEqual("It's a tie", result);
    }

    [TestMethod]
    public void RockPaperScissors_ReturnIfPaperBeatsRock_Player2Wins()
    {
      // Arrange
      string player1 = "rock";
      string player2 = "paper";
      // Act
      string result = PrimeSifter.RockPaperScissors(player1, player2);
      // Assert
      Assert.AreEqual("Player 2 wins", result);
    }

    [TestMethod]
    public void RockPaperScissors_ReturnIfRockBeatsScissors_Player2Wins()
    {
      // Arrange
      string player1 = "rock";
      string player2 = "paper";
      // Act
      string result = PrimeSifter.RockPaperScissors(player1, player2);
      // Assert
      Assert.AreEqual("Player 2 wins", result);
    }

    [TestMethod]
    public void RockPaperScissors_ReturnIfScissorsBeatPaper_Player1Wins()
    {
      // Arrange
      string player1 = "scissors";
      string player2 = "paper";
      // Act
      string result = PrimeSifter.RockPaperScissors(player1, player2);
      // Assert
      Assert.AreEqual("Player 1 wins", result);
    }
  }
}