using Microsoft.VisualStudio.TestTools.UnitTesting;
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
  }
}