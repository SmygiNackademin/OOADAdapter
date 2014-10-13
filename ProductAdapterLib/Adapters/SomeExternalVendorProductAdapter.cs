using ProductLib.Interfaces;
using ProductLib.Models;

namespace ProductAdapterLib.Adapters
{
    public class SomeExternalVendorProductAdapter : IProduct
    {
        private readonly SomeExternalVendorProduct _product;

        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct product)
        {
            _product = product;
        }

        public string Title
        {
            get
            {
                return _product.Description;
            }
        }

        public string BarCode
        {
            get { return _product.EANCode; }
        }

        public decimal UnitPrice
        {
            get { return _product.PricePerUnit; }
        }
    }
}
