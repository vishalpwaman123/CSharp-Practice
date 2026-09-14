using Dictionary_Project;

//----------------------- EXAMPLE 1 ---------------------------

//StockOperation sObject = new();

//sObject.AddStock("TATA", 10);
//sObject.AddStock("TATA", 30);
//sObject.AddStock("TATA", 20);
//sObject.AddStock("TATA", 50);
//sObject.AddStock("TATA", 27);

//sObject.AddStock("TATA", 0); // Throw Exception

//Console.WriteLine("Latest Stock : " + sObject.GetLatestStockPrice("TATA"));
//Console.WriteLine("Average Stock : " + sObject.GetAverageStockPrice("TATA"));
//Console.WriteLine("Highest Stock : " + sObject.GetHighestStockPrice("TATA"));
//Console.WriteLine("Lowest Stock : " + sObject.GetLowestStockPrice("TATA"));

//Console.WriteLine("Lowest Stock : " + sObject.GetLowestStockPrice("TATA1")); // Throw Exception

//----------------------- EXAMPLE 2 ---------------------------

//Student studentObject = new();

//studentObject.AddMarks("VISHAL", 10);
//studentObject.AddMarks("VISHAL", 30);
//studentObject.AddMarks("VISHAL", 40);
//studentObject.AddMarks("VISHAL", 40);
//studentObject.AddMarks("VISHAL", 20);

//Console.WriteLine("Latest Marks : " + studentObject.GetLatestMarks("VISHAL"));
//Console.WriteLine("Average Marks : " + studentObject.GetAverageMarks("VISHAL"));
//Console.WriteLine("Highest Marks : " + studentObject.GetHighestMarks("VISHAL"));

//------------------------ EXAMPLE 3 --------------------------

//Product product = new Product();

//product.AddProduct("TV", 10, 10000);

//Console.WriteLine("Get product Stock Before Sell : " + product.GetStock("TV"));

//product.SellProduct("TV", 5);

//Console.WriteLine("Get product Stock After Sell : " + product.GetStock("TV"));

//Console.WriteLine("Get Product Value : " + product.GetProductValue("TV"));


//------------------------ EXAMPLE 4 ---------------------------

//Url url = new Url();

//string shortCode = url.Shorten("www.google.com");

//Console.WriteLine("Short Code : " + shortCode);

//Console.WriteLine("Url : " + url.GetOriginalUrl(shortCode));

//------------------------ EXAMPLE 5 ---------------------------

//BankAccount bankAccount = new();

//bankAccount.CreateAccount("ACCOUNT_01", "VISHAL", 1000);

//Console.WriteLine("Initial Account Balance : " + bankAccount.GetBalance("ACCOUNT_01"));

//bankAccount.Deposit("ACCOUNT_01", 500);

//Console.WriteLine("Account Balance After Deposit : " + bankAccount.GetBalance("ACCOUNT_01"));

//bankAccount.Withdraw("ACCOUNT_01", 300);

//Console.WriteLine("Account Balance After WithDraw : " + bankAccount.GetBalance("ACCOUNT_01"));

//------------------------- EXAMPLE 6 -----------------------------

ShoppingCart cart = new();

cart.AddItem("P_01", "TV", 1000, 10);
cart.AddItem("P_02", "BIKE", 2000, 10);

Console.WriteLine("Total Price : "+cart.GetTotalAmount("P_01"));

cart.AddItem("P_01", "TV", 1000, 7);
cart.AddItem("P_02", "BIKE", 2000, 7);


Console.WriteLine("Total Price After Adding Same product : " + cart.GetTotalAmount("P_01"));

cart.UpdateQuantity("P_01", 3);
cart.UpdateQuantity("P_02", 3);

Console.WriteLine("Total Price After Updating Same product : " + cart.GetTotalAmount("P_01"));

cart.RemoveItem("P_01");
cart.RemoveItem("P_02");

//Console.WriteLine("Total Price After removing Same product : " + cart.GetTotalAmount("P_01"));



