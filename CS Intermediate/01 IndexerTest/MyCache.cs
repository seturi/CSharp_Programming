using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IndexerTest
{
    class MyCache
    {
        // Dictionary: Key => Value
        private Dictionary<string, string> cache;

        // private Dictionary <string, string> extraCache;

        public MyCache()
        {
            cache = new Dictionary<string, string>();
            //Default Cache Values
            cache.Add("Debug", "false");
            cache.Add("Logging", "true");
        }

        public void Add(string key, string value)
        {
            if (!cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new AccessViolationException("Key already exists");
            }
        }

        private DateTime cacheExpires;

        public DateTime CacheExpires
        {
            get { return cacheExpires; }
            set { cacheExpires = value; }
        }

        public string this[string key]
        {
            get
            {
                if (cache.ContainsKey(key))
                {
                    return cache[key];
                }
                return null;
            }
            set
            {
                if (cache.ContainsKey(key))
                {
                    cache[key] = value;
                }
                else
                {
                    throw new ApplicationException("Key not found");
                }
            }
        }

        public string Get(string key)
        {
            if (cache.ContainsKey(key))
            {
                return cache[key];
            }
            return null;
        }

        public void Set(string key, string value)
        {
            if(cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new ApplicationException("Key not found");
            }
        }


        // ....
    }
}
