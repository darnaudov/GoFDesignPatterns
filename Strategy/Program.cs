namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill(100);

            bill.BillingStrategy = new NormalBilling();
            bill.CalculateBill();

            bill.BillingStrategy = new HappyHourBilling();
            bill.CalculateBill();
        }
    }
}
