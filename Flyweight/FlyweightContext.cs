namespace Flyweight
{
    class FlyweightContext
    {
        int _positionX;
        int _positionY;
        string _color;

        public FlyweightContext(int x, int y, string color)
        {
            _positionX = x;
            _positionY = y;
            _color = color;
        }

        public override string ToString()
        {
            return "x: " + _positionX + ", " + "y: " + _positionY + ", " + "color: " + _color;
        }
    }
}
