using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLib.Interfaces;
using ProductLib.Models;

namespace ProductAdapterLib.Adapters
{
    public class SomeExternalVendorProductAdapter : IProduct
    {
        public string Title { get; set; }

        public SomeExternalVendorProductAdapter(SomeExternalVendorProduct ep)
        {
            Title = ep.Description;
        }
    }
}
