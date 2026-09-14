using Dictionary_Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Project
{
    public class ProductData
    {
        public int Price { get; set; }
        public int Quentity { get; set; }
    }

    public class Product
    {
        private readonly Dictionary<string, ProductData> _product = new();
        public void AddProduct(string productName, int quentity, int price)
        {

            if (string.IsNullOrWhiteSpace(productName))
                throw new ArgumentException("Product name cannot null or empty.");

            if (quentity <= 0 || price <= 0)
                throw new ArgumentException("Invalid quentity & price must be more than 0");

            if (_product.TryGetValue(productName, out ProductData? product))
                throw new InvalidOperationException("Product already exist");

            ProductData newProduct = new()
            {
                Quentity = quentity,
                Price = price
            };

            _product.Add(productName, newProduct);
        }
        public void SellProduct(string productName, int quentity)
        {

            if (!_product.TryGetValue(productName, out ProductData? product))
                throw new ArgumentException("Product not found");

            if (quentity <= 0) throw new ArgumentException("Invalid quentity");

            if (product.Quentity <= 0)
                throw new InvalidOperationException("Product not available");

            if (product.Quentity < quentity) throw new InvalidOperationException("Product not available as expected quentity.");

            product.Quentity -= quentity;
        }
        public int GetStock(string productName)
        {

            if (!_product.TryGetValue(productName, out ProductData? product))
                throw new KeyNotFoundException("Product not found");

            return product.Quentity;

        }
        public int GetProductValue(string productName)
        {

            if (!_product.TryGetValue(productName, out ProductData? product))
                throw new KeyNotFoundException("Product not found");

            return product.Price * product.Quentity;

        }
    }
}


//2.Product Inventory

//Problem Statement : Create an inventory system.

//Each product has:

//Product Name
//quentity
//Price

//Implement:

//AddProduct(string productName, int quentity, int price)
//SellProduct(string productName, int quentity)
//GetStock(string productName)
//GetProductValue(string productName)

//ProductValue = quentity × Price