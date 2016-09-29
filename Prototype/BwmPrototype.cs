namespace Prototype
{
    class BwmPrototype : ICarPrototype
    {
        private string _brand;

        public BwmPrototype()
        {
            _brand = "bwm";
        }

        public ICarPrototype Clone()
        {
            return (ICarPrototype) this.MemberwiseClone();
        }

        public override string ToString()
        {
            return _brand;
        }
    }
}
