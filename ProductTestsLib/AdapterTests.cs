﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib.Models;

namespace ProductTestsLib
{
    [TestClass]
    public class AdapterTests
    {
        [TestMethod]
        public void Test_Product()
        {
            // ARRANGE
            Product p = new Product();
            SomeExternalVendorProduct ep = new SomeExternalVendorProduct();
            // ACT

            // ASSERT
        }

        [TestMethod]
        public void Test_SomeExternalVendorProduct()
        {
            
        }
    }
}
