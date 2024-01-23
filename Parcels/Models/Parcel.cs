namespace Parcel.Models
{
  public class Package
  {
    public int[] Properties { get; }
    public Package(int[] properties)
    {
      Properties = properties;
    }
  }
}