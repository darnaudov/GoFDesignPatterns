namespace Visitor
{
    class Car : CarElement
    {
        CarElement[] _elements;

        public Car (CarElement[] elements)
        {
            _elements = elements;
        }

        public void accept(CarElementVisitor visitor)
        {
            foreach (CarElement element in _elements)
            {
                element.accept(visitor);
            }
        }

    }
}
