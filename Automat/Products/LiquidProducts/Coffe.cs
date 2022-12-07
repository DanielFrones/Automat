using Automat.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.LiquidProducts
{
    public class Coffe : IProduct
    {

        public int Cost
        {
            get { return 6; }
        }



        public string Buy()
        {
            return "Buying coffe";

        }

        public string Description()
        {
            return "Hot";
        }

      

        public void Use()
        {
            Console.WriteLine("Drinking that coffe");
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(3000);
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(2000);
            Console.WriteLine("gulp.. gulp");
            Thread.Sleep(1000); ;

        }
    }
}
