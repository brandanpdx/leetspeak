using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class TranslateTests
  {
    [TestMethod]
    public void LeetTranslate_TurnETo3_True()
    {
    Translate newTranslate = new Translate();
    Assert.AreEqual("3", newTranslate.LeetTranslate("e"));
    }
    
    [TestMethod]
    public void LeetTranslate_TurnOTo0_True()
    {
    Translate newTranslate = new Translate();
    Assert.AreEqual("0", newTranslate.LeetTranslate("o"));
    }

    [TestMethod]
    public void LeetTranslate_TurnCapitalITo1_True()
    {
    Translate newTranslate = new Translate();
    Assert.AreEqual("I", newTranslate.LeetTranslate("1"));
    }
  }
}