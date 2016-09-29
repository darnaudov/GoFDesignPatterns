namespace Strategy
{
    class Bill
    {
        private int _price;
        private IBillingStrategy _billingStrategy;

        public IBillingStrategy BillingStrategy
        {
            get
            {
                return _billingStrategy;
            }

            set
            {
                _billingStrategy = value;
            }
        }

        public Bill(int price)
        {
            _price = price;
        }

        public void CalculateBill()
        {
            _billingStrategy.CalculateBill(_price);
        }
    }
}
