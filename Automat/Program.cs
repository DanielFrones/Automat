
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

            //New instance of a vending machine.
            var vendingMachine = new VendingMachine();

            // Runs the main menu of the vending machine.
            vendingMachine.ChooseCategory(vendingMachine.IniateVendingMachine());
            


        }
    }
}




