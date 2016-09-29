namespace Strategy
{
    class HappyHourBilling : IBillingStrategy
    {
        public void CalculateBill(int bill)
        {
            System.Console.WriteLine("Happy hour bill: " + (bill * 0.5));
        }
    }
}
