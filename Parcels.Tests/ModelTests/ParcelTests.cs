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
    public void GetProperties_ReturnPackagePropertyValues_Dictionary()
    {
      Package newPackage = new Package(propDictionary);
      Dictionary<string, int> result = newPackage.Properties;
      CollectionAssert.AreEqual(propDictionary, result);
    }

    [TestMethod]
    public void SetProperties_SetValuesOfProperties_Dictionary()
    {
      Package newPackage = new Package(propDictionary);
      Dictionary<string, int> newProperties = new Dictionary<string, int>() {{"height", 20}, {"length", 10}, {"width", 4}, {"weight", 10}};
      newPackage.Properties = newProperties;
      Dictionary<string, int> result = newPackage.Properties;
      CollectionAssert.AreEqual(newProperties, result);
    }

    [TestMethod]
    public void Volume_MultiplyPropertiesToFindVolume_Int()
    {
      Package newPackage = new Package(propDictionary);
      int result = 100;
      Assert.AreEqual(newPackage.Volume(), result);
    }

    [TestMethod]
    public void CostToShip_ReturnsCostOfShipping_Double()
    {
      Package newPackage = new Package(propDictionary);
      int volume = newPackage.Volume();
      int weight = newPackage.Properties["weight"];
      double result = (0.25 * (weight)) + (0.25 * (volume)); // 27.50
      Assert.AreEqual(newPackage.CostToShip(), result);
    }
  }
}