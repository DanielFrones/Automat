using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products.RoughWeatherProducts
{
    public class ARealGentlemen : IProduct
    {
        public int Cost
        {
            get { return 100; }
        }
        public string Buy()
        {
            return "Buying a gentlemen";
        }

        public string Description()
        {
            return "Super protective gentlemen";
        }

        public void Use()
        {
            Console.WriteLine("COME HERE YOU GENTLMEN!!!");
        }
    }
}
