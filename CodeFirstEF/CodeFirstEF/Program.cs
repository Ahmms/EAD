// See https://aka.ms/new-console-template for more information
using CodeFirstEF;

Console.WriteLine("Hello, World!");
var dB = new MyShop();
//Product p = new Product();
//p.Name = "Cycle";
//p.Price = 15;
//dB.Products.Add(p);
//await dB.SaveChangesAsync();

dB.Products.Where(p => p.Name.StartsWith("B")).ToList().ForEach(p => Console.WriteLine($"{p.ID}:{p.Name}:{p.Price}"));