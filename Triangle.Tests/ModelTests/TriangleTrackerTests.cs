using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle; 


namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
public void IsTriangleTracker_CreateTriangleWithThreeLengths_Triangle()
{
  TriangleTracker testTriangle = new TriangleTracker(2,4,5); 
  // any necessary logic to prep for test; instantiating new classes, etc.
  Assert.AreEqual("Triangle", testTriangle.IsTriangleTracker());
}

  }
}
