using Automat.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.LiquidProducts
{
    public class Milk : IProduct
    {
        public int Cost
        {
            get { return 5; }
        }

        public string Buy()
        {
            return "Buying milk";
        }

        public string Description()
        {
            return "Mothers milk";
        }


        public void Use()
        {
            Console.WriteLine("Drinking that Milk");
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(3000);
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(2000);
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(1000); ;
        }
    }
}
