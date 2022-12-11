using Automat.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.LiquidProducts
{
    public class Grogg : IProduct
    {
        public int Cost
        {
            get { return 15; }
        }

        public string Buy()
        {
            return "buying grogg";
        }

        public string Description()
        {
            return "getting u drukn";
        }

        public void Use()
        {
            Console.WriteLine("Drinking that grogg");
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(3000);
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(2000);
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(1000); ;
        }
    }
}
