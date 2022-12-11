using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.MealProducts
{
    public class Haggies : IProduct
    {
        public int Cost
        {
            get { return 2; }
        }
        public string Buy()
        {
            return "Buying that haggies";
        }

        public string Description()
        {
            return "MUUUU";
        }

        public void Use()
        {
            Console.WriteLine("Eating that haggies! ");
            Console.WriteLine("nom.. nom");
            Thread.Sleep(3000);
            Console.WriteLine("nom.. nom");
            Thread.Sleep(2000);
            Console.WriteLine("nom.. nom");
            Thread.Sleep(1000); ;
        }
    }
}
