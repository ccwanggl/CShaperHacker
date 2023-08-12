namespace DelegateExample_callback
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2= new Func<Product>(productFactory.MakeToyCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(func1, log);
            Box box2 = wrapFactory.WrapProduct(func2, log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct, Action<Product> logCallBack)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();

            if(product.Price >= 50)
            {
                logCallBack(product);
            }

            box.Product = product;
            return box;
        }
    }

    class ProductFactory
    {
       public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 30;
            return product;
        }
       public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 100;
            return product;
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' created at {1}, Price is {2}.", product.Name, DateTime.UtcNow, product.Price);
        }
    }
}