namespace Prototype
{
    class FaitPrototype : ICarPrototype
    {
        private string _brand;

        public FaitPrototype()
        {
            _brand = "fait";
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
