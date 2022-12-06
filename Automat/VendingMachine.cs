using Automat.Products.LiquidProducts;


using Automat.Products;

namespace Automat
{

    public class VendingMachine
    {
        public Wallet.Wallet wallet = new Wallet.Wallet();

        //TODO = Wallet totals check

        public int IniateVendingMachine()
        {


            int state = 0;
            Console.WriteLine("Vending machine's here, welcome!");
            Console.WriteLine(Common.Choices(5));
            Console.WriteLine("1 for liquid product: \n2 for meal product \n3 for rough waether product\n4 See wallet \n5 Insert Coin \n6 Quit");
            try
            {
                state = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return state;



        }

        public void InsertCoin(int choice)
        {
            if (wallet.Total >= 0)
            {
                switch (choice)
                {

                    case 1:
                        wallet.Ones 

                        break;
                    case 2:
                        Console.WriteLine("meal");
                        break;
                    case 3:
                        Console.WriteLine("rough");
                        break;
                  
                    default:
                        Console.WriteLine("wrong input, go again"); IniateVendingMachine();
                        break;
                }
            }
            Console.WriteLine($"Wallet total = {wallet.Total}\n Wallet is empty, returning you to main menu.");

        }


        public int InitiateInsertCoin()
        {
            int choice = 0;
            Console.WriteLine("Insert coins\n for tens press 1 \n for fives press 2 \n for ones press 3");
            try

            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return choice;

        }
        public int IniateLiquidChoice()
        {
            int state = 0;
            Console.WriteLine(Common.Choices(3));
            Console.WriteLine("1 for Coffe: \n2 for Milk \n3 for Grogg ");
            try

            {
                state = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return state;

        }

        public int IniateMealChoice()
        {
            int state = 0;
            Console.WriteLine(Common.Choices(3));
            Console.WriteLine("1 for Cup of ramen: \n2 for Burger \n3 for Haggis ");
            try

            {
                state = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return state;

        }


        public void ChooseCategory(int choice)
        {


            if (wallet.Total >= 0)
            {
                switch (choice)
                {

                    case 1:
                        ChooseLiquid(IniateLiquidChoice());

                        break;
                    case 2:
                        Console.WriteLine("meal");
                        break;
                    case 3:
                        Console.WriteLine("rough");
                        break;
                    case 4:
                        Console.WriteLine($"\n{wallet.Total} dolla$ left in pocket\n");
                        ChooseCategory(IniateVendingMachine());
                        break;
                    case 5:
                        Console.WriteLine("Insert Coiin");
                        break;
                    case 6:
                        Console.WriteLine("Bye bye");
                        break;

                    default:
                        Console.WriteLine("wrong input, go again"); IniateVendingMachine();
                        break;
                }
            }
            Console.WriteLine($"Wallet total = {wallet.Total}\n Wallet is empty, returning you to main menu.");

        }

        public void ChooseLiquid(int liquid = 0)
        {

            switch (liquid)
            {
                case 1:

                    IProduct coffe = new Coffe();
                    Console.WriteLine($"Would you like to purchase a coffe for: {coffe.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                    var choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            wallet.Total -= coffe.Cost;
                            Console.WriteLine($"Money left to spend: {wallet.Total}");
                            Console.WriteLine("What would you like to drink the coffe?\n 1: yes\n 2: no");
                            liquid = Convert.ToInt32(Console.ReadLine());

                            switch (liquid)
                            {
                                case 1:
                                    coffe.Use();

                                    Console.WriteLine("Back to vending machine");
                                    ChooseCategory(IniateVendingMachine());
                                    break;
                                default:
                                    Console.WriteLine("Coffe spilled, going back to main menu...");
                                    ChooseCategory(IniateVendingMachine());
                                    break;



                            }
                            break;
                        case 2:

                            
                            Console.WriteLine("Hope you can find anything else to enjoy"); IniateVendingMachine();
                            break;


                        default:
                            {
                                ChooseLiquid(liquid);
                                break;
                            }
                    }

                    break;
                case 2:
                    IProduct milk = new Milk();
                    Console.WriteLine($"Would you like to purchase a {milk.Description()} for: {milk.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                    var choiceMilk = Convert.ToInt32(Console.ReadLine());
                    switch (choiceMilk)
                    {
                        case 1:
                            wallet.Total -= milk.Cost;
                            Console.WriteLine($"Money left to spend: {wallet.Total}");
                            Console.WriteLine($"What would you like to drink the {milk.Description()}?\n 1: yes\n 2: no");
                            liquid = Convert.ToInt32(Console.ReadLine());

                            switch (liquid)
                            {
                                case 1:
                                    milk.Use();

                                    Console.WriteLine("Back to vending machine");
                                    ChooseCategory(IniateVendingMachine());
                                    break;
                                default:
                                    Console.WriteLine("Milk spilled, going back to main menu...");
                                    ChooseCategory(IniateVendingMachine());
                                    break;



                            }
                            break;
                        case 2:

                        
                            Console.WriteLine("Hope you can find anything else to enjoy"); IniateVendingMachine();
                            break;


                        default:
                            {
                                ChooseLiquid(liquid);
                                break;
                            }
                    }
                    break;
                case 3:
                    IProduct grogg = new Grogg();
                    Console.WriteLine($"Would you like to purchase a {grogg.Description()} for: {grogg.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                    var choiceGrogg = Convert.ToInt32(Console.ReadLine());
                    switch (choiceGrogg)
                    {
                        case 1:
                            wallet.Total -= grogg.Cost;
                            Console.WriteLine($"Money left to spend: {wallet.Total}");
                            Console.WriteLine($"What would you like to drink the {grogg.Description()}?\n 1: yes\n 2: no");
                            liquid = Convert.ToInt32(Console.ReadLine());

                            switch (liquid)
                            {
                                case 1:
                                    grogg.Use();

                                    Console.WriteLine("Back to vending machine");
                                    ChooseCategory(IniateVendingMachine());
                                    break;
                                default:
                                    Console.WriteLine("Milk spilled, going back to main menu...");
                                    ChooseCategory(IniateVendingMachine());
                                    break;



                            }
                            break;
                        case 2:

                         
                            Console.WriteLine("Hope you can find anything else to enjoy"); IniateVendingMachine();
                            break;


                        default:
                            {
                                ChooseLiquid(liquid);
                                break;
                            }
                    }
                    break;
                default:
                    Console.WriteLine("Oops, wrong input, sending you back..");
                    System.Threading.Thread.Sleep(10000);
                    ChooseCategory(IniateVendingMachine());
                    break;


            }
        }

        public void ChooseMeal(int meal)
        {

            switch (meal)
            {
                case 1:

                    IProduct coffe = new Coffe();
                    Console.WriteLine($"Would you like to purchase a coffe for: {coffe.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                    var choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            wallet.Total -= coffe.Cost;
                            Console.WriteLine($"Money left to spend: {wallet.Total}");
                            Console.WriteLine("What would you like to drink the coffe?\n 1: yes\n 2: no");
                            meal = Convert.ToInt32(Console.ReadLine());

                            switch (meal)
                            {
                                case 1:
                                    coffe.Use();

                                    Console.WriteLine("Back to vending machine");
                                    ChooseCategory(IniateVendingMachine());
                                    break;
                                default:
                                    Console.WriteLine("Coffe spilled, going back to main menu...");
                                    ChooseCategory(IniateVendingMachine());
                                    break;



                            }
                            break;
                        case 2:


                            Console.WriteLine("Hope you can find anything else to enjoy"); IniateVendingMachine();
                            break;


                        default:
                            {
                                ChooseMeal(meal);
                                break;
                            }
                    }

                    break;
                case 2:
                    IProduct milk = new Milk();
                    Console.WriteLine($"Would you like to purchase a {milk.Description()} for: {milk.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                    var choiceMilk = Convert.ToInt32(Console.ReadLine());
                    switch (choiceMilk)
                    {
                        case 1:
                            wallet.Total -= milk.Cost;
                            Console.WriteLine($"Money left to spend: {wallet.Total}");
                            Console.WriteLine($"What would you like to drink the {milk.Description()}?\n 1: yes\n 2: no");
                            var liquid = Convert.ToInt32(Console.ReadLine());

                            switch (liquid)
                            {
                                case 1:
                                    milk.Use();

                                    Console.WriteLine("Back to vending machine");
                                    ChooseCategory(IniateVendingMachine());
                                    break;
                                default:
                                    Console.WriteLine("Milk spilled, going back to main menu...");
                                    ChooseCategory(IniateVendingMachine());
                                    break;



                            }
                            break;
                        case 2:


                            Console.WriteLine("Hope you can find anything else to enjoy"); IniateVendingMachine();
                            break;


                        default:
                            {
                                ChooseLiquid(meal);
                                break;
                            }
                    }
                    break;
                case 3:
                    IProduct grogg = new Grogg();
                    Console.WriteLine($"Would you like to purchase a {grogg.Description()} for: {grogg.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                    var choiceGrogg = Convert.ToInt32(Console.ReadLine());
                    switch (choiceGrogg)
                    {
                        case 1:
                            wallet.Total -= grogg.Cost;
                            Console.WriteLine($"Money left to spend: {wallet.Total}");
                            Console.WriteLine($"What would you like to drink the {grogg.Description()}?\n 1: yes\n 2: no");
                            meal = Convert.ToInt32(Console.ReadLine());

                            switch (meal)
                            {
                                case 1:
                                    grogg.Use();

                                    Console.WriteLine("Back to vending machine");
                                    ChooseCategory(IniateVendingMachine());
                                    break;
                                default:
                                    Console.WriteLine("Milk spilled, going back to main menu...");
                                    ChooseCategory(IniateVendingMachine());
                                    break;



                            }
                            break;
                        case 2:


                            Console.WriteLine("Hope you can find anything else to enjoy"); IniateVendingMachine();
                            break;


                        default:
                            {
                                ChooseLiquid(meal);
                                break;
                            }
                    }
                    break;
                default:
                    Console.WriteLine("Oops, wrong input, sending you back..");
                    System.Threading.Thread.Sleep(1000);
                    ChooseCategory(IniateVendingMachine());
                    break;


            }
        }
        //public void ChooseMeal(int meal)
        //{

        //    switch (liquid)
        //    {
        //        case 1:

        //            ILiquidProcuct coffe = new Coffe();
        //            Console.WriteLine($"Would you like to purchase a coffe for: {coffe.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

        //            var choice = Convert.ToInt32(Console.ReadLine());
        //            switch (choice)
        //            {
        //                case 1:
        //                    wallet.Total -= coffe.Cost;
        //                    Console.WriteLine($"Money left to spend: {wallet.Total}");
        //                    Console.WriteLine("What would you like to drink the coffe?\n 1: yes\n 2: no");
        //                    liquid = Convert.ToInt32(Console.ReadLine());

        //                    switch (liquid)
        //                    {
        //                        case 1:
        //                            coffe.Use();

        //                            Console.WriteLine("Back to vending machine");
        //                            ChooseCategory(IniateVendingMachine());
        //                            break;
        //                        default:
        //                            Console.WriteLine("Coffe spilled, going back to main menu...");
        //                            ChooseCategory(IniateVendingMachine());
        //                            break;



        //                    }
        //                    break;
        //                case 2:

        //                    coffe.Dispose();
        //                    Console.WriteLine("Hope you can find anything else to enjoy"); IniateVendingMachine();
        //                    break;


        //                default:
        //                    {
        //                        ChooseLiquid(liquid);
        //                        break;
        //                    }
        //            }

        //            break;
        //        case 2:
        //            new Milk();
        //            break;
        //        case 3:
        //            new Grogg();
        //            break;
        //        default:
        //            Console.WriteLine("");
        //            break;


        //    }
        //}




    }
}
