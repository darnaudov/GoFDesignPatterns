namespace Adapter
{
    class Editor
    {
        private IShape _shape;

        public Editor(IShape shape)
        {
            _shape = shape;
        }

        public IShape Shape
        {
            get
            {
                return _shape;
            }

            set
            {
                _shape = value;
            }
        }
    }
}
