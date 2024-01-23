namespace Parcel.Models
{
  public class Package
  {
    public int[] Properties { get; set; }
    public Package(int[] properties)
    {
      Properties = properties;
    }
  }
}