using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq
{
    internal class Program
    {
        static private List<Product> input = new List<Product>()
        {
            new Product(){ Name="고구마", Price=2000 },
            new Product(){ Name="사과", Price=1500 },
            new Product(){ Name="바나나", Price=3000 },
            new Product(){ Name="배", Price=3500 },
            new Product(){ Name="감자", Price=800 },
            new Product(){ Name="토마토", Price=1000 },
            new Product(){ Name="옥수수", Price=2000 },
            new Product(){ Name="자두", Price=800 },
        };
        static void Main(string[] args)
        {
            var output = from item in input
                         where item.Price > 1500
                         orderby item.Name
                         select item;
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
