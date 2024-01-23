using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcel.Models;

namespace Parcel.Tests
{
  [TestClass]
  public class ParcelTests
  {
    Dictionary<string, int> propDictionary = new Dictionary<string, int>() {{"height", 10}, {"length", 5}, {"width", 2}, {"weight", 5}};

    [TestMethod]
    public void PackageConstructor_CreatesInstanceOfPackage_Package()
    {
      Package newPackage = new Package(propDictionary);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnPackagePropertyValues_Int()
    {
      Package newPackage = new Package(propDictionary);
      Dictionary<string, int> result = newPackage.Properties;
      CollectionAssert.AreEqual(propDictionary, result);
    }

    // [TestMethod]
    // public void SetProperties_SetValuesOfProperties_Int()
    // {
    //   Package newPackage = new Package(new int[] {10, 5, 2, 5});
    //   int[] packageProperties = {15, 10, 4, 10};
    //   newPackage.Properties = packageProperties;
    //   int[] result = newPackage.Properties;
    //   CollectionAssert.AreEqual(packageProperties, result);
    // }
  }
}