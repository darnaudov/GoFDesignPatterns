namespace Strategy
{
    class NormalBilling : IBillingStrategy
    {
        public void CalculateBill(int bill)
        {
            System.Console.WriteLine("Normal bill: " + bill);
        }
    }
}
