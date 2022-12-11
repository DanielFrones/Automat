namespace Automat.Wallet
{
    public class Wallet
    {


        
        public int Tens { get; set; } = 10;
        public int Fives { get; set; } = 10;

        public int Ones { get; set; } = 10;
        public int Total
        {
            get {
                return (Tens * 10)+(Fives *5)+(Ones*1);
            }
        }

        public static Wallet NewWallet()
        {
            return new Wallet();
        }

     
        public void TotalLeft()
        {
            Console.WriteLine($"Total left in wallet: {Total}");
        }


        public void InsertOnes()
        {
            Ones--;
        }
        public void InsertFives()
        {
            Fives--;
        }

        public void InsertTens()
        {
            Tens--;
        }

        public void ChangeBack(int machineMoney)
        {
            
            int tens= 0 ;
            int ones= 0;
            int fives = 0 ;

            tens = (machineMoney -(machineMoney % 10))/10;
            machineMoney = machineMoney % 10;
            if (machineMoney > 0)
            {
                
                fives  = (machineMoney - (machineMoney % 5)) / 5;
                machineMoney = machineMoney % 5;
            }
            if (machineMoney > 0)
            {
                ones = (machineMoney - (machineMoney % 1)) / 1;
                machineMoney = machineMoney % 1;
            }
            Console.WriteLine($"totals left:\n {tens} x 10's \n {fives} x 5's\n {ones} x 1's back");

            Ones += ones;
            Fives += fives;
            Tens += tens;

        }

    }
}
