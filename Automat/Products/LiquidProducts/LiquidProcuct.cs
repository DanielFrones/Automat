using Automat.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Automat.LiquidProducts
{
    public abstract class LiquidProcuct : IProduct
    {
      
        public int Cost { get; set; }

       

        public string Buy()
        {
            return null;
        }
        public string Description()
        {
            return null;
        }

        
        public void Use()
        {
           
        }


    }
}
