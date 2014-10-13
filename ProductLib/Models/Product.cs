using ProductLib.Interfaces;

namespace ProductLib.Models
{
    public class Product : IProduct
    {
        public string Title { get; set; }

        public string BarCode { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
