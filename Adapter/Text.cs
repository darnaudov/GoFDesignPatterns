namespace Adapter
{
    class Text
    {
        private string _text;

        public string TextValue
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }

        public Text(string text)
        {
            _text = text;
        }

        public string WriteText()
        {
            return TextValue;
        }

        public void Update()
        {
            TextValue += " updated";
        }
    }
}
