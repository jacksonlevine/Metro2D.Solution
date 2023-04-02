using Metro2D.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Metro2D.Tests 
{
  [TestClass]
  public class GameStateSingletonTests
  {
    [TestMethod]
    public void GameState_CreatesInstanceOf_GameState()
    {
      GameState g = new GameState();
      Assert.AreEqual(typeof(GameState), g.GetType());
    }
  }
}