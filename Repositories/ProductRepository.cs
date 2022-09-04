using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class ProductRepository
    {
        readonly DataContext context;
        readonly ProductRepository repository;

        public bool Has { get; private set; }
        public object Assert { get; private set; }
        public bool Is { get; private set; }
        public object ProductId { get; private set; }
        public IEnumerable<object> ProductName { get; private set; }

        // declare field of type DataContext

        public ProductRepository(ProductList filepath)
        {
            string folder = "Product";
            int rootPosition = Environment.CurrentDirectory.IndexOf("bin");
            string rootFolder = Environment.CurrentDirectory.Substring(0, rootPosition - folder.Length - 1);
            context = new DataContext("Products.dat", rootFolder);

            repository = new ProductRepository(context);
            //initialize the DataContext field with parameter passed    
        }

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }

        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public void AddProduct(ProductList filepath)
        {
            var product = new ProductList
            {
                ProductId = 8,
                ProductName = "bull",
                Price = 2500,
                InStock = true
            };
            repository.AddProduct(ProductList);

            Assert.That(repository.GetAllProducts(), Has.Count.EqualTo(1), message: "Count of total products must be 1");

            // code to add product to file, ensuring that product is not null
        }

        private object GetAllProducts()
        {
            throw new NotImplementedException();
        }


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public void RemoveProduct(ProductList filepath)
        {
            var result = repository.RemoveProduct(1001);

            object p = Assert.That(result, Is.True, message: "RemoveProduct() should return true for valid product id");
            object p1 = Assert.That(repository.GetAllProducts(), Has.Count.EqualTo(1), message: "Count of products should be 1");
            // code to remove product by the id provided from file as parameter    
        }

        
        
private object RemoveProduct(int v)
        {
            throw new NotImplementedException();
        }

        public void GetProduct(Product fielpath)
        {

        }

        /*
         * this method should search and return product by product id from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product id
         */
        public bool GetProduct(ProductList fielpath)
        {
            if (Product.ContainsValue(ProductId))
            {
                return true;
            }
            else
            {
                return false;
        }

        
        /*
         * this method should return all items from the product collection
         */
        void GetAllProducts()
        {
            foreach (var i in ProductName)
            {



                Console.WriteLine($"Remaining Products are:{i}");
            }

        }
    }
}
