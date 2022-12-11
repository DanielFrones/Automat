using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.RoughWeatherProducts
{
    public class Umbrella : IProduct
    {
        public int Cost
        {
            get { return 10; }
        }
        public string Buy()
        {
            return "Buying an umbrella";
        }

        public string Description()
        {
            return "Super protective umbrella";
        }

        public void Use()
        {
            Console.WriteLine("umbrella flared out, ready to encounter rain");
        }
    }
}
