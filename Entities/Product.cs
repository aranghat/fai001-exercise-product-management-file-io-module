using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /*
     * this serializable class models product data that includes product id, product name, price and in-stock status
     */
        public int productID{get; set;}
        public string productName{get; set;}
        public int in_stockStatus{get; set;}
    
    public class Product
    {
        /*
         * define properties for Product model attributes 
         */

        public Challenge FileReader(){
            StreamReader reader = new StreamReader(@"C:\Users\arpag\Documents\.NET\Myfile.txt");
            var content = reader.ReadToEnd();

            Console.WriteLine(content);
            reader.Close();
        }
    }
    
    public void Create(TheProductModelInfo theproductModelInfo){
        using(ProductStore data = new ProductStore())
        {
            database.TheProductModelInfo.Add()
        

        /*
         * Override ToString() method to return string equivalent of product object containing product details
         */
    }
}
