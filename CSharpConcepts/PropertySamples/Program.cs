using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 存储数据、组合起来表示类或对象当前的状态

namespace PropertySamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdventureWorksLT2012Entities proxy = new AdventureWorksLT2012Entities();

            foreach(Product p in proxy.Product)
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine("==========================");
            Console.WriteLine(proxy.Product.Count());

        }
    }

}
