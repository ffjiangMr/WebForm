using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Caching
{

    class CacheItem
    {
        public Object Data { get; set; }
        public DateTime Expiry { get; set; }
        public Boolean Expired { get { return DateTime.UtcNow > Expiry; } }
    }

    public class CustomOutputCache : OutputCacheProvider
    {

        private ConcurrentDictionary<String, CacheItem> cache;

        public CustomOutputCache() : base()
        {
            cache = new ConcurrentDictionary<string, CacheItem>();
        }

        public override object Add(string key, object entry, DateTime utcExpiry)
        {
            if (cache.ContainsKey(key) && !cache[key].Expired)
            {
                Debug.WriteLine($"Add: Cache already contains item : {key}");
                return Get(key);
            }
            else
            {
                Debug.WriteLine($"Add: Adding new item : {key}");
                Set(key, entry, utcExpiry);
                return entry;
            }
        }

        public override object Get(string key)
        {
            if (cache.ContainsKey(key))
            {
                CacheItem item = cache[key];
                if (!item.Expired)
                {
                    Debug.WriteLine($"Get: Cache contains item : {key}");
                    return item.Data;
                }
                else
                {
                    Debug.WriteLine($"Get: Expired item : {key}");
                }
            }
            return null;
        }

        public override void Remove(string key)
        {
            Debug.WriteLine($"Remove:{key}");
            if (cache.ContainsKey(key))
            {
                cache[key] = null;
            }
        }

        public override void Set(string key, object entry, DateTime utcExpiry)
        {
            Debug.WriteLine($"Set :{key}");
            cache[key] = new CacheItem
            {
                Data = entry,
                Expiry = utcExpiry,
            };
        }
    }
}