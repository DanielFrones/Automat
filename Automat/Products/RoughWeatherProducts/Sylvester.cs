using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.RoughWeatherProducts
{
    public class Sylvester : IProduct
    {
        public int Cost
        {
            get { return 50; }
        }
        public string Buy()
        {
            return "Buying a sylvester";
        }

        public string Description()
        {
            return "Super protective coat";
        }

        public void Use()
        {
            Console.WriteLine("Putting on the sylvester");
        }
    }
}
