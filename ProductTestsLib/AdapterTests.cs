using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib.Adapters;
using ProductLib.Interfaces;
using ProductLib.Models;

namespace ProductTestsLib
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void Test_that_the_product_properties_return_correct_values()
        {
            // ARRANGE
            Product p = new Product();
            p.Title = "Glass";
            p.BarCode = "1234";
            p.UnitPrice = 4.5m;
            string expectedTitle = "Glass";
            string expectedBarCode = "1234";
            decimal expectedUnitPrice = 4.5m;
            // ACT
            var result = p;
            // ASSERT
            Assert.AreEqual(expectedTitle, result.Title);
            Assert.AreEqual(expectedBarCode, result.BarCode);
            Assert.AreEqual(expectedUnitPrice, result.UnitPrice);
        }

        [TestMethod]
        public void Test_that_SomExternalVendorProductAdapter_returns_correct_property_values()
        {
            // ARRANGE
            SomeExternalVendorProduct ep = new SomeExternalVendorProduct();
            ep.Description = "Boll";
            ep.EANCode = "1234";
            ep.PricePerUnit = 3.6m;
            // ACT
            IProduct result = new SomeExternalVendorProductAdapter(ep);
            // ASSERT
            Assert.AreEqual(ep.Description, result.Title);
            Assert.AreEqual(ep.EANCode, result.BarCode);
            Assert.AreEqual(ep.PricePerUnit, result.UnitPrice);
        }
    }
}
