namespace Adapter
{
    class TextToShapeAdapter : IShape
    {
        private Text _text;

        public TextToShapeAdapter(Text text)
        {
            _text = text;
        }

        public string Change()
        {
            _text.TextValue += " changed";
            _text.Update();

            return _text.TextValue;
        }

        public string Draw()
        {
            _text.WriteText();

            return _text.TextValue;
        }
    }
}
