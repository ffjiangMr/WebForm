using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Caching
{
    public class STCacheObject<T>
    {
        private Int32 accessedCounter = 0;
        private Int32 renewTheshold;
        private Int32 renewDurationMins;
        private T dataObject;
        private Func<T> updateCallback;

        public STCacheObject(String key, Func<T> callback, Int32 threshold = 100, Int32 duration = 60)
        {
            updateCallback = callback;
            dataObject = updateCallback();
            renewTheshold = threshold;
            renewDurationMins = duration;
            HttpContext.Current.Cache.Insert(key, this, null, Expiry, Cache.NoSlidingExpiration, HandleUpdteCallback);
        }

        public T Data
        {
            get
            {
                accessedCounter++;
                return dataObject;
            }
        }

        public DateTime Expiry
        {
            get
            {
                return DateTime.Now.AddSeconds(10);
            }
        }

        public void AddToCache(Cache cache, String key)
        {

        }

        public void HandleUpdteCallback(String key, CacheItemUpdateReason reason, out Object data, out CacheDependency dependency,
                                         out DateTime absExpiry, out TimeSpan slidingExpiry)
        {
            Boolean renew = accessedCounter >= renewTheshold;
            if (renew)
            {
                dataObject = updateCallback();
                accessedCounter = 0;
            }
            data = renew ? this : null;
            dependency = null;
            slidingExpiry = Cache.NoSlidingExpiration;
            absExpiry = renew ? Expiry : Cache.NoAbsoluteExpiration;
        }
    }
}