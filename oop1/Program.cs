using System;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            product product1 = new product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName ='Masa';
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            product product2 = new product {Id = 2, CategoryId = 5, ProductName = 'Kalem', UnitPrice = 15 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            






        }
    }
}
