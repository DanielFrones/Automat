using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Products
{
   public static  class Common
    {
        public static string Choices(int amount)
        {
            return $"You have {amount} options to choose between. Press the number you want to order:";
        }


        public static void NotEnoughMoney()
        {
            Console.WriteLine("Not enough money insert more cash for any of these items, back to main menu!"); 
        }
    }
}
