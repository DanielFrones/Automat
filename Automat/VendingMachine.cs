using Automat.Products;
using Automat.Products.LiquidProducts;

namespace Automat
{

    public class VendingMachine
    {
        //The wallet for storing the coins, and totals
        public Wallet.Wallet wallet = new Wallet.Wallet();

        //Total put in the machine
        int cashInMachine = 0;

        public void TotalCashInMachine()
        {
            Console.WriteLine($"Total cash left in machine = {cashInMachine}");
        }


        //Starts the vending machine choices
        public int IniateVendingMachine()
        {


            int state = 0;
            Console.WriteLine($"Vending machine's here, welcome! {cashInMachine}$ Left");
            Console.WriteLine(Common.Choices(7));
            Console.WriteLine("1 for liquid product: \n2 for meal product \n3 for rough waether product\n4 See wallet \n5 Insert Coin \n6 Get change back \n7 Quit");
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

        //The main categories to chose from in machine
        public void ChooseCategory(int choice)
        {


            if (cashInMachine >= 0)
            {
                switch (choice)
                {

                    case 1:
                        if (cashInMachine >= 5)
                            ChooseLiquid(IniateLiquidChoice());
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Not enough money insert more cash, back to main menu!");
                            ChooseCategory(IniateVendingMachine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("meal");
                        break;
                    case 3:
                        Console.WriteLine("rough");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"\n{wallet.Total} dolla$ left in pocket\n");
                        ChooseCategory(IniateVendingMachine());
                        break;
                    case 5:
                        TotalCashInMachine();
                        InsertCoin(InitiateInsertCoin());
                        break;
                    case 6:
                        wallet.ChangeBack(cashInMachine);
                        cashInMachine = 0;
                        ChooseCategory(IniateVendingMachine());
                        break;
                    case 7:
                        Console.WriteLine("Bye bye");
                        break;

                    default:
                        Console.WriteLine("wrong input, go again"); IniateVendingMachine();
                        break;
                }
            }
            Console.WriteLine($"Wallet total = {wallet.Total}\n Wallet is empty, returning you to main menu.");

        }


        //Coin method loop for inserting multiple values.
        public void InsertCoin(int choice)
        {
            if (wallet.Total >= 0)
            {
                bool secondRun = true;
                bool cashLoop = true;
                while (cashLoop)
                {
                    if (secondRun)
                    {


                        switch (choice)
                        {

                            case 1:
                                wallet.InsertOnes();
                                cashInMachine++;
                                TotalCashInMachine();
                                secondRun = false;
                                break;
                            case 2:
                                wallet.InsertFives();
                                cashInMachine = cashInMachine + 5;
                                TotalCashInMachine();
                                secondRun = false;
                                break;
                            case 3:
                                wallet.InsertTens();
                                cashInMachine = cashInMachine + 10;
                                TotalCashInMachine();
                                secondRun = false;
                                break;
                            case 4:
                                cashLoop = false;
                                secondRun = false;
                                break;


                            default:
                                Console.WriteLine("wrong input, go again"); InsertCoin(InitiateInsertCoin());
                                break;
                        }
                    }
                    else { InsertCoin(InitiateInsertCoin()); }
                }
            }
            Console.Clear();
            Console.WriteLine($"Wallet total = {wallet.Total}");
            TotalCashInMachine();
            ChooseCategory(IniateVendingMachine());
        }

        //choose from different values to put in the machine
        public int InitiateInsertCoin()
        {
            int choice = 0;
            Console.WriteLine("Insert coins\n for ones press 1 \n for fives press 2 \n for tens press 3 \n To stop press 4");
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


        //liquid type of choise
        public int IniateLiquidChoice()
        {
            int state = 0;
            Console.WriteLine(Common.Choices(3));
            Console.WriteLine($"1 for Coffe (6$): \n2 for Milk(5$) \n3 for Grogg(15$) ");
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

        //Meal type of choice
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


        //liquid switch
        public void ChooseLiquid(int liquid = 0)
        {

            switch (liquid)
            {
                case 1:

                    IProduct coffe = new Coffe();
                    if (coffe.Cost < cashInMachine)
                    {
                        Console.WriteLine($"Would you like to purchase a coffe for: {coffe.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                        var choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                cashInMachine -= coffe.Cost;
                                TotalCashInMachine();
                                Console.WriteLine("What would you like to drink the coffe?\n 1: yes\n 2: no");
                                liquid = Convert.ToInt32(Console.ReadLine());

                                switch (liquid)
                                {
                                    case 1:
                                        coffe.Use();
                                        Console.Clear();
                                        Console.WriteLine("Back to vending machine");
                                        ChooseCategory(IniateVendingMachine());
                                        break;
                                    default:
                                        Console.Clear();
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
                    }
                    else
                    {
                        Console.WriteLine("Not enough money in machine, back to main menu..");
                        ChooseCategory(IniateVendingMachine());
                    }
                    break;



                case 2:
                    IProduct milk = new Milk();
                    if (milk.Cost < cashInMachine)
                    {


                        Console.WriteLine($"Would you like to purchase a {milk.Description()} for: {milk.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                        var choiceMilk = Convert.ToInt32(Console.ReadLine());
                        switch (choiceMilk)
                        {
                            case 1:
                                cashInMachine -= milk.Cost;
                                TotalCashInMachine();
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
                    }
                    else
                    {
                        Console.WriteLine("Not enough money in machine, back to main menu..");
                        ChooseCategory(IniateVendingMachine());
                    }
                    break;




                case 3:
                    IProduct grogg = new Grogg();
                    Console.WriteLine($"Would you like to purchase a {grogg.Description()} for: {grogg.Cost}$ ?\n 1: yes\n2: no(Back to main menu)");

                    var choiceGrogg = Convert.ToInt32(Console.ReadLine());
                    switch (choiceGrogg)
                    {
                        case 1:
                            cashInMachine -= grogg.Cost;
                            TotalCashInMachine();
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

        //meal switch
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
                            cashInMachine -= coffe.Cost;
                            Console.WriteLine($"Money left to spend: {cashInMachine}");
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
                            cashInMachine -= milk.Cost;
                            Console.WriteLine($"Money left to spend: {cashInMachine}");
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
                            cashInMachine -= grogg.Cost;
                            Console.WriteLine($"Money left to spend: {cashInMachine}");
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



    }
}
