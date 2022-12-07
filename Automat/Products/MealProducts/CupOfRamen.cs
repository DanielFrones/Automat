using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.MealProducts
{
    public class CupOfRamen : IProduct
    {
        public int Cost
        {
            get { return 4; }
        }
        public string Buy()
        {
            return "Buying a cup of ramen";
        }

        public string Description()
        {
            return "PHOOO";
        }

        public void Use()
        {
            Console.WriteLine("Eating that cup of ramen ");
            Console.WriteLine("nom.. nom");
            Thread.Sleep(3000);
            Console.WriteLine("nom.. nom");
            Thread.Sleep(2000);
            Console.WriteLine("nom.. nom");
            Thread.Sleep(1000); ;
        }
    }
}
