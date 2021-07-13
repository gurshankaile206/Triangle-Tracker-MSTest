namespace Triangle
{
  public class TriangleTracker
  {
    public int Side1 { get; set; }
    public int Side2 { get; set; }
    public int Side3 { get; set; }

    public TriangleTracker(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }
    public string IsTriangleTracker()
    {
      //if (Side1)
      return "Triangle";
    }
  }
}