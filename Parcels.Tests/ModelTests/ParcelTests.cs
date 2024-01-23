using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcel.Models;

namespace Parcel.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void PackageConstructor_CreatesInstanceOfPackage_Package()
    {
      Package newPackage = new Package();
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }
  }
}