using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.MealProducts
{
    public class Burger : IProduct

    {
        public int Cost
        {
            get { return 3; }
        }
        public string Buy()
        {
            return "Buying a burger";
        }

        public string Description()
        {
            return "tripple cheese";
        }

        public void Use()
        {
            Console.WriteLine("Eating that burger ");
            Console.WriteLine("nom.. nom");
            Thread.Sleep(3000);
            Console.WriteLine("nom.. nom");
            Thread.Sleep(2000);
            Console.WriteLine("nom.. nom");
            Thread.Sleep(1000); ;
        }
    }
}
