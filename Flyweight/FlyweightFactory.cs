using System.Collections.Generic;

namespace Flyweight
{
    class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<string, Flyweight>();
        }

        public Flyweight GetFlyweight(string key)
        {
            if(!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = new Flyweight(key);
            }

            return _flyweights[key];
        }
    }
}
