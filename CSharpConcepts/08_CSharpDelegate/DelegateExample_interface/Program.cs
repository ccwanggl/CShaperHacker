using System;

namespace DelegateExample_Interface
{
    class Product
    {
        public string Name { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(IProductFactory getProduct)
        {
            Box box = new Box();
            Product product = getProduct.Make();
            box.Product = product;
            return box;
        }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class ToyCarProductFactory:IProductFactory
    {
       public Product Make()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            return product;
        }

    }
    class PizzaProductFactory:IProductFactory
    {
       public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductFactory pizzaFactory = new PizzaProductFactory();
            IProductFactory toycarFactory = new ToyCarProductFactory();
            WrapFactory wrapFactory = new WrapFactory();


            Box box1 = wrapFactory.WrapProduct(pizzaFactory);
            Box box2 = wrapFactory.WrapProduct(toycarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }

}
