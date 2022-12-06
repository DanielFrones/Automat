
using Automat;
using Automat.LiquidProducts;

using Automat.Wallet;
using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vendingMachine = new VendingMachine();

            //while (vendingMachine.wallet.Total > 0 )
            //{
            vendingMachine.ChooseCategory(vendingMachine.IniateVendingMachine());
            //}
            //Console.WriteLine("No more cash");




            //ILiquidProcuct liquidProcuct =VendingMachine.ChooseLiquid()



        }
    }
}




