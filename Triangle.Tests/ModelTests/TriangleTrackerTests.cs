using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle; 


namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    // [TestMethod]
    // public void IsTriangleTracker_CreateTriangleWithThreeLengths_Triangle()
    // {
    //   TriangleTracker testTriangle = new TriangleTracker(); 
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual("Triangle", testTriangle.IsTriangleTracker());
    // }
    [TestMethod]
    public void IsTriangleTracker_CheckForTypeOfTriangle_Isosceles()
    {
      TriangleTracker testTriangle = new TriangleTracker(4,4,5);
      Assert.AreEqual("Isosceles", testTriangle.IsTriangleTracker());
    }
    [TestMethod]
    public void IsTriangleTracker_CheckForTypeOfTriangle_Equilateral()
    {
      TriangleTracker testTriangle = new TriangleTracker(3,3,3);
      Assert.AreEqual("Equilateral", testTriangle.IsTriangleTracker());
    }
    [TestMethod]
    public void IsTriangleTracker_CheckForTypeOfTriangle_Scalene()
    {
      TriangleTracker testTriangle = new TriangleTracker(3,5,7);
      Assert.AreEqual("Scalene", testTriangle.IsTriangleTracker());
    }
  }
}
