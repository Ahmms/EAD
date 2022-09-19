// See https://aka.ms/new-console-template for more information
using DBFirstApproch.Models;

Console.WriteLine("Hello, World!");
var db = new MyShopContext();
db.Products.ToList().ForEach(p =>Console.WriteLine(p.Name));
