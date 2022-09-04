using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Repositories
{
    // this class provides functionalities to read and write product collection data with file

    public class DataContext
    {
         ProductList Product  = new List<ProductList>()
            {
                new ProductList(){ ProductId = 1, ProductName="Bill",Price= 2000,InStock= true},
                new ProductList(){ ProductId = 2, ProductName = "Steve", Price = 3000,InStock= true},
                new ProductList(){ ProductId = 3, ProductName = "Ram", Price = 4000,InStock= true},
                new ProductList(){ ProductId = 4, ProductName = "Abdul", Price = 500,InStock= true},
        };

        public object Product1 { get => Product1; set => Product1 = value; }

        string filepath = @"C:\New folder\temp\New folder\product.xml";
        private string v;
        private string rootFolder;


        // the constructor should accept filename and path strings
        public DataContext(string v, ProductList filepath)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<ProductList>));
            Stream stream = new FileStream(@"C:\New folder\temp\New folder\product.xml", FileMode.OpenOrCreate);
            xml.Serialize(stream, Product);
            Console.WriteLine(Product);
            // the constructor code should open file if it exists else create new

            // the code should read data from file if it contains any data

            // the data read should populate the list of products field

            // if no data is present an empty list should be created 

        }

        public DataContext(string v, string rootFolder)
        {
            this.v = v;
            this.rootFolder = rootFolder;
        }

        // this method should return the list of products read from file
        public void ReadProducts()
        {
            List<string>productList = new List<string>();
            Console.WriteLine("productList");
            foreach (var p in productList)
            {
                Console.WriteLine(p);
            }
            // return data of the product list
        }

        // this method should add the product data passed as parameter to the list of products
        public void AddProduct(ProductList filepath)
        {
            

            // Add items using Add method   
            Product.Add(new ProductList { ProductId = 4, ProductName = "chill", Price = 2000, InStock = true });
            Product.Add(new ProductList { ProductId = 5, ProductName = "dull", Price = 2000, InStock = true });
        }

        // this method should write the data from list of products to file and make data persistent
        public void SaveChanges()
        {
            string name = typeof(T).Name;
            Stream strem = new FileStream($@"C:\New folder\temp\New folder\product.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(List<T>));

           
            // implement serialization
        }

        // this method should delete the file if exists
        public void CleanUp()
        {



            var xmlContent = File.ReadAllText(@"C:\New folder\temp\New folder\product.xml");
            Product = xmlConvert.DeserializeObject<List<Product>>(xmlContent);

            

        }
    }
}
