namespace Automat.Wallet
{
    public class Wallet
    {


        public int Total { get; set; } 
        public int Tens { get; init; } = 10;
        public int Fives { get; init; } = 10;

        public int Ones { get; init; } = 10;

        public static Wallet NewWallet()
        {
            return new Wallet();
        }

        public void TotalsLeft()
        {

            Total = (Tens * 10) + (Fives * 5) + (Ones * 1);
        }

        public void ChangeBack()
        {
            int total = Total;
            int tens;
            int ones = 0;
            int fives = 0;

            tens = (total -(total % 10))/10;
            total = total % 10;
            if (total > 0)
            {
                
                fives  = (total - (total % 5)) / 5;
                total = total % 5;
            }
            if (total > 0)
            {
                fives = (total - (total % 1)) / 1;
                total = total % 1;
            }
            Console.WriteLine($"totals left:\n {tens} x 10's \n {fives} x 5's\n {ones} x 1's");

        }

    }
}
