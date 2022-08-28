using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /*
     * this serializable class models product data that includes product id, product name, price and in-stock status
     */

    public class ProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public bool InStock { get; set; }
        public override string ToString()
        {
            return $"ID:{ProductId}, Name:{ProductName}, price:{Price},Instock:{InStock}";
        }

        public static implicit operator ProductList(List<ProductList> v)
        {
            throw new NotImplementedException();
        }

        public void Add(ProductList product)
        {
            throw new NotImplementedException();
        }

        /*
         * Override ToString() method to return string equivalent of product object containing product details
         */
    }
}
