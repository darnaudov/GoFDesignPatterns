namespace Singleton
{
    class World
    {
        private static World _instance;
        private string _name;

        private World()
        {
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public static World GetInstance()
        {
            if (_instance == null)
            {
                _instance = new World();
            }

            return _instance;
        }
    }
}
