// See https://aka.ms/new-console-template for more information
using Methods;

Product product = new Product();
product.Name = "Elma";
product.Price = 15;
product.Description = "Amasya Elması";

Product Product2 = new Product();
Product2.Name = "Karpuz";
Product2.Price = 80;
Product2.Description = "Diyarbakır Karpuzu";

Product[] Productler = new Product[] { product, Product2 };

foreach (var Product in Productler)
{
    Console.WriteLine(Product.Name);
    Console.WriteLine(Product.Description);
    Console.WriteLine(Product.Price);
    Console.WriteLine("-----------------");
}
Console.WriteLine("-------------Metotlar------------");
//instance - örnek
CartManager cartManager = new CartManager();
cartManager.Add(product);
cartManager.Add(Product2);

cartManager.Add2("Armut", "Yeşil Armut", 12, 8);
cartManager.Add2("Elma", "Yeşil Elma", 10, 5);
cartManager.Add2("Karpuz", "Diyarbakır Karpuzu", 85, 8);