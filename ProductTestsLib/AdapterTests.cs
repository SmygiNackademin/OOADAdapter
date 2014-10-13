using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib.Adapters;
using ProductLib.Models;

namespace ProductTestsLib
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void Test_that_the_product_property_title_returns_correct_value()
        {
            // ARRANGE
            Product p = new Product();
            p.Title = "Glass";
            string expectedValue = "Glass";
            // ACT
            var result = p;
            // ASSERT
            Assert.AreEqual(expectedValue, result.Title);
        }

        [TestMethod]
        public void Test_that_SomExternalVendorProductAdapter_returns_correct_value_for_the_property_title()
        {
            // ARRANGE
            SomeExternalVendorProduct ep = new SomeExternalVendorProduct();
            ep.Description = "Boll";
            string expectedValue = "Boll";
            SomeExternalVendorProductAdapter evpa = new SomeExternalVendorProductAdapter(ep);
            // ACT
            var result = evpa;
            // ASSERT
            Assert.AreEqual(expectedValue, result.Title);
        }
    }
}
