using System.Collections.Generic;

namespace Parcel.Models
{
  public class Package
  {
    public Dictionary<string, int> Properties { get; set; }
    public Package(Dictionary<string, int> properties)
    {
      Properties = properties;
    }

    public int Volume()
    {
     return (Properties["height"])*(Properties["length"])*(Properties["width"]);
    }
  }
}