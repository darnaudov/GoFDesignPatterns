namespace Builder
{
    class Car
    {
        public string Engine
        {
            get;
            set;
        }

        public string Colour
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Colour + " " + Engine;
        }
    }
}
