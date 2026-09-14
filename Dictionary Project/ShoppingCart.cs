using Dictionary_Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Project
{
    public class ShoppingCartInfo
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quentity { get; set; }
    }

    public class ShoppingCart
    {
        private readonly Dictionary<string, ShoppingCartInfo> _cart = new();

        public void AddItem(string productId, string productName, int price, int quentity)
        {
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(productId))
                throw new ArgumentException("Product Id & Name is required.");

            if (price <= 0 || quentity <= 0)
                throw new ArgumentException("Price & Quentity must greater than 0");

            if (_cart.TryGetValue(productId, out ShoppingCartInfo? shoppingCart))
            {
                shoppingCart.Quentity += quentity;
                return;
            }

            ShoppingCartInfo newShoppingCart = new()
            {
                ProductName = productName,
                Price = price,
                Quentity = quentity
            };

            _cart.Add(productId, newShoppingCart);
            return;
        }

        public void RemoveItem(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId))
                throw new ArgumentException("Product Id is required");

            if (!_cart.TryGetValue(productId, out ShoppingCartInfo? shoppingCart))
                throw new InvalidOperationException("Shopping Cart not found");

            _cart.Remove(productId);
        }

        public void UpdateQuantity(string productId, int quentity)
        {
            if (string.IsNullOrWhiteSpace(productId))
                throw new ArgumentException("Product Id is required");

            if (quentity <= 0)
                throw new ArgumentException("qentity must greater than 0");

            if (!_cart.TryGetValue(productId, out ShoppingCartInfo? shoppingCart))
                throw new InvalidOperationException("Shopping Cart not found");

            shoppingCart.Quentity += quentity;
        }

        public int GetTotalAmount(string productId)
        {
            if (string.IsNullOrWhiteSpace(productId))
                throw new ArgumentException("product Id is required");

            if (!_cart.TryGetValue(productId, out ShoppingCartInfo? shoppingCart))
                throw new InvalidOperationException("Shopping cart not found");

            return shoppingCart.Quentity * shoppingCart.Price;
        }
    }
}


//6.Shopping Cart
//Problem Statement

//Create a shopping cart.

//Each item has:

//ProductId
//ProductName
//Price
//Quantity

//Implement:

//AddItem(...)
//RemoveItem(productId)
//UpdateQuantity(productId, quantity)
//GetTotalAmount()

//If the same product is added twice, increase its quantity instead of creating another item.

//Input
//Add 101 Laptop 50000 1
//Add 102 Mouse 500 2
//Add 101 Laptop 50000 2

//Output
//Laptop: 3
//Mouse: 2

//Total: 151000